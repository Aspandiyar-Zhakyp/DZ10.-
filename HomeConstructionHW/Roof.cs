using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Roof : IPart
    {
        private string name;
        public Roof(string name) { this.name = name; }
        public string GetName { get { return name; } }
    }
}
