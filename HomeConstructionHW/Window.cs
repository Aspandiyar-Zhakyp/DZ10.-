using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    class Window : IPart
    {
        private string name;
        public Window(string name) { this.name = name; }
        public string GetName { get { return name; } }
    }
}
