using System;

namespace OOP_Labb3_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar en tomt objekt referens av klassen "Geometri"
            Geometri geometri;

            //Här pekar referensen till att bli ett objekt av klassen "Cirkel"
            geometri = new Cirkel();
            Console.Write($"\n\tArea cirkel:\t{geometri.Area()}");

            //Här pekar referensen till att bli ett objekt av klassen "Fyrkant"
            geometri = new Fyrkant();
            Console.Write($"\n\tArea fyrkant:\t{geometri.Area()}");

            //Här pekar referensen till att bli ett objekt av klassen "Rektangel"
            geometri = new Rektangel();
            Console.Write($"\n\tArea rektangel:\t{geometri.Area()}");
            Console.ReadLine();
        }
    }
}
