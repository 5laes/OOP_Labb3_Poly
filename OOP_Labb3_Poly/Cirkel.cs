using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    class Cirkel : Geometri
    {
        public double radius { get; set; }

        public Cirkel()
        {
            radius = 9;
        }
        
        override public double Area()
        {
            double area = radius * radius * 3.14;
            return area;
        }
    }
}
