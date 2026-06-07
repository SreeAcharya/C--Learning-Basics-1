namespace Easy_01_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int no = Convert.ToInt16(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("Its even no");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
