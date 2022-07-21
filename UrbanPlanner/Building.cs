using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    internal class Building
    {
        private string _designer = "Wes Westmoreland";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public Building(string address)
        {
            _address = address;
        }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume => Width * Depth * (3 * Stories);

        //public int GetStories() { return Stories; }
        //public void SetStories(int num) { Stories = num; }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }

        public void printInfo()
        {
            Console.WriteLine($@"
{_address}-------------------
Designed by {_designer}
Constructed on {_dateConstructed}
Own by {_owner}
{Volume} cubic meters of space");
        }
    }
}
