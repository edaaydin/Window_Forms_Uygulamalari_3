namespace _07_Etut_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cmbData.Items.Add(txtData.Text);
            lstData.Items.Add(txtData.Text);
        }

        private void btnSecme_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ListBox) (item as ListBox).SelectedIndex = -1;
                if (item is ComboBox) (item as ComboBox).SelectedIndex = -1;

            }
        }
        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstData.SelectedIndex > -1)
            {
                MessageBox.Show(lstData.SelectedItem.ToString());
            }
        }

        private void cmbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbData.SelectedIndex > -1)
            {
                MessageBox.Show(cmbData.SelectedItem.ToString());
            }
        }
    }
}
