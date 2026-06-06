namespace _02_RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("\nArea: " + area);
            int perimeter = 2 * (length*width);
            Console.WriteLine("Perimter:" + perimeter);
        }
    }
}
