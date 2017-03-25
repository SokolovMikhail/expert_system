using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class QuestionModel
    {
        public int id;
        public string question;
        List<string> answers;
        public string answersIds;
        public int correctAnswerId;
    }
}
