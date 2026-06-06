namespace _03_year_of_birth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int currentYear = 2026;
            Console.Write("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = currentYear - age;
            Console.WriteLine("Your year of birth:" + birthYear);
        }
    }
}
