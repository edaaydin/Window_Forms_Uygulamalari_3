namespace _08_Etut_Login
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
            txtMail = new TextBox();
            txtPassword = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 36);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre .";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(151, 28);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(145, 23);
            txtMail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 85);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(151, 133);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(145, 41);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Giriş Yap";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
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
        private TextBox txtMail;
        private TextBox txtPassword;
        private Button btnlogin;
    }
}
