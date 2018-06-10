using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Voznik : Oseba
    {
        public DateTime veljavnost_vozniskega;
        public Voznik()
        {

        }
        public Voznik(string ime, string priimek, Spol spol, DateTime datum, DateTime veljavnost_vozniskega) : base(ime, priimek, spol, datum)
        {
            this.veljavnost_vozniskega = veljavnost_vozniskega;
        }

        //sealed, zaklenjena metoda, ni mogoce predefinirati
        public sealed override string MojIzpis()
        {
            return base.MojIzpis() + ", " + veljavnost_vozniskega;
        }
    }
}
