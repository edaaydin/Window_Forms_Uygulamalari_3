namespace _09_SifreBelirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            lblZorlukDerecesi.Text = ZorlukDerecesi(password); // Metot olusturduk ve metodu cagırıp calıstırdık.
        }
        private string ZorlukDerecesi(string password)
        {
            // Düsük seviye
            if (password.Length <= 6 || password.All(char.IsDigit) || password.All(char.IsLetter))
            {
                lblZorlukDerecesi.ForeColor = Color.Red;
                return "Dusuk";
            }
            // Orta seviye
            if (password.Length == 7 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblZorlukDerecesi.ForeColor = Color.Orange;
                return "Orta";
            }

            // Yüksek seviye
            if (password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblZorlukDerecesi.ForeColor = Color.Green;
                return "Yüksek";
            }
            return "Dusuk";
        }
    }
}
/*
 *Yukarıdaki textbox’a yazılan şifrenin zorluk derecesi belirlenmelidir. Kurallar şöyledir:
• Şifre 6 veya daha az karakter ise ➔ düşük
• Sadece rakamlardan oluşuyorsa veya sadece harflerden oluşuyorsa ➔ düşük
• Şifre 7 karakter, hem rakamlardan hem de harflerden oluşuyorsa ➔ orta
• Şifre en az 8 karakter ise, hem rakamlardan, hem de harflerden oluşuyorsa ➔ yüksek
• Düşük seviye kırmızı, orta seviye turuncu, yüksek seviye de yeşil renkte yazılmalıdır.
NOT: Zorluk derecesinin belirlenmesi textbox’ın “TextChanged” olayında yapılmalıdır.
*/
