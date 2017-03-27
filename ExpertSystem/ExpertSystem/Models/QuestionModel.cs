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
        public string questionText;
        public List<Fact> QuestionFacts;
        public List<Fact> QuestionAnswers;
        public string answersIds;
    }
}
