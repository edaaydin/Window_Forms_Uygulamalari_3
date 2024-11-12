namespace _01_TutarHesapla
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
            grpDiscount = new GroupBox();
            chkSpecialDiscount = new CheckBox();
            chkCampaignDiscount = new CheckBox();
            chkCashDiscount = new CheckBox();
            grpHesaplama = new GroupBox();
            btnCalculate = new Button();
            txtPrice = new TextBox();
            label1 = new Label();
            grpDiscount.SuspendLayout();
            grpHesaplama.SuspendLayout();
            SuspendLayout();
            // 
            // grpDiscount
            // 
            grpDiscount.Controls.Add(chkSpecialDiscount);
            grpDiscount.Controls.Add(chkCampaignDiscount);
            grpDiscount.Controls.Add(chkCashDiscount);
            grpDiscount.Location = new Point(12, 12);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(181, 222);
            grpDiscount.TabIndex = 0;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "İndirimler";
            // 
            // chkSpecialDiscount
            // 
            chkSpecialDiscount.AutoSize = true;
            chkSpecialDiscount.Location = new Point(23, 107);
            chkSpecialDiscount.Name = "chkSpecialDiscount";
            chkSpecialDiscount.Size = new Size(115, 19);
            chkSpecialDiscount.TabIndex = 2;
            chkSpecialDiscount.Text = "%10 Özel İndirim";
            chkSpecialDiscount.UseVisualStyleBackColor = true;
            // 
            // chkCampaignDiscount
            // 
            chkCampaignDiscount.AutoSize = true;
            chkCampaignDiscount.Location = new Point(23, 71);
            chkCampaignDiscount.Name = "chkCampaignDiscount";
            chkCampaignDiscount.Size = new Size(151, 19);
            chkCampaignDiscount.TabIndex = 1;
            chkCampaignDiscount.Text = "%10 Kampanya İndirimi\r\n";
            chkCampaignDiscount.UseVisualStyleBackColor = true;
            // 
            // chkCashDiscount
            // 
            chkCashDiscount.AutoSize = true;
            chkCashDiscount.Location = new Point(23, 34);
            chkCashDiscount.Name = "chkCashDiscount";
            chkCashDiscount.Size = new Size(114, 19);
            chkCashDiscount.TabIndex = 0;
            chkCashDiscount.Text = "%5 Nakit İndirim";
            chkCashDiscount.UseVisualStyleBackColor = true;
            // 
            // grpHesaplama
            // 
            grpHesaplama.Controls.Add(btnCalculate);
            grpHesaplama.Controls.Add(txtPrice);
            grpHesaplama.Controls.Add(label1);
            grpHesaplama.Location = new Point(261, 12);
            grpHesaplama.Name = "grpHesaplama";
            grpHesaplama.Size = new Size(196, 222);
            grpHesaplama.TabIndex = 1;
            grpHesaplama.TabStop = false;
            grpHesaplama.Text = "Hesaplama";
            grpHesaplama.Enter += grpHesaplama_Enter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(38, 107);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(116, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(69, 50);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Tutar :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 304);
            Controls.Add(grpHesaplama);
            Controls.Add(grpDiscount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpDiscount.ResumeLayout(false);
            grpDiscount.PerformLayout();
            grpHesaplama.ResumeLayout(false);
            grpHesaplama.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDiscount;
        private CheckBox chkSpecialDiscount;
        private CheckBox chkCampaignDiscount;
        private CheckBox chkCashDiscount;
        private GroupBox grpHesaplama;
        private Button btnCalculate;
        private TextBox txtPrice;
        private Label label1;
    }
}
