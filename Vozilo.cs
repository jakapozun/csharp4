using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public abstract class Vozilo
    {
        
        //atribut voznik je tipa Oseba(pridobi vse lastnosti razreda Oseba)
        public Oseba voznik;
        public string znamka_vozila;
        public string tip_vozila;
        public double poraba_goriva;
        public double rezervar;
        private string tip_goriva;

        public string TipGoriva
        {
            get
            {
                return tip_goriva;
            }
            set
            {
                tip_goriva = value;
            }
        }

        public abstract double IzracunajZasedenost();


        //default konstruktor(prazen)
        public Vozilo()
        {
            tip_goriva = "Bencin";
        }
        //Konstruktor, ki prejme parametre
        public Vozilo(string znamka_vozila, string tip_vozila)
        {
            //z this nastavimo lastnosti
            this.znamka_vozila = znamka_vozila;
            this.tip_vozila = tip_vozila;
        }

        public Vozilo(string znamka_vozila, string tip_vozila, double poraba_goriva, double rezervar) : this(znamka_vozila, tip_vozila)
        {
            this.poraba_goriva = poraba_goriva;
            this.rezervar = rezervar;
        }

        public double PorabaGoriva(double prepotovana_razdalja)
        {
            return prepotovana_razdalja * (poraba_goriva / 100);
        }

        public double PorabaGoriva(double cas_potovanja, double povprecna_hitrost)
        {
            double prepotovana_razdalja = cas_potovanja * povprecna_hitrost;
            return PorabaGoriva(prepotovana_razdalja);
        }

        public double PorabaGoriva(DateTime cas_odhoda, DateTime cas_prihoda, double povprecna_hitrost)
        {
            double cas_potovanja = (cas_prihoda - cas_odhoda).TotalHours;
            return PorabaGoriva(cas_potovanja, povprecna_hitrost);

        }

        public virtual string MojIzpis()
        {
            return znamka_vozila + ", " + tip_vozila + ", " + poraba_goriva + ", " + rezervar;
        }

        public bool Voznik(string ime, string priimek)
        {
            if (ime == null && priimek == null)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
