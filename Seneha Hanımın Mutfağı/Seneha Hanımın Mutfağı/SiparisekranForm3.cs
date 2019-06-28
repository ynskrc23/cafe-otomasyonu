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
    public partial class SiparisekranForm3 : Form
    {
        ÖdemeForm4 frm = new ÖdemeForm4();
        public SiparisekranForm3()
        {
            InitializeComponent();
        }
        private void txtadet_TextChanged(object sender, EventArgs e)
        {
            if (txtadet.Text.Length >= 3)
            {
                MessageBox.Show("Fazla Adet Girdiniz");
                txtadet.Clear();
            }
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadet.Clear();
        }

        SenehaCafeEntities3 db = new SenehaCafeEntities3();
        private void btnanayemek_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.anayemeks.ToList();
        }

        private void btnsalata_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.salatas.ToList();

        }

        private void btncorba_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.corbalars.ToList();
        }

        private void btniceck_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.iceceklers.ToList();
        }

        private void btntatlı_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.tatlılar.ToList();
        }

        private void btnsıcakice_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.sıcak_icecek.ToList();
        }

        private void btnsogukice_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.soguk_iceceks.ToList();
        }

        private void btndondurma_Click(object sender, EventArgs e)
        {
            dataGridView1menü.DataSource = db.dondurmas.ToList();
            
        }
        private void dataGridView1menü_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtadet.Text == "")
            {
                txtadet.Text = "1";
            }
            if (dataGridView1menü.RowCount >= 0)
            {
                int syc=listView1.Items.Count;
                listView1.Items.Add(label3masano.Text);
                listView1.Items[syc].SubItems.Add(dataGridView1menü.CurrentRow.Cells[1].Value.ToString());
                listView1.Items[syc].SubItems.Add(txtadet.Text);
                listView1.Items[syc].SubItems.Add((Convert.ToDouble(dataGridView1menü.CurrentRow.Cells[2].Value)*Convert.ToDouble(txtadet.Text)).ToString());
                listView1.Items[syc].SubItems.Add(DateTime.Now.ToShortDateString());                
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }
        private void btnsiparis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                frm.listView1siparis.Items.Add(new ListViewItem(new String[] { listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text, listView1.Items[i].SubItems[3].Text, listView1.Items[i].SubItems[4].Text }));

                siparisler sp = new siparisler();
                sp.Masa_No = listView1.Items[i].SubItems[0].Text;
                sp.Ürün_Ad = listView1.Items[i].SubItems[1].Text;
                sp.Ürün_Adet = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                sp.Ürün_Fiyat = Convert.ToDecimal(listView1.Items[i].SubItems[3].Text);
                sp.Zaman = Convert.ToDateTime(listView1.Items[i].SubItems[4].Text);
                db.siparislers.Add(sp);
                db.SaveChanges(); 
            }
            frm.Show();
            this.Hide();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            SistemForm2 frm = new SistemForm2();
            frm.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
