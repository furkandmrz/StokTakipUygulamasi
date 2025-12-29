namespace StokTakipUygulaması
{
    partial class KullanıcıOluştur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıOluştur));
            KayıtOlButon = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labell = new Label();
            txtTelefon = new TextBox();
            txtKullanıcıAdı = new TextBox();
            txtSoyadı = new TextBox();
            txtAdı = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // KayıtOlButon
            // 
            KayıtOlButon.BackColor = SystemColors.ActiveCaption;
            KayıtOlButon.Location = new Point(283, 249);
            KayıtOlButon.Name = "KayıtOlButon";
            KayıtOlButon.Size = new Size(75, 23);
            KayıtOlButon.TabIndex = 0;
            KayıtOlButon.Text = "Kayıt Ol";
            KayıtOlButon.UseVisualStyleBackColor = false;
            KayıtOlButon.Click += KayıtOlButon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 54);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 86);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyadı";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 118);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 152);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefon No";
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Location = new Point(112, 183);
            labell.Name = "labell";
            labell.Size = new Size(39, 15);
            labell.TabIndex = 5;
            labell.Text = "Email ";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(241, 152);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(173, 23);
            txtTelefon.TabIndex = 6;
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(241, 118);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(173, 23);
            txtKullanıcıAdı.TabIndex = 7;
            // 
            // txtSoyadı
            // 
            txtSoyadı.Location = new Point(241, 86);
            txtSoyadı.Name = "txtSoyadı";
            txtSoyadı.Size = new Size(173, 23);
            txtSoyadı.TabIndex = 8;
            // 
            // txtAdı
            // 
            txtAdı.Location = new Point(241, 54);
            txtAdı.Name = "txtAdı";
            txtAdı.Size = new Size(173, 23);
            txtAdı.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(241, 220);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(173, 23);
            txtSifre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 220);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "Şifre";
            // 
            // KullanıcıOluştur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(606, 450);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtAdı);
            Controls.Add(txtSoyadı);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(txtTelefon);
            Controls.Add(labell);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KayıtOlButon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KullanıcıOluştur";
            Text = "KullanıcıOluştur";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KayıtOlButon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labell;
        private TextBox txtTelefon;
        private TextBox txtKullanıcıAdı;
        private TextBox txtSoyadı;
        private TextBox txtAdı;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label5;
    }
}