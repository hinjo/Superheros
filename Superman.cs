using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    internal class Superman : AHero
    {
        //private string _name;
        //private int lifeLengthYears;
        private int _flightHeight = 3000;

        public Superman(string name, int lifeLengthYears, int flightHeight, AlertDelegate alertDelegate) : base(name, lifeLengthYears, alertDelegate)
        {
            _flightHeight = flightHeight;
            //Name = name;
            ////_name = name;
            ////this._name = name;
            //LifeLengthYears = lifeLengthYears;
        }

        //public new string Name  { get; set; }

        //public int LifeLengthYears
        //{
        //    get;
        //    set;
        //}

        public int FlightHeight{ get { return this._flightHeight; } }


        public override void UseSuperPower()
        {
            Console.WriteLine("bla");
        }
    }
}
