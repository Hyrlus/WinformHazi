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
    public partial class formModosit : Form
    {
        public formModosit()
        {
            InitializeComponent();
        }

        private void formModosit_Load(object sender, EventArgs e)
        {
            Adatbazis.BeolvasDolgozo();
        }
    }
}
