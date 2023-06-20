using PlanlamaOyunu.Entities;
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
    public partial class PlanDuzenle : Form
    {
        int planId;
        string eTarih;
        string eBaslangicZamani;
        string eBitisZamani;
        string eTip;
        string eAciklama;
        string eAlarm;

        public PlanDuzenle(Planlar eskiPlan)
        {
            InitializeComponent();
            this.eTarih = eskiPlan.islemZamani;
            this.eBaslangicZamani = eskiPlan.baslangicZamani;
            this.eBitisZamani = eskiPlan.bitisZamani;
            this.eTip = eskiPlan.tip;
            this.eAciklama = eskiPlan.aciklama;
            this.eAlarm = eskiPlan.alarm;
            this.planId = eskiPlan.planID;

            mtbYeniTarih.Text = eskiPlan.islemZamani;
            mtbBaslangic.Text = eskiPlan.baslangicZamani;
            mtbBitis.Text = eskiPlan.bitisZamani;
            txbTip.Text = eskiPlan.tip;
            rtbAciklama.Text = eskiPlan.aciklama;
            cmbAlarm.Text = eskiPlan.alarm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            int returnValue = bll.planDuzenle(planId, mtbYeniTarih.Text, mtbBaslangic.Text, mtbBitis.Text, txbTip.Text, rtbAciklama.Text, cmbAlarm.Text);
            if (returnValue > 0)
            {
                MessageBox.Show("Düzenleme başarılı.");
            }
            else
            {
                MessageBox.Show("Düzenleme sırasında bir hata oldu.");
            }
        }
    }
}
