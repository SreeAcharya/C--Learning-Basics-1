namespace _01_Medium_topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPin = "1234";
            Console.Write("Enter PIN:");
            string userGuess = Console.ReadLine();
            while (userGuess != correctPin)
            {
                Console.WriteLine("Wrong Guess.");
                Console.Write("Pls Re-Enter");
                userGuess = Console.ReadLine();
            }
            Console.WriteLine("Correct. You've Entered correct value");
        }
    }
}
