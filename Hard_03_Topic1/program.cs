using System;

namespace Hard_03_Topic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter current tank's temperature (°C): ");
            double temp = Convert.ToDouble(Console.ReadLine());
            
            // Fixed: Changed to strict less-than and greater-than thresholds
            bool isDangerous = (temp < 10.5) || (temp > 85.2);
            
            // Fixed: Text matches the boolean meaning perfectly
            Console.WriteLine($"Is the tank in Danger? {isDangerous}");
            
            // Alternate option (if you want to print "Safe to Operate"):
            // Console.WriteLine($"Safe to Operate? {!isDangerous}"); 
        }
    }
}
