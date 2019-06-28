namespace Seneha_Hanımın_Mutfağı
{
    partial class AnaekranForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaekranForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENEHA HANIMIN MUTFAĞINA HOŞ GELDİNİZ";
            // 
            // btngiris
            // 
            this.btngiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngiris.BackColor = System.Drawing.Color.Transparent;
            this.btngiris.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(451, 168);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(154, 48);
            this.btngiris.TabIndex = 1;
            this.btngiris.Text = "Sisteme Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // AnaekranForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 484);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label1);
            this.Name = "AnaekranForm1";
            this.Text = "AnaekranForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngiris;


    }
}

