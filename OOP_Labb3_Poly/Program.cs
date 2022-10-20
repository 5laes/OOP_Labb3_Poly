using System;

namespace OOP_Labb3_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri;

            geometri = new Cirkel();
            Console.Write($"\n\tArea cirkel:\t{geometri.Area()}");

            geometri = new Fyrkant();
            Console.Write($"\n\tArea fyrkant:\t{geometri.Area()}");

            geometri = new Rektangel();
            Console.Write($"\n\tArea rektangel:\t{geometri.Area()}");
            Console.ReadLine();
        }
    }
}
