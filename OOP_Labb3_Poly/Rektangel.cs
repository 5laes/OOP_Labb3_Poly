using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    //klass som ärver av Geometri
    class Rektangel : Geometri
    {
        public double ShortSide { get; set; }
        public double LongSide { get; set; }

        public Rektangel()
        {
            ShortSide = 3;
            LongSide = 9;
        }
        //metod som overridear basklassens metod för att räkna ut arean på en rektangel
        override public double Area()
        {
            double area = LongSide * ShortSide; ;
            return area;
        }
    }
}
