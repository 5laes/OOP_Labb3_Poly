using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    class Rektangel : Geometri
    {
        public double shortSide { get; set; }
        public double longSide { get; set; }

        public Rektangel()
        {
            shortSide = 3;
            longSide = 9;
        }
        override public double Area()
        {
            double area = longSide * shortSide; ;
            return area;
        }
    }
}
