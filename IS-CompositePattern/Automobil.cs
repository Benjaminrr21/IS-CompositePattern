using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_CompositePattern
{
    public class Automobil : Vozilo
    {
        private readonly string regBroj;
        private readonly string tip;
        private readonly int kapacitet;
        private readonly double ukupnaTezina;
        private readonly double tezinaPraznogVozila;
        private readonly double kapacitetPrtljaga;

        public Automobil(string regBroj,string tip, int kapacitet,double ukupnaTezina,double tezinaPraznogVozila,double kapacitetPrtljaga)
        {
            this.regBroj = regBroj;
            this.tip = tip;
            this.kapacitet = kapacitet;
            this.ukupnaTezina = ukupnaTezina;
            this.tezinaPraznogVozila = tezinaPraznogVozila;
            this.kapacitetPrtljaga = kapacitetPrtljaga;
        }

        public void Ispis()
        {
            Console.WriteLine($"Vozilo:{this.regBroj}\nNosivost:{this.IzracunajNosivost()}\nKapacitet:{this.NadjiKapacitet()}\n");
        }

        public double IzracunajNosivost()
        {
            var nosivost = ukupnaTezina - tezinaPraznogVozila;
            return nosivost;
        }

        public double NadjiKapacitet()
        {
            return kapacitet;
        }

        public void Registracija()
        {
            var regNalepnica = new RegistarskaNalepnica(this, new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                new DateOnly(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day));
            regNalepnica.IzdajNalepnicu(this.regBroj);
        }
    }
}
