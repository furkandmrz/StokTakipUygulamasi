namespace StokTakipUygulaması
{
    partial class ÜrünListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünListele));
            urunListesi = new DataGridView();
            button1 = new Button();
            StokEksilt = new Button();
            StokArttır = new Button();
            ((System.ComponentModel.ISupportInitialize)urunListesi).BeginInit();
            SuspendLayout();
            // 
            // urunListesi
            // 
            urunListesi.BackgroundColor = SystemColors.ActiveBorder;
            urunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunListesi.Location = new Point(0, 1);
            urunListesi.Name = "urunListesi";
            urunListesi.Size = new Size(744, 302);
            urunListesi.TabIndex = 0;
            urunListesi.CellContentClick += urunListesi_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(502, 309);
            button1.Name = "button1";
            button1.Size = new Size(117, 30);
            button1.TabIndex = 1;
            button1.Text = "Ürün Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StokEksilt
            // 
            StokEksilt.BackColor = SystemColors.ActiveCaption;
            StokEksilt.Location = new Point(87, 309);
            StokEksilt.Name = "StokEksilt";
            StokEksilt.Size = new Size(117, 30);
            StokEksilt.TabIndex = 2;
            StokEksilt.Text = "Stok Eksilt";
            StokEksilt.UseVisualStyleBackColor = false;
            StokEksilt.Click += StokEksilt_Click;
            // 
            // StokArttır
            // 
            StokArttır.BackColor = SystemColors.ActiveCaption;
            StokArttır.Location = new Point(298, 309);
            StokArttır.Name = "StokArttır";
            StokArttır.Size = new Size(117, 30);
            StokArttır.TabIndex = 3;
            StokArttır.Text = "Stok Arttır";
            StokArttır.UseVisualStyleBackColor = false;
            StokArttır.Click += button2_Click;
            // 
            // ÜrünListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(745, 342);
            Controls.Add(StokArttır);
            Controls.Add(StokEksilt);
            Controls.Add(button1);
            Controls.Add(urunListesi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÜrünListele";
            Text = "Ürün Listesi";
            Load += ÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)urunListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView urunListesi;
        private Button button1;
        private Button StokEksilt;
        private Button StokArttır;
    }
}