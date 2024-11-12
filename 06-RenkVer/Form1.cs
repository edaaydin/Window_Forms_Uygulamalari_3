namespace _06_RenkVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Renk secmk icin form2'yi ac.
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                BackColor = frm2.ChosingColor;
            }
            else
            {
                BackColor = DefaultBackColor;                                                                                       
            }

        }
    }
}
