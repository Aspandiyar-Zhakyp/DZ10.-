using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Basement : IPart
    {
        private string name;
        public Basement(string name) { this.name = name; }
        public string GetName { get { return name; } }
    }
}
