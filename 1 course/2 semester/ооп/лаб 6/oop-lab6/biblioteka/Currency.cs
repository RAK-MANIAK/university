using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6
{
    public class Currency
    {
        protected string name;
        protected float exrate;
        public Currency(string name, float exrate)
        {
            this.name = name;
            this.exrate = exrate;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Exrate
        {
            get { return exrate; }
            set { exrate = value; }
        }
    }
}
