using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ExpertSystem
{
    public partial class ChooseTopic : Form
    {
        List<QuestionModel> QuestionsList;
        List<AnswerModel> AnswersList;
        public ChooseTopic()
        {
            InitializeComponent();
        }

        private void topic1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrepareQuestions(0);
            Question question = new Question(QuestionsList, AnswersList, 0, 0);
            question.Show();
        }

        private void PrepareQuestions(int topicId)
        {
            var document = XDocument.Load("../../DataBase/TopicsAndQuestions.xml").Root;
            var Topics = document.Element("Topics");
            foreach (XElement topic in Topics.Nodes())
            {
                if (topic.Attribute("id").Value == topicId.ToString())
                {
                    var Questions = topic.Element("Questions");
                    var Answers = topic.Element("Answers");
                    QuestionsList = new List<QuestionModel>();
                    AnswersList = new List<AnswerModel>();

                    foreach (XElement question in Questions.Nodes())
                    {
                        QuestionsList.Add(new QuestionModel
                        {
                            id = Int32.Parse(question.Attribute("id").Value),
                            question = question.Attribute("question").Value,
                            answersIds = question.Attribute("answerIds").Value,
                            correctAnswerId = Int32.Parse(question.Attribute("correctAnswerId").Value)
                        });
                    }

                    foreach (XElement answer in Answers.Nodes())
                    {
                        AnswersList.Add(new AnswerModel 
                        {
                            id = Int32.Parse(answer.Attribute("id").Value),
                            Value = answer.Attribute("value").Value
                        });
                    }
                    break;
                }
            }
        }
    }
}
