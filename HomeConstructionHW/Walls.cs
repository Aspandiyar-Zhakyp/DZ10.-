using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Walls : IPart
    {
        private string name;
        public Walls(string name) { this.name = name; }
        public string GetName { get { return name; } }
    }
}
