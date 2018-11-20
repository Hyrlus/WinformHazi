using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlDolgozok
{
    static class Adatbazis
    {
        private static MySqlConnection kapcsolat;

        public static void Kapcsolodas()
        {
            try
            {
                string kapcsolatString =
                    "SERVER=localhost;" +
                    "DATABASE=dolgozok;" +
                    "UID=root;" +
                    "PASSWORD=;" +
                    "CHARSET=utf8;"; // String, ami alapján létrejön a kapcsolat. érdemes paraméteresen megírni a szakdolgozatnál
                kapcsolat = new MySqlConnection(kapcsolatString); // Kapcsolat létrehozása.
                kapcsolat.Open(); // Kapcsolat megnyitása
            }
            catch (Exception)
            {
                throw; // A hibaüzenetet csak továbbdobjuk, a formon kezeljük majd le.
            }
        }

        public static List<Dolgozo> BeolvasDolgozo()
        {
            List<Dolgozo> dolgozokLista = new List<Dolgozo>(); //lista létrehozása.
            MySqlDataReader reader = null; // Az adatbázisból való olvasásért felelős soronként olvas.
            MySqlCommand parancs; // Mysql parancsok kiadásáért felelős objektum.
            try
            {
                Kapcsolodas();
                string parancsStr = "SELECT * FROM dolgozok";
                parancs = new MySqlCommand(parancsStr, kapcsolat); // A parancs kiadása, 2 paraméter: mit csináljon, melyik adatbázis kapcsolaton.
                reader = parancs.ExecuteReader();
                while (reader.Read()) // Az adatok soronkénti olvasása
                {
                    int id = int.Parse(reader["id"].ToString());
                    string nev = reader["nev"].ToString();
                    bool nem = reader["nem"].ToString() == "férfi"; // Az adatbázisban szövegesen szerepel a nem, a Dolgozó osztályban logikai értékként.
                    int kor = int.Parse(reader["kor"].ToString());
                    int fizetes = int.Parse(reader["kereset"].ToString());

                    Dolgozo d = new Dolgozo(id, nev, nem, kor, fizetes); // dolgozo létrehozása a kiolvasott adatokból

                    dolgozokLista.Add(d);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                KapcsolatBezaras(); // Minden művelet után le kell zárni a kapcsolatot.
            }

            return dolgozokLista;
        }

        public static void KapcsolatBezaras() // ha van kapcsolat akkor azt bezárja
        {
            if (kapcsolat != null)
            {
                kapcsolat.Close(); 
            }
        }

        public static void BeszurDolgozo(Dolgozo d)
        {
            MySqlCommand parancs;
            try
            {
                Kapcsolodas();
                string parancsStr = "INSERT INTO dolgozok(nev,nem,kor,kereset) "+
                    "VALUES(@nev,@nem,@kor,@kereset)";

                parancs = new MySqlCommand(parancsStr, kapcsolat);
                parancs.Parameters.AddWithValue("@nev", d.Nev);
                parancs.Parameters.AddWithValue("@nem", d.Nem?"férfi":"nő");
                parancs.Parameters.AddWithValue("@kor", d.Eletkor);
                parancs.Parameters.AddWithValue("@kereset", d.Fizetes);

                parancs.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                KapcsolatBezaras();
            }
        }

        public static void TorolDolgozo(int id)
        {
            MySqlCommand parancs;
            try
            {
                Kapcsolodas();
                string parancsStr = "DELETE FROM dolgozok "+
                    "WHERE id = @id";

                parancs = new MySqlCommand(parancsStr, kapcsolat);
                parancs.Parameters.AddWithValue("@id", id);
                parancs.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                KapcsolatBezaras();
            }
        }
        
    }
}
