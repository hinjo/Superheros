using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    internal class Spiderman : AHero
    {
        private int _flightHeight = 3000;

        public Spiderman(string name, int lifeLengthYears, int flightHeight) : base(name, lifeLengthYears)
        {
            _flightHeight = flightHeight;
        }

        public int FlightHeight{ get { return this._flightHeight; } }


        public override void UseSuperPower()
        {
            Console.WriteLine("hiii");
        }

        public override bool HealMe()
        {
            //eat 5 spiders
            return false;
        }
    }
}
