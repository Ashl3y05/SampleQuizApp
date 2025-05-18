namespace SampleQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question[] questions = new Question[]
           {
                new Question(
                    "What is the capital of Germany?",  // Question Text
                    new string[] {"Paris", "Berlin", "London", "Madrid"}, // Answers Array
                    1 // CorrectAnswerIndex
                ),
                new Question(
                    "What is 1+1?",  // Question Text
                    new string[] {"1", "2", "3", "4"}, // Answers Array
                    1 // CorrectAnswerIndex
                )
           };


            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
