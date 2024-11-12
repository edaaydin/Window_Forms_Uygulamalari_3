namespace _05_FormlarArasiGecis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNameSurname = new TextBox();
            txtSinav1 = new TextBox();
            txtSinav2 = new TextBox();
            txtSinav3 = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı ve Soyadı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Sınav Notu 1 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Sınav Notu 2 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 186);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Sınav Notu 3 :";
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(159, 62);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(100, 23);
            txtNameSurname.TabIndex = 4;
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(159, 101);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(100, 23);
            txtSinav1.TabIndex = 4;
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(159, 141);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(100, 23);
            txtSinav2.TabIndex = 4;
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(159, 178);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(100, 23);
            txtSinav3.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(159, 207);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(100, 40);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 303);
            Controls.Add(btnHesapla);
            Controls.Add(txtSinav3);
            Controls.Add(txtSinav2);
            Controls.Add(txtSinav1);
            Controls.Add(txtNameSurname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNameSurname;
        private TextBox txtSinav1;
        private TextBox txtSinav2;
        private TextBox txtSinav3;
        private Button btnHesapla;
    }
}
