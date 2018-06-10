using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Kombi : Vozilo
    {
        public double masa_tovora;
        public double max_tovor;

        public Kombi()
        {

        }
        public Kombi(string znamka_vozila, string tip_vozila, double poraba_goriva, double rezervar, double masa_tovora, double max_tovor) : base(znamka_vozila, tip_vozila, poraba_goriva, rezervar)
        {
            this.masa_tovora = masa_tovora;
            this.max_tovor = max_tovor;
        }


        public override double IzracunajZasedenost()
        {
            double zasedenost = ((100 / max_tovor) * masa_tovora);
            return zasedenost;
        }
    }
}
