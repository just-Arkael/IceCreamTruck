using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamTruck
{
    internal class IceCreamTruck
    {
        Random rand = new Random();
        IceCream[] inventory = new IceCream[5];
        int[] invAmount = new int[5];
        double[] prices = new double[5];

        double PriceInitialyser()
        {
            double result = rand.Next(10);
            result /= 10;
            result += rand.Next(20) + 10;
            return result;
        }

        public IceCreamTruck()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                {
                    inventory[i] = new IceCream();
                }
                else
                {
                    inventory[i] = new IceCream("Vanilla");
                }
                invAmount[i] = rand.Next(5);
                prices[i] = PriceInitialyser();
            }
        }

        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t \t MENU:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < inventory.Length; i++)
            {
                this.FlovourColour(inventory[i].Flavour);
                Console.Write(inventory[i].Flavour);
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < 11 - inventory[i].Flavour.Length; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("- ");
                Console.WriteLine(prices[i]);
            }
            Console.WriteLine();
        }

        void FlovourColour(string flavour)
        {
            switch (flavour)
            {
                case "Vanilla":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Strawberry":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Chocolate":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Pistachio":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Blueberry":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Mint":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Cherry":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "Mango":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Lavender":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Lemon":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Coffee":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }



        }

        public string BuyIceCream(string flavour, ref Player player)
        {
            string result = "null";
            int choice = 0;
            flavour = flavour.ToUpper();
            for (int i = 0; i < 5 || i < 5 && choice > 0 && invAmount[choice - 1] == 0; i++)
            {
                if (inventory[i].Flavour.ToUpper() == flavour && choice == 0 || choice > 0 && invAmount[choice - 1] == 0 && inventory[i].Flavour.ToUpper() == flavour)
                {
                    choice = i + 1;
                }
            }

            if (choice == 0)
            {
                Console.WriteLine("Sorry, I couldn't hear you quite right. Which flavour was that?");
            }
            else if (player.Money >= prices[choice - 1] && invAmount[choice - 1] > 0)
            {
                invAmount[choice - 1]--;
                result = inventory[choice - 1].Flavour;
                Console.WriteLine("There you go! One {0} icecream for you! It'll be {1}.", inventory[choice - 1].Flavour, prices[choice - 1]);
                player.Happiness += inventory[choice - 1].Quality;
                player.Money -= prices[choice - 1];
            }
            else if (invAmount[choice - 1] > 0)
            {
                Console.WriteLine("Sorry, kiddo, I can't do that one. You're {0} short.", prices[choice - 1] - player.Money);
            }
            else
            {
                Console.WriteLine("Sorry, kiddo, I can't do that one. I'm afraid we're out of stock!");
            }

            return result;
        }


    }
}
