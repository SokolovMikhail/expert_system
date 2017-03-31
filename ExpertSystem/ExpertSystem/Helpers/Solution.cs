using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExpertSystem
{
    public static class Solution
    {
        private static List<Rule> RulesList;
        private static List<Fact> FactsList;

        public static List<Fact> Solve(QuestionModel Question)
        {

            List<string> factsIdsList = new List<string>();
            List<Fact> ResultFacts = new List<Fact>();
            foreach(Fact fact in Question.QuestionFacts)
            {
                factsIdsList.Add(fact.ID.ToString());
                ResultFacts.Add(fact);
            }
            var document = XDocument.Load("../../DataBase/Knowledgebase.xml").Root;
            var Rules = document.Descendants("Rules").FirstOrDefault();
            var Facts = document.Descendants("Facts").FirstOrDefault();

            FactsList = new List<Fact>();
            foreach (XElement fact in Facts.Nodes())//Parsing Facts
            {
                int id = Int32.Parse(fact.Attribute("id").Value);
                string obj = fact.Attribute("object").Value;
                string attribute = fact.Attribute("attribute").Value;
                string value = fact.Attribute("value").Value;
                FactsList.Add(new Fact { ID = id, Object = obj, Attribute = attribute, Value = value });
            }

            RulesList = new List<Rule>();
            foreach (XElement rule in Rules.Nodes())//Parsing Rules
            {
                int id = Int32.Parse(rule.Attribute("id").Value);
                string condition = rule.Attribute("if").Value;
                string result = rule.Attribute("result").Value;
                RulesList.Add(new Rule
                {
                    ID = id,
                    Conclusion = FactsList.Where(o => o.ID == Int32.Parse(result)).FirstOrDefault(),
                    Facts = condition
                });

            }
            int startResultListCount = ResultFacts.Count;
            //---------------------Отбираем факты--------------------------------------------------------------
            do
            {
                startResultListCount = ResultFacts.Count;
                foreach(Rule rule in RulesList)
                {
                    List<string> output = RPN.GetExpression(rule.Facts).Split().ToList();
                    output = RemoveEmptyEntries(output);
                    int i = 0;
                    //string a = output[i + 2];
                    do
                    {
                        if (output.Count > 2)
                        {
                            if (output[i + 2] != "^" && output[i + 2] != "v")//Ищем знак действия
                            {
                                i++;
                                continue;
                            }
                            else
                            {
                                if (output[i + 2] == "^")//Если конъюнкция
                                {
                                    if ((factsIdsList.Contains(output[i]) && factsIdsList.Contains(output[i + 1])) || (factsIdsList.Contains(output[i]) && output[i + 1] == "1True") || (factsIdsList.Contains(output[i + 1]) && output[i] == "1True") || (output[i + 1] == "1True" && output[i] == "1True"))//Если оба факта поданы в вопросе, то заменить 1True
                                    {
                                        output[i] = "1True";
                                        output.RemoveRange(i + 1, 2);
                                        i = 0;
                                        continue;
                                    }
                                    else
                                    {
                                        output[i] = "1False";
                                        output.RemoveRange(i + 1, 2);
                                        i = 0;
                                        continue;
                                        //break;//если кого то из фактов не было подано, то больше не рассматриваем правило
                                    }
                                }
                                if (output[i + 2] == "v")//Если дизъюнкция
                                {
                                    if ((factsIdsList.Contains(output[i]) || factsIdsList.Contains(output[i + 1])) || (output[i + 1] == "1True") || (output[i] == "1True") || (output[i] == "1False" && output[i + 1] == "1True") || (output[i] == "1True" && output[i + 1] == "1False"))//Если оба факта поданы в вопросе, то заменить 1True
                                    {
                                        output[i] = "1True";
                                        output.RemoveRange(i + 1, 2);
                                        i = 0;
                                        continue;
                                    }
                                    else
                                    {
                                        output[i] = "1False";
                                        output.RemoveRange(i + 1, 2);
                                        i = 0;
                                        continue;
                                        //break;//если кого то из фактов не было подано, то больше не рассматриваем правило
                                    }
                                }
                            }
                        }
                        else
                        {
                            if(output.Count == 1)//Если только один факт
                            {
                                if (factsIdsList.Contains(output[i]))
                                {
                                    output[i] = "1True";
                                    i = 0;
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    while (output.Count != 1);

                    if (output.Count == 1 && output[0] == "1True" && (!ResultFacts.Contains(rule.Conclusion)))
                    {
                        ResultFacts.Add(rule.Conclusion);
                        factsIdsList.Add(rule.Conclusion.ID.ToString());
                    }
                }
            }
            while(startResultListCount != ResultFacts.Count);
            //---------------------Конец отбора фактов--------------------------------------------------------------
            int j = 0;
            return ResultFacts;
        }

        private static List<string> RemoveEmptyEntries(List<string> list)
        {
            List<string> ResultList = list.Where(o => o != "").ToList();
            return ResultList;
        }
    }
}
