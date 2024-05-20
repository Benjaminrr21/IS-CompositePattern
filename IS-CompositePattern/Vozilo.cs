using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_CompositePattern
{
    public interface Vozilo
    {
        public double NadjiKapacitet();
        public double IzracunajNosivost();
        public void Registracija();
        public void Ispis();

    }

}
