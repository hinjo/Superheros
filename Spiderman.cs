using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArvTest
{
    internal class Spiderman : AHero
    {
        private int _flightHeight = 3000;
        //private Map 

        public Spiderman(string name, int lifeLengthYears, int flightHeight, AlertDelegate alertDelegate) : base(name, lifeLengthYears, alertDelegate)
        {
            Thread thread = new Thread(new ThreadStart(Loop));
            thread.Start();
            _flightHeight = flightHeight;
        }

        public int FlightHeight{ get { return this._flightHeight; } }

        public void Loop()
        {
            while(true)
            {
                Thread.Sleep(1000);
                Random rand = new Random();
                int a = rand.Next(0, 10);
                if(a > 6)
                {
                    base.AlertMessage("Spiderman has found a spider to eat");
                }
                else
                {
                    base.AlertMessage("No spider found");
                }

                //Console.WriteLine("");    //bad practice (aka code smell)
            }
        }
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
