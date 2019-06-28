namespace Seneha_Hanımın_Mutfağı
{
    partial class ÖdemeForm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖdemeForm4));
            this.listView1siparis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtindirim = new System.Windows.Forms.TextBox();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.txtödenecek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtnnakit = new System.Windows.Forms.RadioButton();
            this.rdbtnkredi = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // listView1siparis
            // 
            this.listView1siparis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1siparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1siparis.GridLines = true;
            this.listView1siparis.Location = new System.Drawing.Point(44, 36);
            this.listView1siparis.Name = "listView1siparis";
            this.listView1siparis.Size = new System.Drawing.Size(484, 199);
            this.listView1siparis.TabIndex = 37;
            this.listView1siparis.UseCompatibleStateImageBehavior = false;
            this.listView1siparis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Masa No";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Ad";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adet";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Fiyat";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Zaman";
            this.columnHeader5.Width = 103;
            // 
            // btncıkıs
            // 
            this.btncıkıs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncıkıs.BackColor = System.Drawing.Color.Red;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.Black;
            this.btncıkıs.Location = new System.Drawing.Point(1009, 455);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(84, 26);
            this.btncıkıs.TabIndex = 39;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btngeri
            // 
            this.btngeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeri.BackColor = System.Drawing.Color.Lime;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.Black;
            this.btngeri.Location = new System.Drawing.Point(44, 455);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(84, 26);
            this.btngeri.TabIndex = 38;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(725, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ödeme Bilgileri";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(640, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "İndirim Tutarı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(640, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kdv";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(640, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Toplam Tutar";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(640, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ödenecek Tutar";
            // 
            // txtindirim
            // 
            this.txtindirim.Location = new System.Drawing.Point(779, 79);
            this.txtindirim.Multiline = true;
            this.txtindirim.Name = "txtindirim";
            this.txtindirim.Size = new System.Drawing.Size(119, 20);
            this.txtindirim.TabIndex = 45;
            this.txtindirim.TextChanged += new System.EventHandler(this.txtindirim_TextChanged);
            // 
            // txtkdv
            // 
            this.txtkdv.Location = new System.Drawing.Point(779, 127);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(119, 20);
            this.txtkdv.TabIndex = 46;
            // 
            // txttoplam
            // 
            this.txttoplam.Location = new System.Drawing.Point(779, 172);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(119, 20);
            this.txttoplam.TabIndex = 47;
            // 
            // txtödenecek
            // 
            this.txtödenecek.Location = new System.Drawing.Point(779, 215);
            this.txtödenecek.Name = "txtödenecek";
            this.txtödenecek.Size = new System.Drawing.Size(119, 20);
            this.txtödenecek.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(904, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "TL";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(904, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "TL";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(904, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "TL";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(904, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "TL";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Ödeme Seçenekleri";
            // 
            // rdbtnnakit
            // 
            this.rdbtnnakit.AutoSize = true;
            this.rdbtnnakit.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnnakit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtnnakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnnakit.ForeColor = System.Drawing.Color.White;
            this.rdbtnnakit.Location = new System.Drawing.Point(44, 306);
            this.rdbtnnakit.Name = "rdbtnnakit";
            this.rdbtnnakit.Size = new System.Drawing.Size(118, 24);
            this.rdbtnnakit.TabIndex = 54;
            this.rdbtnnakit.TabStop = true;
            this.rdbtnnakit.Text = "Nakit Ödeme";
            this.rdbtnnakit.UseVisualStyleBackColor = false;
            this.rdbtnnakit.CheckedChanged += new System.EventHandler(this.rdbtnnakit_CheckedChanged);
            // 
            // rdbtnkredi
            // 
            this.rdbtnkredi.AutoSize = true;
            this.rdbtnkredi.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnkredi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtnkredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnkredi.ForeColor = System.Drawing.Color.White;
            this.rdbtnkredi.Location = new System.Drawing.Point(44, 347);
            this.rdbtnkredi.Name = "rdbtnkredi";
            this.rdbtnkredi.Size = new System.Drawing.Size(151, 24);
            this.rdbtnkredi.TabIndex = 55;
            this.rdbtnkredi.TabStop = true;
            this.rdbtnkredi.Text = "Kredi Kart Ödeme";
            this.rdbtnkredi.UseVisualStyleBackColor = false;
            this.rdbtnkredi.CheckedChanged += new System.EventHandler(this.rdbtnkredi_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ÖdemeForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 488);
            this.Controls.Add(this.rdbtnkredi);
            this.Controls.Add(this.rdbtnnakit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtödenecek);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.txtkdv);
            this.Controls.Add(this.txtindirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.listView1siparis);
            this.Name = "ÖdemeForm4";
            this.Text = "ÖdemeForm4";
            this.Load += new System.EventHandler(this.ÖdemeForm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView listView1siparis;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtindirim;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.TextBox txtödenecek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbtnnakit;
        private System.Windows.Forms.RadioButton rdbtnkredi;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
    }
}