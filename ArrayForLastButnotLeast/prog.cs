namespace ArrayFor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { 21, 18, 26, 31, 22, 15, 29 };
            foreach (int i in temp)
            {
                if (i > 25)
                {
                    Console.WriteLine($"{i}°C - Warning: Too Hot!");
                }
                else if (i < 17)
                {
                    Console.WriteLine($"{i}°C - Warning: Too Cold!");
                }
                else 
                {
                    Console.WriteLine($"{i} is normal");
                }
            }
        }
    }
}
