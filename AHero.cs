using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{   
    public abstract class AHero
    {
        public delegate void AlertDelegate(string message);
        //private string _heroIdentity; //new 
        private AlertDelegate alertDelegate;
        private string _name;
        private int _lifeLengthYears;
        public bool healed;

        public AHero(string name, int lifeLengthYears, AlertDelegate alert)
        {
            this.alertDelegate += alert;
            this._name = name;
            //this._heroIdentity = name;   //new
            this._lifeLengthYears = lifeLengthYears;
            this.healed = false;
        }

        public string Name { get { return this._name; } /*set;*/ }

        public int LifeLengthYears { get { return this._lifeLengthYears; } set { this._lifeLengthYears = value; } }

        public abstract void UseSuperPower();

        public virtual bool HealMe()
        {
            this.healed = true;
            return this.healed;
        }

        public virtual void AlertMessage(string message)
        {
            if (alertDelegate != null)
            {
                alertDelegate(message);
            }
        }
    }
}
