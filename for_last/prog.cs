namespace for_MEdium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int count1 = 1; count1 <=3; count1++)
            {
                for (int count2 = 1; count2 <=5; count2++)
                {
                    if (count2 % 2 == 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
