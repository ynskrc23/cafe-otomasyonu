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
    public partial class ÖdemeForm4 : Form
    {
        public ÖdemeForm4()
        {
            InitializeComponent();
        }
         SenehaCafeEntities3 db = new SenehaCafeEntities3();
         private void ÖdemeForm4_Load(object sender, EventArgs e)
        {
            if (listView1siparis.Items.Count > 0)
            {
                decimal toplam = 0;

                for (int i = 0; i < listView1siparis.Items.Count; i++)
                {
                    toplam += Convert.ToDecimal(listView1siparis.Items[i].SubItems[3].Text);
                }
            txttoplam.Text= string.Format("{0:0.00}", toplam);
            txtödenecek.Text= string.Format("{0:0.00}", toplam);
 
            } 
        }
    
         private void txtindirim_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 if (Convert.ToDecimal(txtindirim.Text) < Convert.ToDecimal(txttoplam.Text))
                 {
                     try
                     {
                         txtindirim.Text = string.Format("{0:0.00}", Convert.ToDecimal(txtindirim.Text));
                     }

                     catch (Exception)
                     {
                         txtindirim.Text = string.Format("{0:0.00}", 0);
                     }
                 }
                 else
                 {
                     MessageBox.Show("İndirim Tutarını Fiyatdan Fazla Olamaz...");
                     txtindirim.Text = string.Format("{0:0.00}", 0);
                 }
             }
             catch (Exception)
             {
                 txtindirim.Text = string.Format("{0:0.00}", 0);
             }
             if (Convert.ToDecimal(txtindirim.Text) > 0)
             {
                 decimal ödeme = 0;
                 txtödenecek.Text = txttoplam.Text;
                 ödeme = Convert.ToDecimal(txtödenecek.Text) - Convert.ToDecimal(txtindirim.Text);
                 txtödenecek.Text= string.Format("{0:0.00}", ödeme);
             }
             else
             {
                 txtödenecek.Text = txttoplam.Text;
             }
             decimal kdv = Convert.ToDecimal(txtödenecek.Text) * 18 / 100;
            txtkdv.Text = string.Format("{0:0.00}", kdv);
         }
         private void rdbtnnakit_CheckedChanged(object sender, EventArgs e)
         {
             rdbtnkredi.Enabled = false;
             MessageBox.Show("Ödemeniz İçin Garson Gelecek");
             printPreviewDialog1.ShowDialog();
             MessageBox.Show("Ödemeniz Yapılmıştır İyi Günler...");

             AnaekranForm1 frm = new AnaekranForm1();
             frm.Show();
             this.Hide();
         }
         private void rdbtnkredi_CheckedChanged(object sender, EventArgs e)
         {
             rdbtnnakit.Enabled = false;
             MessageBox.Show("Ödemeniz İçin Garson Gelecek");
             printPreviewDialog1.ShowDialog();
             MessageBox.Show("Ödemeniz Yapılmıştır İyi Günler...");

             AnaekranForm1 frm = new AnaekranForm1();
             frm.Show();
             this.Hide(); 
         }
         private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             Font baslık = new Font("Calibri", 24, FontStyle.Bold);
             Font altbaslık = new Font("Calibri", 20, FontStyle.Bold);
             Font icerik = new Font("Calibri", 16, FontStyle.Bold);
             SolidBrush ym = new SolidBrush(Color.Black);

             StringFormat yn = new StringFormat();
             yn.Alignment = StringAlignment.Near;
             e.Graphics.DrawString("HESAP ÖZETİ", baslık, ym, 300, 200, yn);
             e.Graphics.DrawString("Masa No      Ürün Ad              Ürün Adet         Ürün Fiyat         Zaman", altbaslık, ym, 0, 250, yn);
             e.Graphics.DrawString("---------------------------------------------------------------------------------------------------", altbaslık, ym, 0, 280, yn);

             for (int i = 0; i < listView1siparis.Items.Count; i++)
             {
                 e.Graphics.DrawString(listView1siparis.Items[i].SubItems[0].Text, icerik, ym, 10, 300 + i * 30, yn);
                 e.Graphics.DrawString(listView1siparis.Items[i].SubItems[1].Text, icerik, ym, 140, 300 + i * 30, yn);
                 e.Graphics.DrawString(listView1siparis.Items[i].SubItems[2].Text, icerik, ym, 400, 300 + i * 30, yn);
                 e.Graphics.DrawString(listView1siparis.Items[i].SubItems[3].Text, icerik, ym, 550, 300 + i * 30, yn);
                 e.Graphics.DrawString(listView1siparis.Items[i].SubItems[4].Text, icerik, ym, 705, 300 + i * 30, yn);
             }

             e.Graphics.DrawString("---------------------------------------------------------------------------------------------------", altbaslık, ym, 0, 300 + 30 * listView1siparis.Items.Count, yn);
             e.Graphics.DrawString("MASA NO =" + listView1siparis.Items[0].SubItems[0].Text + "", icerik, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 1), yn);
             e.Graphics.DrawString("İNDİRİM TUTARI =" + txtindirim.Text + " TL", icerik, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 2), yn);
             e.Graphics.DrawString("KDV TUTARI =" + txtkdv.Text + " TL", icerik, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 3), yn);
             e.Graphics.DrawString("TOPLAM TUTARI =" + txttoplam.Text + " TL", icerik, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 4), yn);
             e.Graphics.DrawString("ÖDENECEK TUTARI =" + txtödenecek.Text + " TL", icerik, ym, 250, 300 + 30 * (listView1siparis.Items.Count + 5), yn);

             ödeme m = new ödeme();
             m.masa_no = listView1siparis.Items[0].SubItems[0].Text;
             m.indirim = Convert.ToDecimal(txtindirim.Text);
             m.kdv = Convert.ToDecimal(txtkdv.Text);
             m.toplam = Convert.ToDecimal(txttoplam.Text);
             m.ödenecek = Convert.ToDecimal(txtödenecek.Text);
             db.ödeme.Add(m);
             db.SaveChanges();
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