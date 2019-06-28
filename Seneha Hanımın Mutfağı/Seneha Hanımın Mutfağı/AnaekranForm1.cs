using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seneha_Hanımın_Mutfağı
{
    public partial class AnaekranForm1 : Form
    {
        public AnaekranForm1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SistemForm2 frm = new SistemForm2();
            frm.Show();
            this.Hide();
        }
    }
}
