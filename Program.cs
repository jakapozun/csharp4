//Jaka Pozun
//NALOGA 4
/*
 Preuredite svoj dosedanji projekt tako, da bo vsak razred v svoji ločeni datoteki *.cs. 

Pripravite razred Izlet. Posamezni izlet naj vsebuje atribute kot so naziv, ceno izleta ter kraj odhoda avtobusa. 

Razredu Izlet dodajte še atribut termini, ki naj bo polje objektov tipa Termin. Ta naj vsebuje atribute datum in čas odhoda in datum in čas prihoda ter dodeljen avtobus. V razredu termin vodite seznam (uporabite navadno polje) na izlet prijavljenih potnikov (število omejeno s številom sedežev avtobusa)

Omogočite tudi prodajo Izletov, pri čemer naj razred Izlet implementira vmesnik Prodajni, ki predpiše naslednje metode: 
void ProdajKarto(Termin termin, Potnik potnik), ki doda potnika na seznam prijavljenih potnikov
void PrekličiKarto(Termin termin,  Potnik potnik), ki odstrani potnika iz seznama prijavljenih izletnikov.
bool MestoProsto(Termin termin), preveri, če je na avtobusu še kakšno prosto mesto.
double IzračunajCeno(Potnik potnik), izračuna ceno izleta za posameznega potnika. Upoštevajte, da imajo pri nakupu karte upokojenci 10% popust, študenti pa 15% popust.

V razredu Oseba predefinirajte metodo, ki primerja enakost objektov. Osebi sta enaki, če imata enako ime, priimek, spol in datum rojstva.

Pri nalogi morate uporabiti in razumeti delovanje vmesnikov.

V glavnem programu demonstrirajte delovanje dodanih funkcionalnosti tako, da prikažete delovanje vseh navedenih metod.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_4
{
    public enum Prednosti { wifi, tv, klima, parkirisce, bazen };

    public class Program
    {       
        static void Main(string[] args)
        {
            /*
            //ustvarimo nove objekte
            Vozilo avto1 = new Vozilo(); // vozilo 
            avto1.voznik = new Oseba("Jaka", "Pozun");

            Vozilo avto2 = new Vozilo("Audi", "Bencin");
            avto2.voznik = new Oseba("Janez", "Novak");

            //objekti praznih konstruktorjev(ne vsebujejo lastnosti)
            Vozilo avto3 = new Vozilo();
            avto3.voznik = new Oseba();

            //izpis
            Console.WriteLine("Avto 1=>");
            Console.WriteLine("Znamka: {0}, Tip: {1}", avto1.znamka_vozila, avto1.tip_vozila);
            Console.WriteLine("Voznik: {0} {1}", avto1.voznik.ime, avto1.voznik.priimek);

            Console.WriteLine("Avto 2=>");
            Console.WriteLine("Znamka: {0}, Tip: {1}", avto2.znamka_vozila, avto2.tip_vozila);
            Console.WriteLine("Voznik: {0} {1}", avto2.voznik.ime, avto2.voznik.priimek);

            Console.WriteLine("Avto 3=>");
            Console.WriteLine("Znamka: {0}, Tip: {1}", avto3.znamka_vozila, avto3.tip_vozila);
            Console.WriteLine("Voznik: {0} {1}", avto3.voznik.ime, avto3.voznik.priimek);

            //objektom spremenimo lastnosti
            avto1.voznik.ime = "Miha";
            avto1.voznik.priimek = "Medeved";

            avto2.znamka_vozila = "Citroen";
            avto2.tip_vozila = "Diesel";

            //avto3 priredimo novega voznika
            avto3.voznik = new Oseba("Janja", "Novak");

            //izpis sprememb
            Console.WriteLine("Spremembe=>");

            Console.WriteLine("Avto 1:");
            Console.WriteLine("Voznik: {0} {1}", avto1.voznik.ime, avto1.voznik.priimek);

            Console.WriteLine("Avto 2:");
            Console.WriteLine("Znamka: {0}, Tip: {1}", avto2.znamka_vozila, avto2.tip_vozila);

            Console.WriteLine("Avto 3:");
            Console.WriteLine("Voznik: {0} {1}", avto3.voznik.ime, avto3.voznik.priimek);

            Console.WriteLine("-----------------------");
            Console.WriteLine("NALOGA 2=>");

            Vozilo nov_avto = new Vozilo("BMW", "X6", 9, 50);
            Oseba nova_oseba = new Oseba("Test_Ime", "Test_Priimek", "M", new DateTime(2008, 3, 9));

            nov_avto.MojIzpis();
            nova_oseba.MojIzpis();

            Console.WriteLine("Cas potovanja: {0}", nov_avto.PorabaGoriva(new DateTime(2012, 01, 01, 10, 0, 0), new DateTime(2012, 01, 01, 12, 0, 0), 120));
            Console.WriteLine("Prepotovana razdalja: {0}", nov_avto.PorabaGoriva(2, 120));
            Console.WriteLine("Poraba goriva: {0}", nov_avto.PorabaGoriva(100));

            //get
            Vozilo nov_avto2 = new Vozilo();
            Console.WriteLine("Tip goriva: {0}", nov_avto2.TipGoriva);

            //set
            nov_avto2.TipGoriva = "Diesel";
            Console.WriteLine("Tip goriva posodobljeno: {0}", nov_avto2.TipGoriva);

            //popravi Osebo, metoda za preverjanje, če ima vozilo voznika
            Vozilo zagovor = new Vozilo();
            zagovor.voznik = new Oseba();
            zagovor.voznik.ime = "Jaka2";
            zagovor.voznik.priimek = "Pozun2";

            Console.WriteLine("Obstaja: {0}", zagovor.Voznik(zagovor.voznik.ime, zagovor.voznik.priimek));

            Vozilo zagovor2 = new Vozilo();
            zagovor2.voznik = new Oseba();


            Console.WriteLine("Obstaja: {0}", zagovor2.Voznik(zagovor2.voznik.ime, zagovor2.voznik.priimek));
            

            Avtomobil avto1 = new Avtomobil("ford", "mondeo", 7.2, 50, 5, 2);
            Console.WriteLine(avto1.MojIzpis());
            Console.WriteLine("Zasedenost avtomobila: {0}% ", avto1.IzracunajZasedenost());
            Console.WriteLine("\n");

            Kombi kombi1 = new Kombi("Renault", "Master", 11, 70, 300, 700);
            Console.WriteLine(kombi1.MojIzpis());
            Console.WriteLine("Masa Tovor: {0}%", kombi1.IzracunajZasedenost());
            Console.WriteLine("\n");

            Avtobus bus1 = new Avtobus("Mercedes-Benz", "Conect", 14, 80, 48, 5, 31);
            Console.WriteLine(bus1.MojIzpis());
            Console.WriteLine("Zasedenost sedezev: {0}%", kombi1.IzracunajZasedenost());
            Console.WriteLine("\n");

            Potnik potnik1 = new Potnik("Jaka", "Pozun", Spol.moski, new DateTime(1998, 01, 01), "jaka.pozun@gmail.com", Status.student);
            Console.WriteLine(potnik1.MojIzpis());
            Console.WriteLine("\n");

            Voznik voznik1 = new Voznik("Gal", "Pozun", Spol.moski, new DateTime(1998, 01, 01), new DateTime(2022, 01, 01));
            Console.WriteLine(voznik1.MojIzpis());
            Console.WriteLine("\n");

            */

            //NALOGA 4 primeri
            
            Potnik potnik1 = new Potnik("Jaka", "Pozun", Oseba.Spol.moski, new DateTime(1998, 4, 26), "jaka.pozun@gmail.com", Oseba.Status.student);
            Console.WriteLine(potnik1.MojIzpis());

            Potnik potnik2 = new Potnik("Miha", "Pozun", Oseba.Spol.moski, new DateTime(1998, 5, 20), "miha.pozun@gmail.com", Oseba.Status.upokojenec);
            Console.WriteLine(potnik2.MojIzpis());

            Avtobus avtobus1 = new Avtobus("bus", "BUS", 14, 100, 45, 0, 10);
            Console.WriteLine(avtobus1.MojIzpis());

            Termin prvi_termin = new Termin(new DateTime(2018, 8, 8), new DateTime(2018, 9, 9), avtobus1, new Potnik[] { potnik1, potnik2 });

            Izlet prvi_izlet = new Izlet("Izlet", 100, "Velenje", new Termin[] { prvi_termin });

            prvi_izlet.ProdajKarto(prvi_termin, potnik1);
            prvi_izlet.ProdajKarto(prvi_termin, potnik2);

            prvi_izlet.PrekliciKarto(prvi_termin, potnik1);

            Console.WriteLine("Mesto prosto: " + prvi_izlet.MestoProsto(prvi_termin));

            prvi_izlet.IzracunajCeno(potnik2);

            Console.WriteLine("Osebi sta enaki: " + potnik1.EnakostObjektov((object)potnik2));           
            
             
            //prgledPrijavljenih...izpis....10potnikov
            
            Potnik potnik3 = new Potnik("Janez", "Pozun", Oseba.Spol.moski, new DateTime(1996, 5, 20), "miha.pozun@gmail.com", Oseba.Status.student);
            Potnik potnik4 = new Potnik("Gal", "Pozun", Oseba.Spol.moski, new DateTime(1960, 5, 20), "gal.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik5 = new Potnik("Tomaz", "Pozun", Oseba.Spol.moski, new DateTime(1955, 5, 20), "tomaz.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik6 = new Potnik("Urban", "Pozun", Oseba.Spol.moski, new DateTime(1977, 5, 20), "murbaniha.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik7 = new Potnik("Jan", "Pozun", Oseba.Spol.moski, new DateTime(1966, 5, 20), "jan.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik8 = new Potnik("Uros", "Pozun", Oseba.Spol.moski, new DateTime(1999, 5, 20), "uros.pozun@gmail.com", Oseba.Status.otrok);
            Potnik potnik9 = new Potnik("Vojka", "Pozun", Oseba.Spol.zenska, new DateTime(2000, 5, 20), "vojka.pozun@gmail.com", Oseba.Status.otrok);
            Potnik potnik10 = new Potnik("Franc", "Pozun", Oseba.Spol.moski, new DateTime(1974, 5, 20), "franc.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik11 = new Potnik("Bojan", "Pozun", Oseba.Spol.moski, new DateTime(1920, 5, 20), "bojan.pozun@gmail.com", Oseba.Status.upokojenec);
            Potnik potnik12 = new Potnik("Damjana", "Pozun", Oseba.Spol.zenska, new DateTime(2017, 5, 20), "damjana.pozun@gmail.com", Oseba.Status.otrok);
            
            prvi_izlet.ProdajKarto(prvi_termin, potnik3);
            prvi_izlet.ProdajKarto(prvi_termin, potnik4);
            prvi_izlet.ProdajKarto(prvi_termin, potnik5);
            prvi_izlet.ProdajKarto(prvi_termin, potnik6);
            prvi_izlet.ProdajKarto(prvi_termin, potnik7);
            prvi_izlet.ProdajKarto(prvi_termin, potnik8);
            prvi_izlet.ProdajKarto(prvi_termin, potnik9);
            prvi_izlet.ProdajKarto(prvi_termin, potnik10);
            prvi_izlet.ProdajKarto(prvi_termin, potnik11);
            prvi_izlet.ProdajKarto(prvi_termin, potnik12);

            prvi_izlet.PrekliciKarto(prvi_termin, potnik10);
            prvi_izlet.PrekliciKarto(prvi_termin, potnik6);

            prvi_izlet.PregledPrijavljenih(prvi_termin);


            Console.ReadKey();
        }
    }
}
