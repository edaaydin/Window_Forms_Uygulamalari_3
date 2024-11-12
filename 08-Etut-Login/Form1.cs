namespace _08_Etut_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // string[] dizi = txtMail.Text.Split('@', '.'); // parcalama islemi yapar.

            if (MailandpasswordControl(txtMail.Text, txtPassword.Text))
                MessageBox.Show("Başarılı");
            else
                MessageBox.Show("Başarısız");

        }

        private bool MailandpasswordControl(string mail, string pass)
        {
            if (mail.EndsWith("@ank10") && mail.Split('@', '.')[1] + mail.Split('@', '.')[0] == pass) return true;
            else return false;
        }
    }
}
