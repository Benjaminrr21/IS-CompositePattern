using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_CompositePattern
{
    public class RegistarskaNalepnica
    {
        public Vozilo v {  get; set; }
        public DateOnly DatumOd { get; set; }
        public DateOnly DatumDo { get; set; }

        public RegistarskaNalepnica(Vozilo v, DateOnly datumOd, DateOnly datumDo)
        {
            this.v = v;
            DatumOd = datumOd;
            DatumDo = datumDo;
        }



        public void IzdajNalepnicu(string naziv)
        {
            Console.WriteLine($"Registrovano vozilo: {naziv}\nRegistrovan od:{DatumOd}\nRegistrovan do:{DatumDo}\n"); 
        }
    }
}
