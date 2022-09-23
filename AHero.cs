using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    abstract class/*interface*/ /*I*/AHero
    {
        private string _name;
        private int _lifeLengthYears;

        public AHero(string name, int lifeLengthYears)
        {
            _name = name;
            _lifeLengthYears = lifeLengthYears;
        }

        public string Name { get { return this._name; } /*set;*/ }

        public int LifeLengthYears { get { return this._lifeLengthYears; } set { this._lifeLengthYears = value; } }

        public abstract void UseSuperPower();
    }
}
