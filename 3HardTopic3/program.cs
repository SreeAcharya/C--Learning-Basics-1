namespace _02_Hard_Topic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double colaPrice = 2.00;   //3 Items left
            const double chipsPrice = 1.50;  //2
            const double candyPrice = 1.00;  //5
            double userBalance = 5.00;

            int colaStock = 3;
            int chipsStock = 2;
            int candyStock = 5;
            while (true)
            {
                Console.WriteLine($"Current Balance: {userBalance:F2}");
                Console.WriteLine($"Stock left...Cola:{colaStock}, Chips:{chipsStock}, Candy:{candyStock}");

                Console.Write("Choose a Product:'1' for Cola, '2' for Chips, '3' for Candy:");
                int userInputNumber = Convert.ToInt32(Console.ReadLine());

                if (userInputNumber == 0)
                {
                    Console.WriteLine($"Thank you...Returning your change{userBalance}");
                    break;
                }
                Console.Write("Choose Qty:");
                int qty = Convert.ToInt32(Console.ReadLine());

                switch (userInputNumber)
                {
                    case 1:
                        //TO check if req. Qty is available in stock
                        if (qty <= colaStock)
                        {
                            //Calculate total transaction price
                            double totalCost = colaPrice * qty;
                            //Verify if user has enough money
                            if (userBalance >= totalCost)
                            {
                                Console.WriteLine($"{qty} Qty Cola is processing.......");
                                colaStock -= qty;
                                userBalance -= totalCost;
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient Balance. You need: {totalCost}, but you only have: {userBalance}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Cola outta stock.. Only {colaStock} left");
                        }
                        break;

                    case 2: //For chips
                        if (qty <= chipsStock)
                        {
                            double totalCost = chipsPrice * qty;
                            if (userBalance >= totalCost)
                            {
                                Console.WriteLine($"{qty} Qty of Chips is processing.....");
                                chipsStock -= qty;
                                userBalance -= totalCost;
                            }
                            else
                            {
                                Console.WriteLine($"Insufficient Balance. U need: {totalCost}, but u only have: {userBalance}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Cola outta stock.. Only {colaStock} left");
                        }
                        break;
                    case 3:
                        if (qty <= candyStock)
                        {
                            double totalCost = qty * CandyPrice;
                            if (userBalance >= totalCost)
                            {
                                Console.WriteLine($"{qty} Candy processing.......");
                                candyStock -= qty;
                                userBalance -= totalCost;
                            }
                            else
                            {
                                Console.WriteLine("Error: Insufficient balance!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Candy out of stock! Only {candyStock} left.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;
                }
            }
            }

                }
            }
     
