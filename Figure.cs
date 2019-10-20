using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Figure
    {
        public string rectangle()
        {
            return "***\n" +
                   "***";
        }
        public string rhombus()
        {
            return " *\n" +
                   "***\n" +
                   " *";
        }
        public string triangle()
        {
            return " *\n" +
                   "***";
        }
        public string trapezoid()
        {
            return " **\n" +
                   "****";
        }
        public string polygon()
        {
            return " **\n" +
                   "****\n" +
                   " **";
        }    
    }
}
