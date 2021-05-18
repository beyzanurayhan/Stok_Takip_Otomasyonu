
namespace Stok_Takip
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtÜrünAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisİptal = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSatislariListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            this.btnMüsteriListeleme = new System.Windows.Forms.Button();
            this.btnMüsteriEkleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(670, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Location = new System.Drawing.Point(46, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 99);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 60);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(94, 22);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatisFiyati);
            this.groupBox2.Controls.Add(this.txtMiktari);
            this.groupBox2.Controls.Add(this.txtÜrünAdi);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(46, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(94, 171);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtToplamFiyat.TabIndex = 5;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(94, 137);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 23);
            this.txtSatisFiyati.TabIndex = 4;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.txtSatisFiyati_TextChanged);
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(94, 99);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 23);
            this.txtMiktari.TabIndex = 3;
            this.txtMiktari.Text = "1";
            this.txtMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtÜrünAdi
            // 
            this.txtÜrünAdi.Location = new System.Drawing.Point(94, 61);
            this.txtÜrünAdi.Name = "txtÜrünAdi";
            this.txtÜrünAdi.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünAdi.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 22);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(305, 493);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(981, 174);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisİptal
            // 
            this.btnSatisİptal.Location = new System.Drawing.Point(981, 212);
            this.btnSatisİptal.Name = "btnSatisİptal";
            this.btnSatisİptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisİptal.TabIndex = 5;
            this.btnSatisİptal.Text = "Satış İptal";
            this.btnSatisİptal.UseVisualStyleBackColor = true;
            this.btnSatisİptal.Click += new System.EventHandler(this.btnSatisİptal_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(821, 493);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(72, 23);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Genel Toplam";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(796, 425);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 15);
            this.lblGenelToplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSatislariListeleme);
            this.panel1.Controls.Add(this.btnÜrünListeleme);
            this.panel1.Controls.Add(this.btnÜrünEkleme);
            this.panel1.Controls.Add(this.btnMüsteriListeleme);
            this.panel1.Controls.Add(this.btnMüsteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 92);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(884, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatislariListeleme
            // 
            this.btnSatislariListeleme.Location = new System.Drawing.Point(633, 38);
            this.btnSatislariListeleme.Name = "btnSatislariListeleme";
            this.btnSatislariListeleme.Size = new System.Drawing.Size(110, 35);
            this.btnSatislariListeleme.TabIndex = 4;
            this.btnSatislariListeleme.Text = "Satışları Listeleme";
            this.btnSatislariListeleme.UseVisualStyleBackColor = true;
            this.btnSatislariListeleme.Click += new System.EventHandler(this.btnSatislariListeleme_Click);
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.Location = new System.Drawing.Point(498, 38);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(107, 35);
            this.btnÜrünListeleme.TabIndex = 3;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            this.btnÜrünListeleme.Click += new System.EventHandler(this.btnÜrünListeleme_Click);
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.Location = new System.Drawing.Point(385, 38);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(107, 35);
            this.btnÜrünEkleme.TabIndex = 2;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // btnMüsteriListeleme
            // 
            this.btnMüsteriListeleme.Location = new System.Drawing.Point(190, 38);
            this.btnMüsteriListeleme.Name = "btnMüsteriListeleme";
            this.btnMüsteriListeleme.Size = new System.Drawing.Size(112, 35);
            this.btnMüsteriListeleme.TabIndex = 1;
            this.btnMüsteriListeleme.Text = "Müşteri Listeleme";
            this.btnMüsteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüsteriListeleme.Click += new System.EventHandler(this.btnMüsteriListeleme_Click);
            // 
            // btnMüsteriEkleme
            // 
            this.btnMüsteriEkleme.Location = new System.Drawing.Point(77, 38);
            this.btnMüsteriEkleme.Name = "btnMüsteriEkleme";
            this.btnMüsteriEkleme.Size = new System.Drawing.Size(107, 35);
            this.btnMüsteriEkleme.TabIndex = 0;
            this.btnMüsteriEkleme.Text = "Müşteri Ekleme ";
            this.btnMüsteriEkleme.UseVisualStyleBackColor = true;
            this.btnMüsteriEkleme.Click += new System.EventHandler(this.btnMüsteriEkleme_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1068, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnSatisİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtÜrünAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisİptal;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatislariListeleme;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnMüsteriListeleme;
        private System.Windows.Forms.Button btnMüsteriEkleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

