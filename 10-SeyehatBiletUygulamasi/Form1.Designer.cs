namespace _10_SeyehatBiletUygulamasi
{
    partial class Form1
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
            grpKisiselBilgiler = new GroupBox();
            btnKaydet = new Button();
            rdbKadin = new RadioButton();
            rdbErkek = new RadioButton();
            txtKoltukNo = new TextBox();
            txtTelefon = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flwPanel = new FlowLayoutPanel();
            lstSatilankoltuklar = new ListBox();
            grpKisiselBilgiler.SuspendLayout();
            SuspendLayout();
            // 
            // grpKisiselBilgiler
            // 
            grpKisiselBilgiler.Controls.Add(btnKaydet);
            grpKisiselBilgiler.Controls.Add(rdbKadin);
            grpKisiselBilgiler.Controls.Add(rdbErkek);
            grpKisiselBilgiler.Controls.Add(txtKoltukNo);
            grpKisiselBilgiler.Controls.Add(txtTelefon);
            grpKisiselBilgiler.Controls.Add(txtAd);
            grpKisiselBilgiler.Controls.Add(txtSoyad);
            grpKisiselBilgiler.Controls.Add(label5);
            grpKisiselBilgiler.Controls.Add(label4);
            grpKisiselBilgiler.Controls.Add(label3);
            grpKisiselBilgiler.Controls.Add(label2);
            grpKisiselBilgiler.Controls.Add(label1);
            grpKisiselBilgiler.Location = new Point(364, 24);
            grpKisiselBilgiler.Name = "grpKisiselBilgiler";
            grpKisiselBilgiler.Size = new Size(318, 327);
            grpKisiselBilgiler.TabIndex = 0;
            grpKisiselBilgiler.TabStop = false;
            grpKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(141, 247);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 37);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Checked = true;
            rdbKadin.Location = new Point(200, 208);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 2;
            rdbKadin.TabStop = true;
            rdbKadin.Tag = "Kadın";
            rdbKadin.Text = "Kadın";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(141, 208);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 2;
            rdbErkek.Tag = "Erkek";
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // txtKoltukNo
            // 
            txtKoltukNo.Location = new Point(141, 161);
            txtKoltukNo.Name = "txtKoltukNo";
            txtKoltukNo.Size = new Size(100, 23);
            txtKoltukNo.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(141, 117);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 1;
            txtTelefon.Tag = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(141, 34);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            txtAd.Tag = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(141, 78);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            txtSoyad.Tag = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 169);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Koltuk No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 212);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 125);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 86);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // flwPanel
            // 
            flwPanel.Location = new Point(38, 24);
            flwPanel.Name = "flwPanel";
            flwPanel.Size = new Size(230, 650);
            flwPanel.TabIndex = 1;
            // 
            // lstSatilankoltuklar
            // 
            lstSatilankoltuklar.FormattingEnabled = true;
            lstSatilankoltuklar.ItemHeight = 15;
            lstSatilankoltuklar.Location = new Point(364, 440);
            lstSatilankoltuklar.Name = "lstSatilankoltuklar";
            lstSatilankoltuklar.Size = new Size(318, 304);
            lstSatilankoltuklar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 770);
            Controls.Add(lstSatilankoltuklar);
            Controls.Add(flwPanel);
            Controls.Add(grpKisiselBilgiler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpKisiselBilgiler.ResumeLayout(false);
            grpKisiselBilgiler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKisiselBilgiler;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flwPanel;
        private ListBox lstSatilankoltuklar;
        private TextBox textBox4;
        private TextBox txtTelefon;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private TextBox txtKoltukNo;
        private Button btnKaydet;
    }
}
