using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDolgozok
{
    class Dolgozo : IComparable // Megvalósítja az IComparable interface-t.
        // Ennek köszönhetően tudjuk használni a CompareTo függvényt.
        // A kód hibája, hogy így minden obejktummal össze lehet haszonlítani nem csak dolgozóval.
        // Helyes megoldás IComparable<Dolgozo> lenne.
        // Ebben az esetben az implementált CompareTo függvény paramétere már nem objektum, hanem Dolgozo, így nem kell külön castolni
    {
        private int id;
        private string nev;
        private bool nem;
        private int eletkor;
        private int fizetes;

        private static int szempont;// Statikus osztályváltozó, egyetlen érték minden objektumpéldányhoz
        // Osztályszinten állítjuk be az értékét, nem pedig objektum szinten
        // Ebben tároljuk a rendezés szempontját


        public string Nev
        {
            get
            {
                return nev;
            }
        }

        public bool Nem
        {
            get
            {
                return nem;
            }
        }

        public int Eletkor
        {
            get
            {
                return eletkor;
            }
        }

        public int Fizetes
        {
            get
            {
                return fizetes;
            }
        }

        public static int Szempont
        {
            get
            {
                return szempont;
            }

            set
            {
                szempont = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Dolgozo(string nev, bool nem, int eletkor, int fizetes)
            // 4 paraméteres konstruktor
            // Dolgozó létrehozása id nélkül
        {
            this.nev = nev;
            this.nem = nem;
            this.eletkor = eletkor;
            this.fizetes = fizetes;
        }

        public Dolgozo(int id, string nev, bool nem, int eletkor, int fizetes)
        // 5 paraméteres konstruktor
        // Dolgozó létrehozása id-vel
        {
            this.id = id;
            this.nev = nev;
            this.nem = nem;
            this.eletkor = eletkor;
            this.fizetes = fizetes;
        }

        public int CompareTo(object obj)
        // Összehasonlítja az aktuális objektumot a paraméterben kapott objektummal
        // -1, 0, 1 értéket ad vissza, ha az aktuális objektum <, =, vagy >, mint a paraméterben kapott objektum
        {
            switch (szempont)
            {
                case 0:
                    return this.nev.CompareTo(((Dolgozo)obj).nev);
                    break;
                case 1:
                    return this.eletkor.CompareTo(((Dolgozo)obj).eletkor);
                    break;
                case 2:
                    return this.fizetes.CompareTo(((Dolgozo)obj).fizetes);
                    break;
                case 3:
                    return - this.nev.CompareTo(((Dolgozo)obj).nev);
                    //return ((Dolgozo)obj).nev.CompareTo(this.nev);
                    break;
                case 4:
                    return - this.eletkor.CompareTo(((Dolgozo)obj).eletkor);
                    break;
                case 5:
                    return - this.fizetes.CompareTo(((Dolgozo)obj).eletkor);
                    break;

                default:
                    return this.nev.CompareTo(((Dolgozo)obj).nev);
                    break;
            }
        }
        public override string ToString() //Beépített ToString() felülbírálása
            // A Dolgozo így kiírható függvények segítsége nélkül.
        {
            return String.Format("{0,-20}{1,-10}{2,-3} {3,12:0 000} Ft\r\n", 
                nev, nem ? "Férfi" : "Nő", eletkor, fizetes);
        }
    }
}
