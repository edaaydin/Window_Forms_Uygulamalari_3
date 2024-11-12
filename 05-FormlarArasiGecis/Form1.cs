namespace _05_FormlarArasiGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string adSoyad = txtNameSurname.Text;
            double exam1 = Convert.ToDouble(txtSinav1.Text);
            double exam2 = Convert.ToDouble(txtSinav2.Text);
            double exam3 = Convert.ToDouble(txtSinav3.Text);

            double average = (exam1 + exam2 + exam3) / 3;

            string message = average >= 50 ? "Geçti" : "Kaldı";

            Form2 frm2 = new Form2();
            frm2.lblAdSoyad.Text = adSoyad;
            frm2.lblOrtalama.Text = average.ToString();
            frm2.lblDurum.Text = message;
            frm2.Show();
        }
    }
}
