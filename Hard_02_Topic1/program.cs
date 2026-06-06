namespace Hard_02_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total amount:");
            int totalAmount = Convert.ToInt16(Console.ReadLine());
            int twentyDollar = totalAmount / 20;
            Console.WriteLine($"There are {twentyDollar} nos of 20s");
            int oneDollar = totalAmount % 50;
            Console.WriteLine($"There are {oneDollar} nos of 1s");
        }
    }
}
