using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamTruck
{
    internal class Program
    {
        static void NextDialogue() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t ->");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            IceCreamTruck truck1 = new IceCreamTruck();
            Random rand = new Random();
            double money = rand.Next(10);
            money /= 10;
            money += rand.Next(100) + 150;
            double happiness = 10;
            string favflavour = "Vanilla";
            string choice;
            string flavour;
            byte currenttruck = 0;

            switch (rand.Next(10))
            {
                case 0:
                    favflavour = "Strawberry";
                    break;
                case 1:
                    favflavour = "Chocolate";
                    break;
                case 2:
                    favflavour = "Pistachio";
                    break;
                case 3:
                    favflavour = "Blueberry";
                    break;
                case 4:
                    favflavour = "Mint";
                    break;
                case 5:
                    favflavour = "Cherry";
                    break;
                case 6:
                    favflavour = "Mango";
                    break;
                case 7:
                    favflavour = "Lavender";
                    break;
                case 8:
                    favflavour = "Lemon";
                    break;
                case 9:
                    favflavour = "Coffee";
                    break;
            }
            int lastdays = rand.Next(20);
            Console.WriteLine("You really want some icecream.");
            NextDialogue();
            Console.WriteLine("You REALLY want some icecream.");
            NextDialogue();
            Console.WriteLine("It's been...");
            NextDialogue();
            Console.WriteLine("It's been {0} days since the last time you ate icecream...", lastdays);
            NextDialogue();
            Console.WriteLine("{0} days?!", lastdays);
            NextDialogue();
            Console.WriteLine("You have to get some icecream!");
            NextDialogue();
            Console.WriteLine("You don't want to imagine going a single more day without icecream!");
            NextDialogue();
            Console.WriteLine("There are 5 icecream trucks in the town.");
            NextDialogue();
            Console.WriteLine("You have saved up {0} cash, that should be enough to get some!", money);
            NextDialogue();
            Console.WriteLine("Go out there and get yourself some icecream!");
            NextDialogue();
            Console.WriteLine("Remember, your favourite flavour is {0}.", favflavour);
            NextDialogue();
            Console.WriteLine("Now, go get that icecream!");
            NextDialogue();
            Console.WriteLine("...");
            NextDialogue();
            Console.WriteLine("Here comes the first truck.");
            NextDialogue();
            Console.WriteLine("When you're done, type ''None'' or ''Next'' to move on to the next truck!");


        Reset:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t \t Happiness meter:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*--------------------------------------------------*");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            if (happiness >= 200) { Console.ForegroundColor = ConsoleColor.Magenta; }
            if (happiness >= 400) { Console.ForegroundColor = ConsoleColor.DarkYellow; }
            if (happiness >= 600) { Console.ForegroundColor = ConsoleColor.Yellow; }
            if (happiness >= 800) { Console.ForegroundColor = ConsoleColor.Green; }
            if (happiness >= 1000) { Console.ForegroundColor = ConsoleColor.Blue; }
            for (int i = 0; i < 50; i++)
            {
                if (happiness / 20 >= i)
                {
                    Console.Write("=");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("*--------------------------------------------------*");
            Console.WriteLine("My cash: {0}", money);
            Console.WriteLine();
            truck1.ShowMenu();
            Console.WriteLine("Which one do I buy?");
            choice = Console.ReadLine();
            if (choice != "None")
            {
                flavour = truck1.BuyIceCream(choice, ref money, ref happiness);
                if (flavour == favflavour)
                {
                    happiness += 15;
                }
                NextDialogue();
                goto Reset;
            }
            else
            {
                currenttruck++;
                if (currenttruck < 5)
                {
                    Console.Clear();
                    Console.WriteLine("There's more ice cream trucks in the town.");
                    NextDialogue();
                    Console.WriteLine("You can still get some more icecream!");
                    NextDialogue();
                    Console.WriteLine("You have {0} cash left...", money);
                    NextDialogue();
                    Console.WriteLine("...");
                    NextDialogue();
                    Console.WriteLine("Here's the next truck!");
                    NextDialogue();

                }
                else
                {
                    Console.WriteLine("After a long day of looking for icecream...");
                    NextDialogue();
                    Console.WriteLine("You return home!");
                    NextDialogue();
                    if (happiness < 200)
                    {
                        Console.WriteLine("Unfortunatelly, you didn't get much...");
                        NextDialogue();
                        Console.WriteLine("Maybe tomorrow will be a better day!");
                        NextDialogue();
                    }
                    if (happiness >= 200 && happiness < 400)
                    {
                        Console.WriteLine("You couldn't get much icecream today.");
                        NextDialogue();
                        Console.WriteLine("But some is better than none!");
                        NextDialogue();
                        Console.WriteLine("You could buy some more tomorrow!");
                        NextDialogue();
                    }
                    if (happiness >= 400 && happiness < 600)
                    {
                        Console.WriteLine("Today was awesome!");
                        NextDialogue();
                        Console.WriteLine("You got some icecream and it made your day!");
                        NextDialogue();
                        Console.WriteLine("You can't wait to hopefully get some more tomorrow.");
                        NextDialogue();
                    }
                    if (happiness >= 600 && happiness < 800)
                    {
                        Console.WriteLine("What a perfect day today was!");
                        NextDialogue();
                        Console.WriteLine("You bought plenty of icecream! It was sooooo good!");
                        NextDialogue();
                        Console.WriteLine("This memory should last for weeks!");
                        NextDialogue();
                    }
                    if (happiness >= 800 && happiness < 1000)
                    {
                        Console.WriteLine("You lay down and can't help but smile from ear to ear!");
                        NextDialogue();
                        Console.WriteLine("You got so much icecream today!");
                        NextDialogue();
                        Console.WriteLine("You should do this more often.");
                        NextDialogue();
                        Console.WriteLine("What a perfect day!");
                        NextDialogue();
                    }
                    if (happiness >= 1000)
                    {
                        Console.WriteLine("Today was PERFECT!");
                        NextDialogue();
                        Console.WriteLine("You ate soooo much icecream!");
                        NextDialogue();
                        Console.WriteLine("Your happiness is through the roof!");
                        NextDialogue();
                        Console.WriteLine("Today was the best day of your entire life!");
                        NextDialogue();
                    }


                }
                
            }


        }


        class IceCreamTruck
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
                    Console.ForegroundColor= ConsoleColor.White;
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
                        Console.ForegroundColor= ConsoleColor.White;
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

            public string BuyIceCream(string flavour, ref double money, ref double happiness)
            {
                string result = "null";
                int choice = 0;
                for (int i = 0; i < 5 && choice == 0; i++)
                {
                    if (inventory[i].Flavour == flavour)
                    {
                        choice = i + 1;
                    }   
                }

                if (choice == 0)
                {
                    Console.WriteLine("Sorry, I couldn't hear you quite right. Which flavour was that?");
                }
                else if (money >= prices[choice-1] && invAmount[choice-1] > 0)
                {
                    invAmount[choice-1]--;
                    result = inventory[choice - 1].Flavour;
                    Console.WriteLine("There you go! One {0} icecream for you! It'll be {1}.", inventory[choice-1].Flavour, prices[choice-1]);
                    happiness += inventory[choice - 1].Quality;
                    money -= prices[choice - 1];
                } else if (invAmount[choice - 1] > 0)
                {
                    Console.WriteLine("Sorry, kiddo, I can't do that one. You're {0} short.", prices[choice-1] - money);
                }
                else
                {
                    Console.WriteLine("Sorry, kiddo, I can't do that one. I'm afraid we're out of stock!");
                }

                return result;
            }


        }


        class IceCream
        {
            string flavour;
            int quality;
            static Random rand = new Random();


            public IceCream()
            {
                quality = rand.Next(9);

                switch (quality)
                {
                    case 0:
                        flavour = "Strawberry";
                        break;
                    case 1:
                        flavour = "Chocolate";
                        break;
                    case 2:
                        flavour = "Pistachio";
                        break;
                    case 3:
                        flavour = "Blueberry";
                        break;
                    case 4:
                        flavour = "Mint";
                        break;
                    case 5:
                        flavour = "Cherry";
                        break;
                    case 6:
                        flavour = "Mango";
                        break;
                    case 7:
                        flavour = "Lavender";
                        break;
                    case 8:
                        flavour = "Lemon";
                        break;
                    case 9:
                        flavour = "Coffee";
                        break;
                }
                quality = 50 + rand.Next(50);
            }

            public IceCream(string flavor)
            {
                flavour = flavor;
                quality = 60 + rand.Next(40);
            }

            public string Flavour
            {
                get { return flavour; }
            }

            public int Quality
            {
                get { return quality + rand.Next(10) - rand.Next(10); }
            }

        }

    }
}
