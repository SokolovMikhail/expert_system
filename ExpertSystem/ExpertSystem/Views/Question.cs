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
    public partial class Question : Form
    {
        private int questionId;
        private int topicId;
        List<QuestionModel> QuestionsList;//Общий список вопросов
        List<AnswerModel> AnswersList;//Общий список ответов
        QuestionModel currentQuestion;//Вопрос
        List<AnswerModel> CurrentAnswersList;//Ответы
        int totalErrors;
        public Question(List<QuestionModel> questions,List<AnswerModel> answers, int currentsQuestionId, int totalErrors)
        {
            InitializeComponent();
            this.QuestionsList = questions;
            this.AnswersList = answers;
            this.questionId = currentsQuestionId;
            PrepareFieldsData();
            this.totalErrors = totalErrors;
        }

        private void PrepareFieldsData()
        {
            currentQuestion = QuestionsList.Where(o => o.id == questionId).First();
            QuestionTextBox.Text = currentQuestion.question;
            List<string> AnswerIds = new List<string>();
            AnswerIds = currentQuestion.answersIds.Split().ToList();
            CurrentAnswersList = new List<AnswerModel>();
            CurrentAnswersList = AnswersList.Where(o => AnswerIds.Contains(o.id.ToString())).ToList();
            checkBox1.Text = CurrentAnswersList[0].Value;
            checkBox2.Text = CurrentAnswersList[1].Value;
            checkBox3.Text = CurrentAnswersList[2].Value;
            checkBox4.Text = CurrentAnswersList[3].Value;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true &&(checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true))
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

            if (checkBox1.Checked == true)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && (checkBox1.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true))
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

            if (checkBox2.Checked == true)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox4.Checked == true))
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
            }

            if (checkBox4.Checked == true)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int chosenVariant = 0;
            if (checkBox1.Checked == true)
            {
                chosenVariant = 0;
            }
            if (checkBox2.Checked == true)
            {
                chosenVariant = 1;
            }
            if (checkBox3.Checked == true)
            {
                chosenVariant = 2;
            }
            if (checkBox4.Checked == true)
            {
                chosenVariant = 3;
            }

            if(CurrentAnswersList[chosenVariant].id!= currentQuestion.correctAnswerId)
            {
                totalErrors++;
                string message = "Правильные ответ: " + CurrentAnswersList.Where(o=> o.id==currentQuestion.correctAnswerId).First().Value;
                string caption = "Неверный ответ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);
            }


            this.Hide();
            if (questionId < QuestionsList.Count - 1)
            {
                Question nextPage = new Question(QuestionsList, AnswersList, questionId + 1, totalErrors);
                nextPage.Show();
            }
            else
            {
                Result finalPage = new Result(totalErrors,QuestionsList.Count);
                finalPage.Show();
            }


        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
