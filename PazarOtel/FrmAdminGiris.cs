namespace PazarOtel
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "12345") 
            {
                FrmAnaForm fr=new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
              MessageBox.Show("Kullanýcý Adý veya Þifre Yanlýþ");
            }
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 