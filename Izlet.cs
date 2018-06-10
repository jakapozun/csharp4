using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public class Izlet : IProdajni
    {
        public string naziv;
        public double cena_izleta;
        public string kraj_odhoda;

        public Termin[] polje;

        public Izlet()
        {

        }
        
        public Izlet(string naziv, double cena_izleta, string kraj_odhoda, Termin[] polje)
        {
            this.naziv = naziv;
            this.cena_izleta = cena_izleta;
            this.kraj_odhoda = kraj_odhoda;
            this.polje = polje;
        }

        public void ProdajKarto(Termin termin, Potnik potnik)
        {
            for(int i = 0; i < polje.Length; i++)
            {
                if(polje[i] == termin)
                {
                    for(int j = 0; j < polje[i].poljePotnikov.Length; j++)
                    {
                       
                        if (polje[i].poljePotnikov[j] == null)
                        { 
                            polje[i].poljePotnikov[j] = potnik;
                            Console.WriteLine(potnik.ime + " " + potnik.priimek + " je bil/a dodan/a v termin.");
                            return;
                        }
                    }

                    Console.WriteLine("Napaka pri dodajanju!");
                }
            }
            Console.WriteLine("Napaka pri terminu!)");
        }
        public double IzracunajCeno(Potnik potnik)
        {
            double cena;

            if(potnik.status == Oseba.Status.upokojenec)
            {
                cena = (cena_izleta * 0.9);
                Console.WriteLine("Cena izleta je " + cena + "eu.");
            }
            else if(potnik.status == Oseba.Status.student)
            {
                cena = (cena_izleta * 0.85);
                Console.WriteLine("Cena izleta je " + cena + "eu.");
            }
            else
            {
                cena = cena_izleta;
                Console.WriteLine("Cena izleta je " + cena + "eu.");
            }

            return cena;

        }

        public bool MestoProsto(Termin termin)
        {
            int st = 0;

            for(int i = 0; i < termin.poljePotnikov.Length; i++)
            {
                if(termin.poljePotnikov[i] != null)
                {
                    st++;
                }
            }

            if(st > termin.avtobus.stevilo_sedezev)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public void PrekliciKarto(Termin termin, Potnik potnik)
        {
            for(int i = 0; i < polje.Length; i++)
            {
                if(polje[i] == termin)
                {            
                    for(int j = 0; j < polje[i].poljePotnikov.Length; j++)
                    {
                        if(polje[i].poljePotnikov[j] == potnik)
                        {
                            polje[i].poljePotnikov[j] = null;
                            Console.WriteLine(potnik.ime + " " + potnik.priimek + " je bil/a izbrisan/a iz termina.");
                            return;
                        }
                        
                    }
                    Console.WriteLine("Napaka pri preklicu!");
                }
            }
            Console.WriteLine("Napaka pri terminu!");
        }

        public void PregledPrijavljenih(Termin termin)
        {
            for(int i = 0; i < polje.Length; i++)
            {
                if(polje[i] == termin)
                {
                    for (int j = 0; j < polje[i].poljePotnikov.Length; j++)
                    {
                        if(polje[i].poljePotnikov[j] != null)
                        {
                            Console.WriteLine(termin.poljePotnikov[j].ime);
                        }                    
                    }
                }
                
            }
        }

        
    }     
    
}
