using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_RenkVer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbColors.Items.AddRange(new object[]
            {
                Color.AliceBlue,
                Color.Blue,
                Color.Green,
                Color.Red,
                Color.Magenta,
                Color.Yellow,
                Color.Purple,
                Color.Orange,
                Color.Orchid,
                Color.Pink,
                Color.Purple,
            });

            btnOk.Click += MyClick;
            btnCancel.Click += MyClick;

        }
        public Color ChosingColor { get; set; }

        private void MyClick(object sender, EventArgs e)
        {
            // tamam-iptal butonuna ata

            Button button = sender as Button;
            object tag = button.Tag; // 1 ? 2 ?

            switch (tag)
            {
                case "1":
                    if (cmbColors.SelectedIndex != -1) // cmbden secim yapıldıysa
                    {
                        ChosingColor = (Color)cmbColors.SelectedItem;

                    }
                    DialogResult = DialogResult.OK;
                    break;

                case "2":
                    DialogResult = DialogResult.Cancel;
                    break;



            }
        }


    }
}

