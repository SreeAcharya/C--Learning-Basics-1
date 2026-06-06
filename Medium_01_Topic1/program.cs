namespace Medium_01_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cost with rupee and paisa:");
            //Read the text string and convert it into double
            double originalPrice = Convert.ToDouble(Console.ReadLine());
            int wholeNumberedPrice = (int)originalPrice;
            double choppedoffPrice = originalPrice - wholeNumberedPrice;
            Console.WriteLine($"Remaining paisa: {choppedoffPrice:F2}");

        }
    }
}
