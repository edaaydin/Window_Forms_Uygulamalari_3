namespace _02_KisiBilgileriMaasHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //form açıldığında bekar seçili gelsin ve cocuk sayısı grupbox1 kullanılmaz olarak gelsin.TAMAMLANDI
            // evli secildiyse cocuk sayısı grupbox kullanılabilir olsun fakat tekrar bekar secilirse kapansın TAMAMLANDI
            // evli seciliyse %3, bekar  seciliyse %2 maas artısı
            // her cocuk için %2 maas artısı hesaplansın.
            //textboxa yazılan deger ondalıklı sayıya cevriliyorsa try-catch olmadan metotla yap güncel zamlı maas labela basılsın.
            // textbox boş oldugunda yada cevrilen deger yazilmadiginda hata mesajı verilsin.

            rbSingle.Checked = true; // default bekar gelsin,
        }
        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            grpChildren.Enabled = false;  // Her bekar secildiginde cocuk sayisi grubu kapali gelsin.
        }
        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {
            grpChildren.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal maas;
            bool salary = Decimal.TryParse(txtSalary.Text, out maas);

            if (!salary)
            {
                MessageBox.Show("Lütfen geçerli bir maaş değeri giriniz.");
                return;
            }
            decimal maasArtisi = 0;

            // cocukSayisi değeri artık RadioButton'lara göre belirlendi

            if (rbSingle.Checked)
            {
                maasArtisi = 0.02m;
            }
            else
            {
                maasArtisi = 0.03m;
            }

            int cocukSayisi = 0;

            if (rb0.Checked)
            {
                cocukSayisi = 0; // Eğer rb0 seçiliyse, çocuk sayısı 0
            }
            else if (rb1.Checked)
            {
                cocukSayisi = 1; // Eğer rb1 seçiliyse, çocuk sayısı 1
            }
            else if (rb2.Checked)
            {
                cocukSayisi = 2; // Eğer rb2 seçiliyse, çocuk sayısı 2
            }
            else if (rb3.Checked)
            {
                cocukSayisi = 3; // Eğer rb3 seçiliyse, çocuk sayısı 3
            }
            maasArtisi += cocukSayisi * 0.02m;

            decimal zamliMaas = maas * (1 + maasArtisi);
            MessageBox.Show($"Maasiniz : {zamliMaas} ");
        }
    }
}
