using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunu.PlanlamaOyunu
{
    public partial class Kayit : Form
    {
        BusinessLogicLayer.BLL bll;
        public Kayit()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            int returnValue = bll.KayitEkle(txbAd.Text, txbSoyad.Text, txbKullaniciAdi.Text, txbSifre.Text, txbEmail.Text, mtxbTcno.Text, txbAdres.Text, mtxbTel.Text, txbTip.Text);
            if (returnValue > 0)
            {
                MessageBox.Show("Kayit Başarılı: " + txbKullaniciAdi.Text);
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.");
            }
        }

        private void Kayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
