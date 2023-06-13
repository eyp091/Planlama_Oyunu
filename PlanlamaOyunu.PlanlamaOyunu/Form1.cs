namespace PlanlamaOyunu.PlanlamaOyunu
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.PerformClick();
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            int returnValues = bll.sistemKontrol(txbKullaniciAdi.Text, txbSifre.Text);
            if (returnValues > 0)
            {
                Takvim takvim = new Takvim();
                takvim.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý giriþ");
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }
    }
}