namespace _03_Medium_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                {
                    if (i == 5)
                        continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
