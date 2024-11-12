namespace _07_Etut_ComboBox
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
            btnEkle = new Button();
            txtData = new TextBox();
            cmbData = new ComboBox();
            lstData = new ListBox();
            btnSecme = new Button();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(207, 43);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(96, 23);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(41, 43);
            txtData.Name = "txtData";
            txtData.Size = new Size(135, 23);
            txtData.TabIndex = 1;
            // 
            // cmbData
            // 
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(41, 91);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(135, 23);
            cmbData.TabIndex = 2;
            cmbData.SelectedIndexChanged += cmbData_SelectedIndexChanged;
            // 
            // lstData
            // 
            lstData.FormattingEnabled = true;
            lstData.ItemHeight = 15;
            lstData.Location = new Point(41, 135);
            lstData.Name = "lstData";
            lstData.Size = new Size(135, 154);
            lstData.TabIndex = 3;
            lstData.SelectedIndexChanged += lstData_SelectedIndexChanged;
            // 
            // btnSecme
            // 
            btnSecme.Location = new Point(207, 135);
            btnSecme.Name = "btnSecme";
            btnSecme.Size = new Size(112, 74);
            btnSecme.TabIndex = 4;
            btnSecme.Text = "Seçme";
            btnSecme.UseVisualStyleBackColor = true;
            btnSecme.Click += btnSecme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 401);
            Controls.Add(btnSecme);
            Controls.Add(lstData);
            Controls.Add(cmbData);
            Controls.Add(txtData);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtData;
        private ComboBox cmbData;
        private ListBox lstData;
        private Button btnSecme;
    }
}
