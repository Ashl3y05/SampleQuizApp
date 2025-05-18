using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuizApp
{
    class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz() {
            Console.WriteLine("Welcome to the Quiz by Ashley P.!");
            int questionNumber = 1;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question number {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct Answer!");
                }
                else {
                    Console.Write("Wrong Answer! The correct answer was: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(question.CorrectAnswerIndex);
                    Console.ResetColor();
                    Console.Write($". {question.Answers[question.CorrectAnswerIndex]}\n");
                }

            }
        }

        private void DisplayQuestion(Question question)
        {

            Console.WriteLine(question.QuestionText);
            
            for (int i = 0; i<question.Answers.Length;i++) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
                
            }

        }

        public int GetUserChoice() {
            Console.WriteLine("Your answer: ");
            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4) {
                Console.WriteLine("Invalid input! Please enter a proper answer.");
                input = Console.ReadLine();
            }

            return choice - 1;
        }
    }
}
