using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    internal class SupermanI : IHero
    {
        private string _name;
        private int _lifeLengthYears;
        private int _flightHeight = 3000;

        public SupermanI(string name, int lifeLengthYears, int flightHeight)
        {
            _flightHeight = flightHeight;
            //Name = name;
            this._name = name;
            ////this._name = name;
            LifeLengthYears = _lifeLengthYears;
        }

        public string Name  { get { return this._name; } set { this._name = value; } }

        public int LifeLengthYears { get { return this._lifeLengthYears; } set { this._lifeLengthYears = value; } }

        public int FlightHeight{ get { return this._flightHeight; } }
                
        public void UseSuperPower()
        {
            Console.WriteLine("Flying");
        }
    }
}
