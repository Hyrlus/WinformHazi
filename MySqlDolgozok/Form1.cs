using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlDolgozok
{
    public partial class Form1 : Form
    {
        private Dolgozok dolg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dolg = new Dolgozok(0); // A form betöltődése után a Dolgozók példányosítása.
                kiir(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void kiir() // A lista kiíratása a szövegdobozba a beállított szempont és tartomány alapján
            // Minden vezérlőelem meghívja.
        {
            int szempont = cbSzempont.SelectedIndex;  // A szempont kiválasztása a combo boxból
            if (rbCsokkeno.Checked) // Csökkenő sorrend esetén 3-al növeli mivel a kódunk így lett megírva a Dolgozo osztályban
            {
                szempont += 3;
            }
            dolg.Rendez(szempont); // A dolgozók rendezése a szempont alapján
            tbDolgozok.Text = dolg.Listaz((int)nudKezdo.Value, (int)nudDolgozok.Value); // Listázás a kiválasztott tartományból
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            formHozzaad hozzaad = new formHozzaad(); // A hozzáadás form példányosítása
            hozzaad.FormClosing += Hozzaad_FormClosing; // Egy eseménykezelő hozzáadása a form bezárásához.
            // Ez az esemény kezelő innentől mindig lefut amikor bezárul a formHozzaad.
            hozzaad.Show(); // A hozzáadó form megjelenítése.
        }

        private void Hozzaad_FormClosing(object sender, FormClosingEventArgs e)
            // Eseménykezelő ami a form bezárásakor fut le.
        {
            dolg = new Dolgozok(0); // A dolgozókat újratölti az adatbázisból, (Nem hatékony)
            kiir(); // Ismételten kiírja a dolgozókat.
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            dolg.TorolDolgozo((int)nudTorolSorszam.Value); // Törli a beállított dolgozót a Dolgozok osztály metódusával
            kiir(); // Ismételten kiírja a dolgozókat.
        }

        
        // Az összes vezérlőelem ami a rendezési szempontért és a listázásért szerepel meghívja a kiir() metódust.
        // Alternatív megoldás lenne, hogy a kiir() ne sima metódus legyen hanem eseménykezelő és azt hozzárendelni minden elemhez
        // Ebben az esetben figyelni kell, hogy a kiir() egy általános eseménykezelő legyen ami minden eseményre lefuthat.
        private void cbSzempont_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiir();
        }

        private void rbNovekvo_CheckedChanged(object sender, EventArgs e)
        {
            kiir();
        }

        private void rbCsokkeno_CheckedChanged(object sender, EventArgs e)
        {
            kiir();
        }

        private void nudKezdo_ValueChanged(object sender, EventArgs e)
        {
            kiir();
        }

        private void nudDolgozok_ValueChanged(object sender, EventArgs e)
        {
            kiir();
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            dolg.ModositDolgozo()
        }
    }
}
