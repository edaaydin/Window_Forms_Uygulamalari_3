namespace _01_TutarHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Kullanicinin yazdigi degeri oku
            string strCost = txtPrice.Text;
            double price = 0, disc1 = 0, disc2 = 0, disc3 = 0;

            bool cashDiscount = chkCashDiscount.Checked,
                campaignCount = chkCampaignDiscount.Checked,
                specialDiscount = chkSpecialDiscount.Checked;
            try
            {
                // Hata olması muhtemel kodlar.
                double cost = double.Parse(strCost);
                disc1 = cashDiscount ? 0.05 : 0;
                disc2 = campaignCount ? 0.1 : 0;
                disc3 = specialDiscount ? 0.1 : 0;

                double totalDiscount = disc1 + disc2 + disc3;
                price = cost * (1 - totalDiscount);
                MessageBox.Show($"Odemeniz gereken tutar : {price} ");
            }
            catch (Exception ex)
            {
                // Hata alındıgında calisacak kod bloglari burada yazilir.
                MessageBox.Show("Hatali islem yaptiniz !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grpHesaplama_Enter(object sender, EventArgs e)
        {

        }
    }
}
