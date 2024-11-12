namespace _06_RenkVer
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
            cmbColors = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbColors
            // 
            cmbColors.FormattingEnabled = true;
            cmbColors.Location = new Point(38, 45);
            cmbColors.Name = "cmbColors";
            cmbColors.Size = new Size(248, 23);
            cmbColors.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(38, 90);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(121, 32);
            btnOk.TabIndex = 1;
            btnOk.Tag = "1";
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;

            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(165, 90);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Tag = "2";
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 179);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cmbColors);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbColors;
        private Button btnOk;
        private Button btnCancel;
    }
}