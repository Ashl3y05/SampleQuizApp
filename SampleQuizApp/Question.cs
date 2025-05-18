using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuizApp
{
    class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswerIndex { get; set; }

        public Question(string question, string[] choices, int CorrectAnswer) {

            QuestionText = question;
            Answers = choices;
            CorrectAnswerIndex = CorrectAnswer;
        }

        public bool CheckAnswer(int userChoice) {
            userChoice -= 1;
            return CorrectAnswerIndex == userChoice;
        }
        
        
    }
}
