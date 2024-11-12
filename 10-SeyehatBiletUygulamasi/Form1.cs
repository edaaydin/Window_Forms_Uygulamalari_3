namespace _10_SeyehatBiletUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            grpKisiselBilgiler.Enabled = false; // kitledik kullanılamaz hale getirdik

            int araKoltuk = 3;
            int bosHazirlanacaklarIcinEklenenler = 0;
            int koridorKoltukNolari = 0;

            for (int i = 1; i <= 54 + bosHazirlanacaklarIcinEklenenler; i++)
            {
                Button button = new Button();
                button.Width = 35;

                if (i == araKoltuk)
                {
                    button.Height = 0; // Basilamaz, gorme sansi yok
                    araKoltuk += 5;
                    bosHazirlanacaklarIcinEklenenler++;
                }
                else
                {
                    button.Height = 35;
                    koridorKoltukNolari++;
                    button.Text = koridorKoltukNolari.ToString();
                    button.Tag = koridorKoltukNolari.ToString();
                    button.Click += MyClik;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                }

                flwPanel.Controls.Add(button);
            }

            Label label = new Label();
            label.Height = 35;
            label.Width = 74;
            label.BackColor = Color.DeepPink;
            label.Text = "Kapı";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(44, 2, 0, 0);
            flwPanel.Controls.Add(label);
        }

        private void MyClik(object? sender, EventArgs e)
        {
            grpKisiselBilgiler.Enabled = true;

            Button button = new Button();
            Button buton = sender as Button;
            txtKoltukNo.Text = buton.Text;
            txtKoltukNo.Enabled = false;
            secilenButon = buton;
            //if (buton != null)
            //{
            //    // Tıklanan butonun üzerindeki metni (koltuk numarasını) txtKoltukNo'ya yazıyoruz
            //    txtKoltukNo.Text = buton.Text;
            //}
        }

        Button secilenButon;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                bool isKoltuk = true;
                string cinsiyet = rdbErkek.Checked ? rdbErkek.Text : rdbKadin.Text;

                foreach (var item in flwPanel.Controls) // tum koltukları gezelim
                {
                    if (item is Button)
                    {
                        Button btn = (Button)item;

                        if (Convert.ToInt32(secilenButon.Tag) % 2 == 0) // gelen ciftse bir onceki koltuga bakalım.
                        {
                            // kendinden oncekini bul - hangi buton'un text'i secilenden 1 azsa onu bul.
                            if ((btn.Text == (Convert.ToInt32(secilenButon.Tag) - 1).ToString()))
                            {
                                if ((btn.Tag).ToString() != cinsiyet) isKoltuk = false;
                            }
                        }
                        else
                        {
                            if ((btn.Text == (Convert.ToInt32(secilenButon.Tag) - 1).ToString()))
                            {
                                if (btn.Tag.ToString() != cinsiyet && btn.Tag.GetType().Name == "Int32")
                                {
                                    isKoltuk = false;
                                }
                            }
                        }
                    }
                }

                if (isKoltuk)
                {
                    // Kullanıcı bilgilerini toparla, sonra listbox'a ekleyelim.

                    string ad = txtAd.Text;
                    string soyad = txtSoyad.Text;
                    string telefon = txtTelefon.Text;
                    string koltukNo = txtKoltukNo.Text;
                    string bilgi = $"{koltukNo} no'lu koltukta : {ad} {soyad} {cinsiyet} - Tel No : {telefon}";
                    lstSatilankoltuklar.Items.Add(bilgi);

                    // secilen buton, koltuk, kullanılamaz hale gelir.
                    secilenButon.Enabled = false;
                    secilenButon.Tag = cinsiyet; // Satilan koltuk hangi cinsiyete satildi.
                    secilenButon.BackColor = rdbErkek.Checked ? Color.Azure : Color.DeepPink;
                    string dosyaYolu = rdbErkek.Checked ? "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101\\YZL-5101-WF-Uygulama\\YZL-5101-WF-Uygulama\\10-SeyehatBiletUygulamasi\\Images\\man.png" :
                        "C:\\Users\\Bilge Adam\\source\\repos\\YZL-5101\\YZL-5101\\YZL-5101-WF-Uygulama\\YZL-5101-WF-Uygulama\\10-SeyehatBiletUygulamasi\\Images\\woman.png";

                    secilenButon.BackgroundImage = Image.FromFile(dosyaYolu);
                    grpKisiselBilgiler.Enabled = false;
                    MessageBox.Show("Yolcu Eklendi");
                }
                else MessageBox.Show("satamayız");
            }
        }
        private bool IsEmpty()
        {
            string boslar = string.Empty; // Hata Mesajım olucak.

            foreach (var item in grpKisiselBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txbox = (TextBox)item;
                    if (string.IsNullOrEmpty(txbox.Text)) // true
                    {
                        boslar += txbox.Tag + " ";
                    }
                }
            }
            // boslar stringine bakalım hala bos mu -- pozitif hata verecek
            if (!string.IsNullOrEmpty(boslar))
            {
                MessageBox.Show(boslar, "Bos birakilamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
