namespace SampleQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is 1+1? ");
            Console.WriteLine("1: 1\n2: 2\n3: 3\n4: 4");
            int userAnswer = int.Parse(Console.ReadLine());

            Question question1 = new Question("what is 1+1?", [ "1", "2", "3", "4" ], 1);

            if (question1.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine($"Wrong! The Correct answer is: {question1.Answers[question1.CorrectAnswerIndex]}");
            }
            Console.ReadKey();
        }
    }
}
