using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3_Poly
{
    //klass som ärver av Geometri
    class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 9;
        }

        //metod som overridear basklassens metod för att räkna ut arean på en cirkel
        override public double Area()
        {
            double area = Radius * Radius * 3.14;
            return area;
        }
    }
}
