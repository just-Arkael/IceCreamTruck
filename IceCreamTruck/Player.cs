using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamTruck
{
    internal class Player
    {
        Random rand = new Random();
        double money;
        double happiness = 10;
        string favflavour = "Vanilla";

        public Player()
        {
            money = rand.Next(10);
            money /= 10;
            money += rand.Next(100) + 100;
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

        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }
        public double Happiness
        {
            get { return happiness; }
            set { happiness = value; }
        }
        public string FavFlavour
        {
            get { return favflavour; }
        }

        public void ShowStats()
        {
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

        }



    }
}
