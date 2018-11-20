using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDolgozok
{
    class Dolgozok
    {
        List<Dolgozo> lista;
        
        public Dolgozok(int szempont)
        {
            try
            {
                lista = Adatbazis.BeolvasDolgozo(); // Dolgozók beolvasása az adazbázisból
                Dolgozo.Szempont = szempont; // Rendezési szempont beállítása
                lista.Sort(); // Rendezés a beállított szempont szerint
            }
            catch (Exception)
            {
                throw;
            }
        }
        public override string ToString() 
            // A beépített ToString felülírása. Az objektum kiíratására szolgál.
        {
            //Táblázatszerű kiíratás.
           string kiir = String.Format
            ("{0,-20}{1,-10}{2,-3} {3,12}\r\n",
             "Név", "Nem", "Életkor", "Fizetés");
            foreach (Dolgozo d in lista)
            {
                kiir += d;
            }
            return kiir;
        }
        public void Rendez(int szempont) // Újra rendezés a paraméterül kapott szempont alapján.
        {
            Dolgozo.Szempont = szempont; // Rendezési szempont beállítása
            lista.Sort(); // Rendezés a beállított szempont szerint
        }
        public string Listaz(int kezdo, int db) 
            // db darab dolgozó listázása a paraméterül kapott kezdő sorszámtól
        {
            string kiir = "";
            /*
            string kiir = String.Format
            ("     {0,-20}{1,-10}{2,-3} {3,10}\r\n\r\n",
             "Név", "Nem", "Életkor", "Fizetés");
             */
            for (int i = kezdo-1; i < kezdo-1+db; i++) 
                // A kezdő sorszámból egyet kivonunk mert a lista 0-tól indexel, míg a formon 1-től számozunk.
            {
                kiir += String.Format("{0,3}. {1}",i+1 ,lista[i].ToString());
            }
            return kiir;
        }

        public void BeszurDolgozo(Dolgozo d)
            // Dolgozó beszúrása
        {
            Adatbazis.BeszurDolgozo(d); // Dolgozó beszúrása az adatbázisba
            lista = Adatbazis.BeolvasDolgozo(); // A lista újratöltése az adatbázisból (nem hatékony)
            lista.Sort(); // A lista újrarendezése
        }

        public void TorolDolgozo(int sorszam)
            // Az adott dolgozó törlése a sorszám alapján
        {
            Adatbazis.TorolDolgozo(lista[sorszam - 1].Id); // Dolgozó törlése az adatbázisból id alapján
                // A sorszámból 1-t ki kell vonni a 0-tól indexelés miatt
            lista = Adatbazis.BeolvasDolgozo(); // A lista újratöltése az adatbázisból (nem hatékony)
            lista.Sort(); // A lista újrarendezése

        }
    }
}
