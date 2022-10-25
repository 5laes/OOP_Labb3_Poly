using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    //klass som ärver av Geometri
    class Fyrkant : Geometri
    {
        public double SideLength { get; set; }

        public Fyrkant()
        {
            SideLength = 6;
        }
        //metod som overridear basklassens metod för att räkna ut arean på en fyrkant
        override public double Area()
        {
            double area = SideLength * SideLength;
            return area;
        }
    }
}
