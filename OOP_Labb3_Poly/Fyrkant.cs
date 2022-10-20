using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    class Fyrkant : Geometri
    {
        public double sideLength { get; set; }

        public Fyrkant()
        {
            sideLength = 6;
        }
        override public double Area()
        {
            double area = sideLength * sideLength;
            return area;
        }
    }
}
