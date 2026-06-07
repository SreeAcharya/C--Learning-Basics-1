namespace forArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Box", "Barrel", "Box", "Crate", "Barrel", "Box" };
            int boxCount = 0; 
            int barrelCount = 0; 
            int crateCount = 0;
            foreach (string i in items)
            {
                switch (i)
                {
                    case "Box":
                        { 
                            boxCount++;
                        }
                        break;

                    case "Barrel":
                        {
                            barrelCount++;
                        }
                        break;
                    case "Crate":
                        {
                            crateCount++;
                        }
                        break;
                }
            }
            Console.WriteLine("--- Inventory Summary ---");
            Console.WriteLine($"Boxes:   {boxCount}");
            Console.WriteLine($"Barrels: {barrelCount}");
            Console.WriteLine($"Crates:  {crateCount}");
        }
    }
}
