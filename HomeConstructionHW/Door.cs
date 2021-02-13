using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Door : IPart
    {
        private string name;
        public Door(string name) { this.name = name; }
        public string GetName { get { return name; } }
    }
}
