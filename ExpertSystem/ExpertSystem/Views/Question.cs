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
        private int totalCount;
        List<QuestionModel> QuestionsList;//Общий список вопросов
        //List<AnswerModel> AnswersList;//Общий список ответов
        QuestionModel currentQuestion;//Вопрос
        List<AnswerModel> CurrentAnswersList;//Ответы
        int totalErrors;
        public Question(List<QuestionModel> questions, int totalErrors, int totalCount)
        {
            this.totalCount = totalCount;
            InitializeComponent();
            this.QuestionsList = questions;
            //this.AnswersList = answers;
            //this.questionId = currentsQuestionId;
            PrepareFieldsData();
            this.totalErrors = totalErrors;
        }

        private void PrepareFieldsData()
        {
            Random rnd = new Random();

            questionId = rnd.Next(0, QuestionsList.Count);
            //questionId = 2;//Заглушка
            currentQuestion = QuestionsList[questionId];
            QuestionTextBox.Text = currentQuestion.questionText;
            //Варианты ответа
            try
            {
                checkBox1.Text = currentQuestion.QuestionAnswers[0].Value;
            }
            catch
            {
                checkBox1.Visible = false;
            }
            try
            {
                checkBox2.Text = currentQuestion.QuestionAnswers[1].Value;
            }
            catch
            {
                checkBox2.Visible = false;
            }
            try
            {
                checkBox3.Text = currentQuestion.QuestionAnswers[2].Value;
            }
            catch
            {
                checkBox3.Visible = false;
            }
            try
            {
                checkBox4.Text = currentQuestion.QuestionAnswers[3].Value;
            }
            catch
            {
                checkBox4.Visible = false;
            }
            QuestionsList.RemoveAt(questionId);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        #region checkBoxLogic

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
        #endregion
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



            List<Fact> ResultFacts = Solution.Solve(currentQuestion);
            try
            {
                ResultFacts.Where(o => o.ID == currentQuestion.QuestionAnswers[chosenVariant].ID).First();
            }
            catch
            {
                totalErrors++;
                string message = "Правильный ответ:\n";// + ResultFacts.Where(o => o.);
                foreach(Fact fact in currentQuestion.QuestionAnswers)
                {
                    try
                    {
                        ResultFacts.Where(o => o.ID == fact.ID).First();
                        message += fact.Value + "\n";
                    }
                    catch
                    {
                        continue;//Поменять на break, если надо будет только один вариант ответа
                    }
                }
                string caption = "Неверный ответ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);
            }
            this.Hide();
            if (QuestionsList.Count > 0)
            {
                Question nextPage = new Question(QuestionsList, totalErrors, totalCount);
                nextPage.Show();
            }
            else
            {

                Result finalPage = new Result(totalErrors, totalCount);
                finalPage.Show();
            }


        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
