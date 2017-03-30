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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            var topicsFile = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
            var Topics = topicsFile.Descendants("Topics").FirstOrDefault();
            int i = 0;
            foreach (XElement topic in Topics.Nodes())//Parsing Topics
            {
                int id = Int32.Parse(topic.Attribute("id").Value);
                string name = topic.Attribute("name").Value;
                topicsComboBox.Items.Add("Id = " + id.ToString() + " Название = " + name);
            }
            topicsComboBox.SelectedIndex = 0;

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            int selectedTopicId = 0;
            try
            {
                selectedTopicId = Int32.Parse(topicsComboBox.Text.Split().ToList()[2]);
            }
            catch
            {
                string caption = "Ошибка";
                string message = "Выберите тему";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);
                return;
            }
            var topicsFile = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
            var factsFile = XDocument.Load("../../DataBase/Knowledgebase.xml").Root;
            var facts = factsFile.Descendants("Facts").FirstOrDefault();
            var Topics = topicsFile.Descendants("Topics").FirstOrDefault();
            var Topic = Topics.Descendants("Topic").Where(o => Int32.Parse(o.Attribute("id").Value) == selectedTopicId).FirstOrDefault();
            var Questions = Topic.Descendants("Questions").FirstOrDefault();
            List<QuestionModel> QuestionsList = new List<QuestionModel>();

            foreach(XElement question in Questions.Nodes())
            {
                List<Fact> QuestionFacts = new List<Fact>();
                List<Fact> AnswersFacts = new List<Fact>();

                foreach (string factId in question.Attribute("questionRule").Value.Split().ToList())
                {
                    var fact = facts.Descendants("Fact").Where(o => o.Attribute("id").Value == factId).FirstOrDefault();
                    QuestionFacts.Add(new Fact { ID = Int32.Parse(fact.Attribute("id").Value), 
                        Value = fact.Attribute("value").Value, 
                        Attribute = fact.Attribute("attribute").Value, 
                        Object = fact.Attribute("object").Value });
                }
                foreach (string factId in question.Attribute("answerIds").Value.Split().ToList())
                {
                    var fact = facts.Descendants("Fact").Where(o => o.Attribute("id").Value == factId).FirstOrDefault();
                    AnswersFacts.Add(new Fact
                    {
                        ID = Int32.Parse(fact.Attribute("id").Value),
                        Value = fact.Attribute("value").Value,
                        Attribute = fact.Attribute("attribute").Value,
                        Object = fact.Attribute("object").Value
                    });
                }
                QuestionsList.Add(new QuestionModel { id = Int32.Parse(question.Attribute("id").Value), 
                    questionText = question.Attribute("questionText").Value, 
                    QuestionFacts = QuestionFacts, QuestionAnswers = AnswersFacts });
            }

            Question questionPage = new Question(QuestionsList, 0, QuestionsList.Count);
            this.Hide();
            questionPage.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FactsAndRulesCreatingView configView = new FactsAndRulesCreatingView();
            this.Hide();
            configView.Show();
        }
    }
}
