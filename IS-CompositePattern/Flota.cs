using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_CompositePattern
{
    public class Flota : Vozilo
    {
        public List<Vozilo> vozila {  get; set; }
        public Flota()
        {
            vozila = new List<Vozilo>();
        }
        public double IzracunajNosivost()
        {
            double sum = 0;
            foreach (var vozilo in vozila)
            {
                sum += vozilo.IzracunajNosivost();
            }
            return sum;
        }

        public double NadjiKapacitet()
        {
            return vozila.Sum(v => v.NadjiKapacitet());
        }

        public void Registracija()
        {
            Console.WriteLine("Registracija flote:\n");
            foreach (var v in vozila)
            {
                v.Registracija();
            }
        }
        public void DodajVozilo(Vozilo v)
        {
            vozila.Add(v);
        }
        public void UkloniVozilo(Vozilo v)
        {
            vozila.Remove(v);
        }

        public void Ispis()
        {
            Console.WriteLine($"Ukupna nosivost flote: {this.IzracunajNosivost()}");
            Console.WriteLine($"Ukupni kapacitet flote: {this.NadjiKapacitet()}");
            Console.WriteLine("Popis vozila u floti:\n");
            foreach (var v in vozila)
            {
                v.Ispis();
            }
        }
    }
}
