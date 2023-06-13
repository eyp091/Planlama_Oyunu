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
        BusinessLogicLayer.BLL bll;
        YeniPlanlar yeniPlanlar = new YeniPlanlar();
        public PlanOlustur(DateTime selectedDate)
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
            this.selectedDate = selectedDate;
            lblTarih.Text = selectedDate.ToShortDateString();
            lblTarih.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniPlanlar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int returnValue = bll.planEkle("eypcnd", selectedDate.ToShortDateString(), mtbBaslangic.Text, mtbBitis.Text, txbTip.Text, rtbAciklama.Text);
            if (returnValue > 0)
            {
                
                MessageBox.Show("Plan Oluşturuldu.","Bilgilendirme");
                
             
            }
            else
            {
                MessageBox.Show("Plan oluştururken hata oluştu.","Bilgilendirme");
            }
        }
    }
}
