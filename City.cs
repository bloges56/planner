using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        //fields
        private string _name;
        private string _mayor;
        private List<Building> _buildings = new List<Building>();
        private int _yearEstablished;

        public City(string name, string mayor, List<Building> buildings)
        {
            _name = name;
            _mayor = mayor;
            _buildings = buildings;
            _yearEstablished = DateTime.Now.Year;
        }

        public void AddBuilding(Building building)
        {
            _buildings.Add(building);
        }

        public void printCity()
        {
            Console.WriteLine($"Mayor {_mayor} welcomes you to {_name}. Est. {_yearEstablished}");
            Console.WriteLine("Our Buildings:");
            foreach(Building building in _buildings){
                building.printBuilding();
            }
        }
    }
}