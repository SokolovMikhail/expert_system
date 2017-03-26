using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpertSystem
{
    public partial class FactsAndRulesCreatingView : Form
    {
        int lastFactId;
        int lastRuleId;
        List<Rule> RulesList;
        List<Fact> FactsList;
        public FactsAndRulesCreatingView()
        {
            lastFactId = 0;
            lastRuleId = 0;
            InitializeComponent();
            var document = XDocument.Load("../../DataBase/Knowledgebase.xml").Root;
            var Facts = document.Descendants("Facts").FirstOrDefault();
            int id = 0;
            FactsList = new List<Fact>();
            foreach (XElement fact in Facts.Nodes())//Parsing Facts
            {
                id = Int32.Parse(fact.Attribute("id").Value);
                string obj = fact.Attribute("object").Value;
                string attribute = fact.Attribute("attribute").Value;
                string value = fact.Attribute("value").Value;
                FactsList.Add(new Fact { ID = id, Object = obj, Attribute = attribute, Value = value });
                factsList.Items.Add("Id = " + id.ToString() + ", Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                lastFactId++;
            }
            lastFactId = id;

            id = 0;
            var Rules = document.Descendants("Rules").FirstOrDefault();
            RulesList = new List<Rule>();
            foreach (XElement rule in Rules.Nodes())//Parsing Rules
            {
                id = Int32.Parse(rule.Attribute("id").Value);
                string condition = rule.Attribute("if").Value;
                string result = rule.Attribute("result").Value;
                rulesList.Items.Add("Id = " + id.ToString() + ", Условие = |" + condition + "|, Результат = " + result);
                //var FactsIds = condition.Split().ToList().Where(o=> o!="^" && o!="v");
                //FactsList.Where(o => FactsIds.Contains(o.ID.ToString())).ToList()
                RulesList.Add(new Rule {ID = id, 
                    Conclusion = FactsList.Where(o => o.ID == Int32.Parse(result)).FirstOrDefault(), 
                    Facts = condition});

            }
            lastRuleId = id;
            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void addFactButton_Click(object sender, EventArgs e)
        {
            string obj = objectText.Text;
            string attribute = attributeText.Text;
            string value = valueText.Text;
            if (obj != "" && attribute != "" && value != "")
            {
                var document = XDocument.Load("../../DataBase/Knowledgebase.xml").Root;
                var Facts = document.Descendants("Facts").FirstOrDefault();
                Facts.Add(new XElement("Fact", new XAttribute("id", lastFactId + 1), new XAttribute("object", obj), new XAttribute("attribute", attribute), new XAttribute("value", value)));
                lastFactId++;
                FactsList.Add(new Fact { ID = lastFactId , Object = obj, Attribute = attribute, Value = value});
                factsList.Items.Add("Id = " + lastFactId.ToString() + ", Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                document.Save("../../DataBase/Knowledgebase.xml");
            }
            else
            {
                string message = "Не все поля заполнены";
                string caption = "Ошибка";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult resultDialog;
                resultDialog = MessageBox.Show(this, message, caption, buttons);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult resultDialog;
            string caption = "Ошибка";
            string conditionsResult = "";
            if (condtionText.Text == "" || resultText.Text == "")
            {
                string message = "Заполните оба поля";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }
            List<string> conditions = condtionText.Text.Split().ToList();
            List<string> result = resultText.Text.Split().ToList();
            List<Fact> resultFacts = new List<Fact>();
            //Fact factttt = FactsList.Where(o => o.ID == 5).First();
            
            foreach(string word in conditions)
            {
                int factId = 0;
                if (word != "^" && word != "v")
                {
                    try
                    {
                        factId = Int32.Parse(word);
                    }
                    catch
                    {
                        string message = "Условие должно содержать только целочисленные ID фактов и знаки конъюнкции(^) и дизъюнкции(v)";

                        resultDialog = MessageBox.Show(this, message, caption, buttons);
                        return;
                    }
                    try
                    {
                        Fact bufFact = FactsList.Where(o => o.ID == factId).First();
                        conditionsResult += bufFact.ID.ToString() + " ";
                        resultFacts.Add(bufFact);
                    }
                    catch
                    {
                        string message = "Факта с id |" + factId.ToString() + "| не существует";
                        resultDialog = MessageBox.Show(this, message, caption, buttons);
                        return;
                    }
                }


            }

            if(result.Count != 1)
            {
                string message = "Результатом правила может быть только один ID";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }
            int resultid;
            try
            {
                resultid = Int32.Parse(result[0]);
            }
            catch
            {
                string message = "ID должен быть целочисленным";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }
            try 
            { 
                Fact ResultFact = FactsList.Where(o=> o.ID == resultid).First();
                lastRuleId++;
                Rule rule = new Rule { ID = lastRuleId, Conclusion = ResultFact, Facts = condtionText.Text };

                rulesList.Items.Add("Id = " + lastRuleId.ToString() + ", Условие = |" + condtionText.Text + "|, Результат = " + ResultFact.ID);

                var document = XDocument.Load("../../DataBase/Knowledgebase.xml").Root;
                var Rules = document.Descendants("Rules").FirstOrDefault();
                Rules.Add(new XElement("Rule", new XAttribute("id", lastRuleId), new XAttribute("if", condtionText.Text), new XAttribute("result", ResultFact.ID.ToString())));
                document.Save("../../DataBase/Knowledgebase.xml");

                
            }
            catch
            {
                string message = "Факта с id |" + resultid.ToString() + "| не существует";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }



        }
    }
}
