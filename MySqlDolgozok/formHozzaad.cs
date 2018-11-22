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
    public partial class formHozzaad : Form
    {
        public formHozzaad()
        {
            InitializeComponent();
        }

        private void btnHozzáad_Click(object sender, EventArgs e)
        {


            if (tbNev != null)
            {
                MessageBox.Show("Mindent kitöltöttél hozzáadva az adatbázishoz.");

            }
            else if (tbKereset != null)
            {
                MessageBox.Show("Mindent kitöltöttél hozzáadva az adatbázishoz.");

            }
            else {
                MessageBox.Show("Valami hiányzik.");

            }
           

        }

        private void tbNev_TextChanged(object sender, EventArgs e)
        {
            int maxlength = 10;
            if (tbNev.MaxLength > maxlength)
            {
                Console.WriteLine("A név túl hosszú");
            }
        }
              

        private void tbKereset_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void formHozzaad_Load(object sender, EventArgs e)
        {

        }
    }
}
