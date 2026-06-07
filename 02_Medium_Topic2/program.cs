namespace _02_Medium_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Input number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                //num * i;
                Console.WriteLine($"{num} x {i} = {num*i} ");
            }

        }
    }
}
