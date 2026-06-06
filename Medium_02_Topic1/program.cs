namespace Medium_02_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0.0;
            Console.Write("Add Cash 1 amount:");
            double deposit1 = Convert.ToDouble(Console.ReadLine());
            balance += deposit1;
            Console.WriteLine($"-> Deposit succesful..Current Balance:{balance}");
            
            Console.Write("Add Cash 2 amount:");
            double deposit2 = Convert.ToDouble(Console.ReadLine());
            balance += deposit2;
            Console.WriteLine($"-> Deposit succesful..Current Balance:{balance}");

            Console.Write("Add Cash 3 amount:");
            double deposit3 = Convert.ToDouble(Console.ReadLine());
            balance += deposit3;
            Console.WriteLine($"-> Deposit succesful..Current Balance:{balance}");
        }
    }
}
