using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamTruck
{
    internal class IceCream
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
