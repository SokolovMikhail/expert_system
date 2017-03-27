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
        int lastTopicId;
        int lastQuesionId;
        List<Rule> RulesList;
        List<Fact> FactsList;
        List<Topic> TopicsList;
        public FactsAndRulesCreatingView()
        {
            int lastQuesionId = 0;
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
                answerText1.Items.Add("Id = " + id.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText2.Items.Add("Id = " + id.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText3.Items.Add("Id = " + id.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText4.Items.Add("Id = " + id.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
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

            //topicComboBox.Items.Add("1");

            TopicsList = new List<Topic>();
            var topics = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
            var Topics = topics.Descendants("Topics").FirstOrDefault();
            foreach (XElement topic in Topics.Nodes())//Parsing Topics
            {
                id = Int32.Parse(topic.Attribute("id").Value);
                string name = topic.Attribute("name").Value;
                TopicsList.Add(new Topic { ID = id, Name = name });
                topicsListView.Items.Add("Id = " + id.ToString() + ", Название = " + name);
                topicComboBox.Items.Add("Id = " + id.ToString() + " Название = " + name);
            }
            lastTopicId = id;




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
                answerText1.Items.Add("Id = " + lastFactId.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText2.Items.Add("Id = " + lastFactId.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText3.Items.Add("Id = " + lastFactId.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
                answerText4.Items.Add("Id = " + lastFactId.ToString() + " Объект = " + obj + ", Атрибут = " + attribute + ", Значение = " + value);
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
            
            foreach(string word in conditions)
            {
                int factId = 0;
                if (word != "^" && word != "v" && word != "(" && word != ")")
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

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult resultDialog;
            string caption = "Ошибка";

            string question1 = questionText1.Text;
            string question2 = questionText2.Text;
            string answer1 = answerText1.Text;
            string answer2 = answerText2.Text;
            string answer3 = answerText3.Text;
            string answer4 = answerText4.Text;

            if (question1 == "" || question2 == "" || answer1 == "" || answer2 == "" || answer3 == "" || answer4 == "")
            {
                string message = "Заполните все поля";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }

            List<string> factsIds = question2.Split().ToList();

            foreach(string id in factsIds)
            {
                int numId;
                if(!Int32.TryParse(id, out numId))
                {
                    string message = "Id фактов должны быть целочисленными";
                    resultDialog = MessageBox.Show(this, message, caption, buttons);
                    return;
                }
                
                try
                {
                    Fact fact = FactsList.Where(o => o.ID == numId).First();
                }
                catch
                {
                    string message = "Факта с id |" + id + "| не существует";
                    resultDialog = MessageBox.Show(this, message, caption, buttons);
                    return;
                }
            }
            try
            {
                int selectedTopicId = Int32.Parse(topicComboBox.Text.Split().ToList()[2]);
                var document = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
                var Topics = document.Descendants("Topics").FirstOrDefault();
                var Topic = Topics.Descendants("Topic").Where(o => Int32.Parse(o.Attribute("id").Value) == selectedTopicId).FirstOrDefault();
                var Questions = Topic.Descendants("Questions").FirstOrDefault();
                lastQuesionId++;
                Questions.Add(new XElement("Question", new XAttribute("id", lastQuesionId), new XAttribute("questionText", question1), new XAttribute("questionRule", question2), new XAttribute("answerIds", answer1.Split().ToList()[2] + " " + answer2.Split().ToList()[2] + " " + answer3.Split().ToList()[2] + " " + answer4.Split().ToList()[2])));
                questionsList.Items.Add("Id = " + lastQuesionId.ToString() + " Вопрос = " + question1 + "\n Факты = " + question2);
                document.Save("../../DataBase/TopicsAndQuestions.xml");
            }
            catch
            {
                string message = "Выберите тему, в которую вы хотите добавить вопрос";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }

        }

        private void topicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as System.Windows.Forms.ComboBox;
            try
            {
                int selectedId = Int32.Parse(obj.Text.Split().ToList()[2]);
                TopicsList = new List<Topic>();
                var topicsFile = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
                var Topics = topicsFile.Descendants("Topics").FirstOrDefault();
                var Topic = Topics.Descendants("Topic").Where(o => Int32.Parse(o.Attribute("id").Value) == selectedId).FirstOrDefault();
                var Questions = Topic.Descendants("Questions");
                int id = -1;
                questionsList.Items.Clear();
                foreach (XElement question in Questions.Nodes())
                {
                    id = Int32.Parse(question.Attribute("id").Value);
                    string questionText = question.Attribute("questionText").Value;
                    string questionRule = question.Attribute("questionRule").Value;
                    //string answerIds = question.Attribute("answerIds").Value;
                    questionsList.Items.Add("Id = " + id.ToString() + " Вопрос = " + questionText + "\n Факты = " + questionRule);
                }
                lastQuesionId = id;
            }
            catch
            {
                return;
            }

        }

        private void topicAddButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult resultDialog;
            string caption = "Ошибка";
            string topicName = topicNameText.Text;
            if(topicName == "")
            {
                string message = "Заполните поле";
                resultDialog = MessageBox.Show(this, message, caption, buttons);
                return;
            }

            var topicsFile = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
            var Topics = topicsFile.Descendants("Topics").FirstOrDefault();
            lastTopicId++;
            Topics.Add(new XElement("Topic", new XAttribute("id", lastTopicId), new XAttribute("name", topicName)));
            var Topic = Topics.Descendants("Topic").Where(o => Int32.Parse(o.Attribute("id").Value) == lastTopicId).FirstOrDefault();
            Topic.Add(new XElement("Questions"));
            Topic.Add(new XElement("Answers"));
            topicsFile.Save("../../DataBase/TopicsAndQuestions.xml");
            topicComboBox.Items.Add("Id = " + lastTopicId + " Название = " + topicName);
            topicsListView.Items.Add("Id = " + lastTopicId + " Название = " + topicName);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
