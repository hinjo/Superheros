using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    /// <summary>
    /// IHero interface replaced by AHero abstract class
    /// </summary>
    interface IHero
    {
        //private string _name;
        //private int _lifeLengthYears;

        //public IHero(string name, int lifeLengthYears)
        //{
        //    _name = name;
        //    _lifeLengthYears = lifeLengthYears;
        //}

        public string Name { get; set; }

        public int LifeLengthYears { get; set; }

        public void UseSuperPower();
    }
}
