using System;
using System.Collections.Generic;
namespace IS_CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Automobil fiat = new Automobil("NP-012-AB", "Putnicki", 1200, 300, 240, 50);
            Automobil astra = new Automobil("NP-055-TK", "Putnicki", 1200, 300, 240, 60);
            Automobil mercedes = new Automobil("NP-011-IS", "Teretni", 5000, 6000, 4000, 300);
            Automobil kombi = new Automobil("NP-331-KS", "Teretni", 3000, 2000, 1000, 500);

            Flota flota = new Flota();
            flota.DodajVozilo(astra);
            flota.DodajVozilo(mercedes);

            Console.WriteLine("LIST (samostalni objekat):\n");
            fiat.Ispis();
            fiat.Registracija();

            Console.WriteLine("KOMPOZICIJA OBJEKATA:");
            flota.Ispis();
            flota.Registracija();

            Console.ReadKey();
           

        }
    }
}