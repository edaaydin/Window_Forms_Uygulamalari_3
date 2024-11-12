namespace _05_FormlarArasiGecis
{
    partial class Form2
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
            label1 = new Label();
            lblAdSoyad = new Label();
            label2 = new Label();
            label3 = new Label();
            lblOrtalama = new Label();
            lblDurum = new Label();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 70);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad ve Soyad :";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(179, 70);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(37, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "..........";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 118);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Sınav Ortalaması :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 161);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Geçme Durumu :";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(179, 118);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(37, 15);
            lblOrtalama.TabIndex = 1;
            lblOrtalama.Text = "..........";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(179, 161);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(37, 15);
            lblDurum.TabIndex = 1;
            lblDurum.Text = "..........";
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(117, 208);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(99, 34);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 336);
            Controls.Add(btnKapat);
            Controls.Add(lblDurum);
            Controls.Add(lblOrtalama);
            Controls.Add(lblAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKapat;
        public Label lblAdSoyad;
        public Label lblOrtalama;
        public Label lblDurum;
    }
}