using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Potnik : Oseba
    {
        public string email;
        public Status status;

        public Potnik()
        {

        }
        public Potnik(string ime, string priimek, Spol spol, DateTime datum, string email, Status status) : base(ime, priimek, spol, datum)
        {
            this.email = email;
            this.status = status;
        }

        //sealed, zaklenjena metoda, ni mogoce predefinirati
        public sealed override string MojIzpis()
        {
            return base.MojIzpis() + ", " + email + ", " + status;
        }
    }
}
