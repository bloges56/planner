using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //construct building objects
            Building Peabody = new Building("73 Kingston Avenue");
            Building Beach = new Building("75 State Drive");
            Building Hopkin = new Building ("8936 Ivy Street");
            Building Northport = new Building("7 Nicholls Street");

            //set width, depth, and stories
            //call construct on each building
            //sell each building
            Peabody.Width = 75.2;
            Peabody.Depth = 100.8;
            Peabody.Stories = 3;
            Peabody.Construct();
            Peabody.Purchase("Aaran Maddox");

            Beach.Width = 29.6;
            Beach.Depth = 378.6;
            Beach.Stories = 7;
            Beach.Construct();
            Beach.Purchase("Tianna Dudley");

            Hopkin.Width = 94.6;
            Hopkin.Depth = 684.7;
            Hopkin.Stories = 6;
            Hopkin.Construct();
            Hopkin.Purchase("Niam Fisher");

            Northport.Width = 569.8;
            Northport.Depth = 294.6;
            Northport.Stories = 8;
            Northport.Construct();
            Northport.Purchase("Louise Fox");

            //create a list of the buildings
            List<Building> buildings = new List<Building>()
            {
                Northport, Hopkin, Beach, Peabody
            };

            //create a new city
            City myCity = new City("Bradyopolis", "Solomon Paine", buildings);

            //log the city
            myCity.printCity();
        }
    }
}
