namespace _09_SifreBelirleme
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
            lblZorlukDerecesi = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 142);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Şifre Zorluk Derecesi";
            // 
            // lblZorlukDerecesi
            // 
            lblZorlukDerecesi.AutoSize = true;
            lblZorlukDerecesi.Location = new Point(201, 142);
            lblZorlukDerecesi.Name = "lblZorlukDerecesi";
            lblZorlukDerecesi.Size = new Size(34, 15);
            lblZorlukDerecesi.TabIndex = 1;
            lblZorlukDerecesi.Text = ".........";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(60, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 267);
            Controls.Add(txtPassword);
            Controls.Add(lblZorlukDerecesi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblZorlukDerecesi;
        private TextBox txtPassword;
    }
}
