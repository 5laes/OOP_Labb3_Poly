using System;

namespace OOP_Labb3_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            Fyrkant fyrkant = new Fyrkant();
            Rektangel rektangel = new Rektangel();

            Console.Write($"\n\tArea cirkel:\t{cirkel.Area()}");
            Console.Write($"\n\tArea fyrkant:\t{fyrkant.Area()}");
            Console.Write($"\n\tArea rektangel:\t{rektangel.Area()}");
            Console.ReadLine();
        }
    }
}
