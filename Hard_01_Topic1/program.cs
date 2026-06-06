namespace Hard_01_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter attendance percentage:");
            double attPer = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter assignment score:");
            int assSco = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter final exam score: ");
            int finSco = Convert.ToInt32(Console.ReadLine());

            bool hasPassed = (attPer > 75.00 && assSco > 50) || (finSco == 100);
            Console.WriteLine($"Have you passed? { hasPassed}");
        }
    }
}
