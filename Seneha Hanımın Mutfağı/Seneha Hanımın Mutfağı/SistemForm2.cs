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
    public partial class SistemForm2 : Form
    {
        public SistemForm2()
        {
            InitializeComponent();
        }
        SiparisekranForm3 frm = new SiparisekranForm3();
 
        public string btnvalue;
        public string btnname;
        private void btn1_Click(object sender, EventArgs e)
        {
           
            btn1.BackColor = Color.Red;
            int uzunluk = btn1.Text.Length;
            btnvalue = btn1.Text.Substring(uzunluk-6, 6);
            btnname = btn1.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Red;
            int uzunluk = btn2.Text.Length;
            btnvalue = btn2.Text.Substring(uzunluk-6, 6);
            btnname = btn2.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Red;
            int uzunluk = btn3.Text.Length;
            btnvalue = btn3.Text.Substring(uzunluk-6, 6);
            btnname = btn3.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Red;
            int uzunluk = btn4.Text.Length;
            btnvalue = btn4.Text.Substring(uzunluk-6, 6);
            btnname = btn4.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.BackColor = Color.Red;
            int uzunluk = btn5.Text.Length;
            btnvalue = btn5.Text.Substring(uzunluk-6, 6);
            btnname = btn5.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.BackColor = Color.Red;
            int uzunluk = btn6.Text.Length;
            btnvalue = btn6.Text.Substring(uzunluk-6, 6);
            btnname = btn6.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.BackColor = Color.Red;
            int uzunluk = btn7.Text.Length;
            btnvalue = btn7.Text.Substring(uzunluk-6, 6);
            btnname = btn7.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.BackColor = Color.Red;
            int uzunluk = btn8.Text.Length;
            btnvalue = btn8.Text.Substring(uzunluk-6, 6);
            btnname = btn8.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.BackColor = Color.Red;
            int uzunluk = btn9.Text.Length;
            btnvalue = btn9.Text.Substring(uzunluk-6, 6);
            btnname = btn9.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.BackColor = Color.Red;
            int uzunluk = btn10.Text.Length;
            btnvalue = btn10.Text.Substring(uzunluk-7, 7);
            btnname = btn10.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.BackColor = Color.Red;
            int uzunluk = btn11.Text.Length;
            btnvalue = btn11.Text.Substring(uzunluk-7, 7);
            btnname = btn11.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.BackColor = Color.Red;
            int uzunluk = btn12.Text.Length;
            btnvalue = btn12.Text.Substring(uzunluk-7, 7);
            btnname = btn12.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            btn13.BackColor = Color.Red;
            int uzunluk = btn13.Text.Length;
            btnvalue = btn13.Text.Substring(uzunluk-7, 7);
            btnname = btn13.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            btn14.BackColor = Color.Red;
            int uzunluk = btn14.Text.Length;
            btnvalue = btn14.Text.Substring(uzunluk-7, 7);
            btnname = btn14.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            btn15.BackColor = Color.Red;
            int uzunluk = btn15.Text.Length;
            btnvalue = btn15.Text.Substring(uzunluk-7, 7);
            btnname = btn15.Name;
            frm.label3masano.Text = btnvalue;
            frm.Show();
            //this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnaekranForm1 frm = new AnaekranForm1();
            frm.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
