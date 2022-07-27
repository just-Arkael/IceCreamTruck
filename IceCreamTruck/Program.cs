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
            IceCreamTruck truck2 = new IceCreamTruck();
            IceCreamTruck truck3 = new IceCreamTruck();
            IceCreamTruck truck4 = new IceCreamTruck();
            IceCreamTruck truck5 = new IceCreamTruck();
            IceCreamTruck[] trucks = new IceCreamTruck[] {truck1, truck2, truck3, truck4, truck5};
            string choice;
            string flavour;
            byte currenttruck = 0;
            Random rand = new Random();
            Player player = new Player();
            
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
            Console.WriteLine("You have saved up {0} cash, that should be enough to get some!", player.Money);
            NextDialogue();
            Console.WriteLine("Go out there and get yourself some icecream!");
            NextDialogue();
            Console.WriteLine("Remember, your favourite flavour is {0}.", player.FavFlavour);
            NextDialogue();
            Console.WriteLine("Now, go get that icecream!");
            NextDialogue();
            Console.WriteLine("...");
            NextDialogue();
            Console.WriteLine("Here comes the first truck.");
            NextDialogue();
            Console.WriteLine("When you're done, type ''None'' or ''Next'' to move on to the next truck!");


        Reset:
            player.ShowStats();
            trucks[currenttruck].ShowMenu();
            Console.WriteLine("Which one do you buy?");
            choice = Console.ReadLine();
            if (choice != "None" && choice != "Next" && choice != "none" && choice != "next")
            {
                Console.WriteLine("May I have one {0} icecream, please?", choice);
                flavour = trucks[currenttruck].BuyIceCream(choice, ref player);
                if (flavour == player.FavFlavour)
                {
                    player.Happiness += 25;
                }
                NextDialogue();
                goto Reset;
            }
            else
            {
                currenttruck++;
                if (currenttruck < 5)
                {
                    Console.WriteLine("You say goodbye to the icecream man and go your way.");
                    NextDialogue();
                    Console.WriteLine("There's more ice cream trucks in the town.");
                    NextDialogue();
                    Console.WriteLine("You can still get some more icecream!");
                    NextDialogue();
                    Console.WriteLine("You have {0} cash left...", player.Money);
                    NextDialogue();
                    Console.WriteLine("...");
                    NextDialogue();
                    Console.WriteLine("Here's the next truck!");
                    NextDialogue();
                    if (currenttruck == 2)
                    {
                        Console.WriteLine("Remember, your favourite flavour is {0}", player.FavFlavour);
                        NextDialogue();
                    }
                    goto Reset;
                }
                else
                {
                    Console.WriteLine("After a long day of looking for icecream...");
                    NextDialogue();
                    Console.WriteLine("You return home!");
                    NextDialogue();
                    if (player.Happiness < 200)
                    {
                        Console.WriteLine("Unfortunatelly, you didn't get much icecream today...");
                        NextDialogue();
                        Console.WriteLine("Maybe tomorrow will be a better day!");
                        Console.ReadKey();
                    }
                    if (player.Happiness >= 200 && player.Happiness < 400)
                    {
                        Console.WriteLine("You couldn't get much icecream today.");
                        NextDialogue();
                        Console.WriteLine("But some is better than none!");
                        NextDialogue();
                        Console.WriteLine("You could buy some more tomorrow!");
                        Console.ReadKey();
                    }
                    if (player.Happiness >= 400 && player.Happiness < 600)
                    {
                        Console.WriteLine("Today was awesome!");
                        NextDialogue();
                        Console.WriteLine("You got some icecream and it made your day!");
                        NextDialogue();
                        Console.WriteLine("You can't wait to hopefully get some more tomorrow.");
                        Console.ReadKey();
                    }
                    if (player.Happiness >= 600 && player.Happiness < 800)
                    {
                        Console.WriteLine("What a perfect day today was!");
                        NextDialogue();
                        Console.WriteLine("You bought plenty of icecream! It was sooooo good!");
                        NextDialogue();
                        Console.WriteLine("This memory should last for weeks!");
                        Console.ReadKey();
                    }
                    if (player.Happiness >= 800 && player.Happiness < 1000)
                    {
                        Console.WriteLine("You lay down and can't help but smile from ear to ear!");
                        NextDialogue();
                        Console.WriteLine("You got so much icecream today!");
                        NextDialogue();
                        Console.WriteLine("You should do this more often.");
                        NextDialogue();
                        Console.WriteLine("What a perfect day!");
                        Console.ReadKey();
                    }
                    if (player.Happiness >= 1000)
                    {
                        Console.WriteLine("Today was PERFECT!");
                        NextDialogue();
                        Console.WriteLine("You ate soooo much icecream!");
                        NextDialogue();
                        Console.WriteLine("Your happiness is through the roof!");
                        NextDialogue();
                        Console.WriteLine("Today was the best day of your entire life!");
                        Console.ReadKey();
                    }


                }
                
            }


        }


    }
}
