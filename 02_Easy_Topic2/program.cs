namespace _02_Easy_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a no from 1-7 representing a week day");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("WEdnesday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friyay");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

            }
        }
    }
}
