
namespace StokTakipUygulaması
{
    partial class ÜrünEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünEkle));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtMarka = new TextBox();
            txtBarkod = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtSkt = new DateTimePicker();
            txtFiyat = new NumericUpDown();
            txtAdet = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 314);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Ekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 83);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "İsmi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Marka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "SKTT bilgisi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 181);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Barkod No";
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 6;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(301, 117);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(156, 23);
            txtMarka.TabIndex = 8;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(301, 181);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(156, 23);
            txtBarkod.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 219);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "Adet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 259);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 13;
            label7.Text = "Fiyat";
            // 
            // txtSkt
            // 
            txtSkt.Location = new Point(301, 149);
            txtSkt.Name = "txtSkt";
            txtSkt.Size = new Size(156, 23);
            txtSkt.TabIndex = 14;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(305, 257);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(152, 23);
            txtFiyat.TabIndex = 15;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(305, 221);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(152, 23);
            txtAdet.TabIndex = 16;
            // 
            // ÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(txtAdet);
            Controls.Add(txtFiyat);
            Controls.Add(txtSkt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtBarkod);
            Controls.Add(txtMarka);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ÜrünEkle";
            Text = "ÜrünEkle";
            ((System.ComponentModel.ISupportInitialize)txtFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtMarka;
        private TextBox txtBarkod;
        private Label label6;
        private Label label7;
        public Button button1;
        private DateTimePicker txtSkt;
        private NumericUpDown txtFiyat;
        private NumericUpDown txtAdet;
    }
}