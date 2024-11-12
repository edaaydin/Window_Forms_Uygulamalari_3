namespace _02_KisiBilgileriMaasHesabi
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
            groupBox1 = new GroupBox();
            rbSingle = new RadioButton();
            rbMarried = new RadioButton();
            grpChildren = new GroupBox();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            rb0 = new RadioButton();
            grpLanguages = new GroupBox();
            chkYn = new CheckBox();
            chkİta = new CheckBox();
            chkFr = new CheckBox();
            chkDe = new CheckBox();
            chkEng = new CheckBox();
            txtSalary = new TextBox();
            btnCalculate = new Button();
            lblNewSalary = new Label();
            groupBox1.SuspendLayout();
            grpChildren.SuspendLayout();
            grpLanguages.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSingle);
            groupBox1.Controls.Add(rbMarried);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medeni Hal";
          
            // 
            // rbSingle
            // 
            rbSingle.AutoSize = true;
            rbSingle.Location = new Point(67, 98);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new Size(54, 19);
            rbSingle.TabIndex = 1;
            rbSingle.TabStop = true;
            rbSingle.Text = "Bekar";
            rbSingle.UseVisualStyleBackColor = true;
            rbSingle.CheckedChanged += rbSingle_CheckedChanged;
            // 
            // rbMarried
            // 
            rbMarried.AutoSize = true;
            rbMarried.Location = new Point(68, 62);
            rbMarried.Name = "rbMarried";
            rbMarried.Size = new Size(43, 19);
            rbMarried.TabIndex = 0;
            rbMarried.TabStop = true;
            rbMarried.Text = "Evli";
            rbMarried.UseVisualStyleBackColor = true;
            rbMarried.CheckedChanged += rbMarried_CheckedChanged;
            // 
            // grpChildren
            // 
            grpChildren.Controls.Add(rb3);
            grpChildren.Controls.Add(rb2);
            grpChildren.Controls.Add(rb1);
            grpChildren.Controls.Add(rb0);
            grpChildren.Location = new Point(12, 207);
            grpChildren.Name = "grpChildren";
            grpChildren.Size = new Size(184, 176);
            grpChildren.TabIndex = 1;
            grpChildren.TabStop = false;
            grpChildren.Text = "Çocuk Sayısı";
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(27, 143);
            rb3.Name = "rb3";
            rb3.Size = new Size(31, 19);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(27, 104);
            rb2.Name = "rb2";
            rb2.Size = new Size(31, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(27, 67);
            rb1.Name = "rb1";
            rb1.Size = new Size(31, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            rb0.AutoSize = true;
            rb0.Location = new Point(27, 31);
            rb0.Name = "rb0";
            rb0.Size = new Size(31, 19);
            rb0.TabIndex = 0;
            rb0.TabStop = true;
            rb0.Text = "0";
            rb0.UseVisualStyleBackColor = true;
            // 
            // grpLanguages
            // 
            grpLanguages.Controls.Add(chkYn);
            grpLanguages.Controls.Add(chkİta);
            grpLanguages.Controls.Add(chkFr);
            grpLanguages.Controls.Add(chkDe);
            grpLanguages.Controls.Add(chkEng);
            grpLanguages.Location = new Point(245, 29);
            grpLanguages.Name = "grpLanguages";
            grpLanguages.Size = new Size(200, 264);
            grpLanguages.TabIndex = 2;
            grpLanguages.TabStop = false;
            grpLanguages.Text = "Bildiği Diller";
            // 
            // chkYn
            // 
            chkYn.AutoSize = true;
            chkYn.Location = new Point(46, 210);
            chkYn.Name = "chkYn";
            chkYn.Size = new Size(72, 19);
            chkYn.TabIndex = 4;
            chkYn.Text = "Yunanca";
            chkYn.UseVisualStyleBackColor = true;
            // 
            // chkİta
            // 
            chkİta.AutoSize = true;
            chkİta.Location = new Point(48, 167);
            chkİta.Name = "chkİta";
            chkİta.Size = new Size(73, 19);
            chkİta.TabIndex = 3;
            chkİta.Text = "İtalyanca";
            chkİta.UseVisualStyleBackColor = true;
            // 
            // chkFr
            // 
            chkFr.AutoSize = true;
            chkFr.Location = new Point(46, 126);
            chkFr.Name = "chkFr";
            chkFr.Size = new Size(74, 19);
            chkFr.TabIndex = 2;
            chkFr.Text = "Fransızca";
            chkFr.UseVisualStyleBackColor = true;
            // 
            // chkDe
            // 
            chkDe.AutoSize = true;
            chkDe.Location = new Point(45, 82);
            chkDe.Name = "chkDe";
            chkDe.Size = new Size(73, 19);
            chkDe.TabIndex = 1;
            chkDe.Text = "Almanca";
            chkDe.UseVisualStyleBackColor = true;
            // 
            // chkEng
            // 
            chkEng.AutoSize = true;
            chkEng.Location = new Point(46, 45);
            chkEng.Name = "chkEng";
            chkEng.Size = new Size(69, 19);
            chkEng.TabIndex = 0;
            chkEng.Text = "İngilizce";
            chkEng.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(245, 310);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Maas";
            txtSalary.Size = new Size(200, 23);
            txtSalary.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(245, 360);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblNewSalary
            // 
            lblNewSalary.AutoSize = true;
            lblNewSalary.Location = new Point(245, 412);
            lblNewSalary.Name = "lblNewSalary";
            lblNewSalary.Size = new Size(60, 15);
            lblNewSalary.TabIndex = 5;
            lblNewSalary.Text = "Yeni Maaş";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 488);
            Controls.Add(lblNewSalary);
            Controls.Add(btnCalculate);
            Controls.Add(txtSalary);
            Controls.Add(grpLanguages);
            Controls.Add(grpChildren);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpChildren.ResumeLayout(false);
            grpChildren.PerformLayout();
            grpLanguages.ResumeLayout(false);
            grpLanguages.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbSingle;
        private RadioButton rbMarried;
        private GroupBox grpChildren;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private RadioButton rb0;
        private GroupBox grpLanguages;
        private CheckBox chkYn;
        private CheckBox chkİta;
        private CheckBox chkFr;
        private CheckBox chkDe;
        private CheckBox chkEng;
        private TextBox txtSalary;
        private Button btnCalculate;
        private Label lblNewSalary;
    }
}
