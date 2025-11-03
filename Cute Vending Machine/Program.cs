using System;

namespace Cute_Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double itemPrice = 1.50;
            double totalInserted = 0.0;

            string[] menuRowA =
            {
                "A1: [candy item]",
                "A2: [candy item]",
                "A3: [candy item]",
                "A4: [candy item]",
                "A5: [candy item]"
            };

            string[] menuRowB =
                {
                "B1: [chocolate item]",
                "B2: [chocolate item]",
                "B3: [chocolate item]",
                "B4: [chocolate item]",
                "B5: [chocolate item]"
            };

            string[] menuRowC =
                {
                "C1: [cookie item]",
                "C2: [cookie item]",
                "C3: [cookie item]",
                "C4: [cookie item]",
                "C5: [cookie item]"
            };

            string[] menuRowD =
                {
                "D1: [chips item]",
                "D2: [chips item]",
                "D3: [chips item]",
                "D4: [chips item]",
                "D5: [chips item]"
            };

            string[] menuRowE =
                {
                "E1: [drink item]",
                "E2: [drink item]",
                "E3: [drink item]",
                "E4: [drink item]",
                "E5: [drink item]"
            };

            Console.WriteLine("Welcome to the Vending Machine! Everything here costs $1.50!");
            Console.Write("Would you like to look at the menu? (yes/no): ");
            string userResponseOne = Console.ReadLine().ToLower();
            if (userResponseOne == "yes")
                Console.WriteLine("Alright! Row A has candy, row B has chocolate, row C has cookies, row D has chips, and row E has drinks.");

            while (true)
                if (userResponseOne == "yes")
                {
                    Console.Write("Which row would you like to view? (A, B, C, D, E): ");
                    string userRowInputOne = Console.ReadLine().ToUpper();
                    switch (userRowInputOne)
                    {
                        case "A":
                            foreach (string item in menuRowA)
                                Console.WriteLine(item);
                            Console.Write("Would you like to view another row? (yes/no): ");
                            string userAnotherRowA = Console.ReadLine().ToLower();
                            if (userAnotherRowA == "yes")
                                continue;
                            else if (userAnotherRowA == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid response. Proceeding to item selection.");
                                break;
                            }
                        case "B":
                            foreach (string item in menuRowB)
                                Console.WriteLine(item);
                            break;
                        case "C":
                            foreach (string item in menuRowC)
                                Console.WriteLine(item);
                            break;
                        case "D":
                            foreach (string item in menuRowD)
                                Console.WriteLine(item);
                            break;
                        case "E":
                            foreach (string item in menuRowE)
                                Console.WriteLine(item);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid row.");
                            continue;
                    }
                    Console.Write("\nPlease make your selection: ");
                    break;
                }
                else if (userResponseOne == "no")
                {
                    Console.Write("Got it! Please make your selection: ");
                    break;
                }
                else
                {
                    Console.Write("Invalid response. Please enter either yes or no: ");
                    continue;
                }

            string userSelection = Console.ReadLine().ToUpper();

            Console.WriteLine("Please insert Canadian coins. Pennies will not be accepted.");
            while (totalInserted < itemPrice)
            {
                Console.Write("Insert a coin (nickel, dime, quarter, loonie, toonie): ");
                string coin = Console.ReadLine().ToLower();
                switch (coin)
                {
                    case "nickel":
                        totalInserted += 0.05;
                        break;
                    case "dime":
                        totalInserted += 0.10;
                        break;
                    case "quarter":
                        totalInserted += 0.25;
                        break;
                    case "loonie":
                        totalInserted += 1.00;
                        break;
                    case "toonie":
                        totalInserted += 2.00;
                        break;
                    default:
                        Console.WriteLine("Invalid coin. Please try again.");
                        continue;
                }
                Console.WriteLine($"Total inserted: ${totalInserted:F2}");
                if (totalInserted >= itemPrice)
                {
                    Console.WriteLine("Thank you! Dispensing your item...");
                    double change = totalInserted - itemPrice;
                    if (change > 0)
                    {
                        Console.WriteLine($"Please take your change: ${change:F2}");
                    }
                    break;
                }
            }
            Console.WriteLine("Enjoy your purchase and have a wonderful day!");
        }
    }
}