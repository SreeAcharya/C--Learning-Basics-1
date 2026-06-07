namespace ArrayFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] amount = { 12.50, 45.00, 9.99, 120.75, 23.50 };
            double totalSales = 0;
            foreach (double sale in amount)
            {
                totalSales += sale;
            }
            Console.WriteLine(totalSales);

        }
    }
}
