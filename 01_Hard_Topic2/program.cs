namespace _01_Hard_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.Write("Enter no1:");
                int no1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter no2:");
                int no2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the String operator:");
                string operatorr = Console.ReadLine();

                if (operatorr.ToUpper() == "EXIT") 
                {
                    break;
                }
                switch (operatorr)
                {
                    case "+":
                        int result;
                        Console.WriteLine($"addition of {no1} and {no2} is {result = no1 +no2}");
                        break;
                    case "*":
                        Console.WriteLine($"Multiplication of {no1} and {no2} is {result = no1 * no2}");
                        break;
                    case "-":
                        Console.WriteLine($"Subtraction of {no1} and {no2} is {result = no1 - no2}");
                        break;
                    case "/":
                        Console.WriteLine($"Divition of {no1} and {no2} is {result = no1 / no2}");
                        break;
                    default:
                        Console.WriteLine("Error: Invalid symbol");
                        break;
                }

            }
        }
    }
}
