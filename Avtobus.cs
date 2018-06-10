using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Avtobus : Vozilo
    {
        public int stevilo_sedezev;
        public int stevilo_stojisc;
        public int stevilo_potnikov_bus;

        public Avtobus()
        {

        }

        public Avtobus(string znamka_vozila, string tip_vozila, double poraba_goriva, double rezervar, int stevilo_sedezev, int stevilo_stojisc, int stevilo_potnikov_bus) : base(znamka_vozila, tip_vozila, poraba_goriva, rezervar)
        {
            this.stevilo_sedezev = stevilo_sedezev;
            this.stevilo_stojisc = stevilo_stojisc;
            this.stevilo_potnikov_bus = stevilo_potnikov_bus;
        }
        public override double IzracunajZasedenost()
        {
            double zasedenost = (100 / (stevilo_sedezev + stevilo_stojisc) * stevilo_potnikov_bus);
            return zasedenost;
        }
    }
}
