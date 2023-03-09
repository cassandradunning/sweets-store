using System;
using System.Collections.Generic;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Step 1:
                    Create at least one instance of each kind of candy
             */
            CandyBar snickers = new CandyBar()
            {
                Name = "Snickers",
            };

            Gumball gumball = new Gumball()
            {
                Name = "Gumball",
            };

            Gummy scooby = new Gummy()
            {
                Name = "Scooby Snacks",
            };

            Licorice licorice = new Licorice()
            {
                Name = "Licorice",
            };
            Lollipop lolli = new Lollipop()
            {
                Name = "Lollipop",
            };
            Sours sour = new Sours()
            {
                Name = "Sour Candy",
            };
            Taffy laffy = new Taffy()
            {
                Name = "Lafy Taffy",
            };

            /*
                Step 2:
                    Create at least one instance of each kind of baked good
             */

            Pie rhubarbPie = new Pie()
            {
                Name = "Rhubarb Pie",
            };

            /*
            This runs first. Then it runs Pie rhubarbPie
                = new Pie()
                {
                    Name = "Rhubarb Pie",
                };

            */
            Cake jelloCake = new Cake()
            {
                Name = "JelloCake"
            };
            Macaroon pistachioMacaroon = new Macaroon()
            {
                Name = "Pistachio Macaroon"
            };

            Cookie raisinCookie = new Cookie()
            {
                Name = "Raisin Cookie"
            };

            /*
                Step 3:
                    Create a List<> and add all baked goods to the list
             */
            Console.WriteLine();
            Console.WriteLine("Candy we keep stocked on the shelf:");
            Console.WriteLine();


            List<Candy> displayCandy = new List<Candy>()
            {
               snickers,
               gumball,
               scooby,
               sour,
               laffy,
               lolli,
               licorice
            };

            foreach (var candy in displayCandy)
            {
                Console.WriteLine(candy.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Here are the baked goods we have today:");
            Console.WriteLine();

            List<BakedGood> displayCase = new List<BakedGood>()
            {
                rhubarbPie,
                jelloCake,
                pistachioMacaroon,
                raisinCookie
            };

            foreach (var baked in displayCase)
            {
                Console.WriteLine(baked.Name);
            }

        }
    }
}
