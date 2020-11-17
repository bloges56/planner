using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Brady Logan";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        {
            get
            {
                return Width * Depth * ( 3 * Stories );
            }
        }

        //method that prints out all the information of a building to the console
        public void printBuilding()
        {
            Console.WriteLine();
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
    }
}