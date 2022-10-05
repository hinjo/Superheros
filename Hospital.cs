using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTest
{
    /*internal*/public class Hospital
    {
        private bool open = true;

        public Hospital()
        {

        }

        public bool Open
        {
            get
            {
                return open;
            }
            set
            {
                open = value;
            }
        }


       
    }
}
