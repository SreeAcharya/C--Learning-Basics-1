namespace Medium_03_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your age:");
            int age = Convert.ToInt16(Console.ReadLine());

            const int drivingAge = 16;
            bool canDrive = age >= drivingAge;
            
            const int votingAge = 21;
            bool canVote = age >= votingAge;

            const int seniorAge = 65;
            bool isSenior = age >= seniorAge;

            Console.WriteLine($"At your current {age}, You can legally drive?? {canDrive}");
            Console.WriteLine($"At your current {age}, You can legally vote? {canVote}");
            Console.WriteLine($"At your current {age}, You can be senor?? {isSenior}");

        }
    }
}
