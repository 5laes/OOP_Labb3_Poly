using System;

namespace OOP_Labb3_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här pekar referensen till att bli ett objekt av klassen "Cirkel"
            Geometri cirkel = new Cirkel();
            Console.Write($"\n\tArea cirkel:\t{cirkel.Area()}");

            //Här pekar referensen till att bli ett objekt av klassen "Fyrkant"
            Geometri fyrkant = new Fyrkant();
            Console.Write($"\n\tArea fyrkant:\t{fyrkant.Area()}");

            //Här pekar referensen till att bli ett objekt av klassen "Rektangel"
            Geometri rektangel = new Rektangel();
            Console.Write($"\n\tArea rektangel:\t{rektangel.Area()}");
            Console.ReadLine();
        }
    }
}
