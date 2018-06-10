using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Avtomobil : Vozilo
    {
        public int stevilo_sedezev;
        public int stevilo_potnikov;

        public Avtomobil()
        {

        }
        public Avtomobil(string znamka_vozila, string tip_vozila, double poraba_goriva, double rezervar, int stevilo_sedezev, int stevilo_potnikov) : base(znamka_vozila, tip_vozila, poraba_goriva, rezervar)
        {
            this.stevilo_sedezev = stevilo_sedezev;
            this.stevilo_potnikov = stevilo_potnikov;
        }
        public override double IzracunajZasedenost()
        {
            double zasedenost = ((100 / stevilo_sedezev) * stevilo_potnikov);
            return zasedenost;
        }
    }
}
