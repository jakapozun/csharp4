using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public abstract class Oseba
    {
        public enum Status { otrok, student, upokojenec };
        public enum Spol { moski, zenska };

        //ustvarim atribute
        public string ime;
        public string priimek;
        public Spol spol;
        public DateTime datum;
        private string zacetnice;

        public string Zacetnice
        {
            get
            {
                return zacetnice;
            }
            set
            {
                zacetnice = value;
            }
        }

        public Oseba()
        {

        }
        public Oseba(string ime, string priimek)
        {
            this.ime = ime;
            this.priimek = priimek;
        }

        public Oseba(string ime, string priimek, Spol spol, DateTime datum) : this(ime, priimek)
        {
            this.spol = spol;
            this.datum = datum;
        }

        public virtual string MojIzpis()
        {
            return ime + " " + priimek + ", " + spol + ", " + datum;
        }

        public bool EnakostObjektov(object objekt)
        {
            var obj = objekt as Oseba;

            if(ime == obj.ime && priimek == obj.priimek && spol == obj.spol && datum == obj.datum)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
