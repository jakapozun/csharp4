using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    interface IProdajni
    {
        void ProdajKarto(Termin termin, Potnik potnik);

        void PrekliciKarto(Termin termin, Potnik potnik);

        bool MestoProsto(Termin termin);

        double IzracunajCeno(Potnik potnik);

        void PregledPrijavljenih(Termin termin);
    }

}
