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
    public partial class PlanOlustur : Form
    {
        private DateTime selectedDate;
        private string kullaniciAdi;
        BusinessLogicLayer.BLL bll;
        Takvim takvim = new Takvim();

        public PlanOlustur(DateTime selectedDate, string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
            bll = new BusinessLogicLayer.BLL();
            this.selectedDate = selectedDate;
            lblTarih.Text = selectedDate.ToShortDateString();
            lblTarih.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int returnValue = bll.planEkle(kullaniciAdi, selectedDate.ToShortDateString(), mtbBaslangic.Text, mtbBitis.Text, txbTip.Text, rtbAciklama.Text, cmbAlarm.Text);
            if (returnValue > 0)
            {
                
                MessageBox.Show("Plan Oluşturuldu.","Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Plan oluştururken hata oluştu.","Bilgilendirme");
            }
            takvim.listeDoldur();
        }
    }
}
