using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Termin
    {     
        public DateTime datum_cas_odhoda;
        public DateTime datum_cas_prihoda;
        public Avtobus avtobus;

        public Potnik[] poljePotnikov;

        public Termin()
        {

        }

        public Termin(DateTime datum_cas_odhoda, DateTime datum_cas_prihoda, Avtobus avtobus, Potnik[] poljePotnikov)
        {
            this.datum_cas_odhoda = datum_cas_odhoda;
            this.datum_cas_prihoda = datum_cas_prihoda;
            this.avtobus = avtobus;
            this.poljePotnikov = new Potnik[avtobus.stevilo_sedezev];
        }
    }
}
