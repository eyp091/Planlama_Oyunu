using Microsoft.VisualBasic;
using PlanlamaOyunu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunu.PlanlamaOyunu
{
    public partial class Takvim : Form
    {
        private string kullaniciAdi;
        private int planID;
        private List<Planlar> secilenTarihler;
        Planlar secilenPlan = new Planlar();

        public Takvim(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

        public Takvim()
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            PlanOlustur planOlustur = new PlanOlustur(selectedDate, kullaniciAdi);
            planOlustur.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Takvim_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<string> bilgiListesi = bll.bilgiListele(kullaniciAdi);


            lblAd.Text = bilgiListesi[0].ToString();
            lblSoyad.Text = bilgiListesi[1].ToString();
            lblKullaniciAdi.Text = bilgiListesi[2].ToString();
            lblTip.Text = bilgiListesi[3].ToString();

            listeDoldur();
        }

        internal void listeDoldur()
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Planlar> planListesi = bll.planListele(kullaniciAdi);
            if (planListesi != null && planListesi.Count > 0)
            {
                lbTarihler.DataSource = planListesi;
                secilenTarihler = planListesi;

            }
        }

        private void lbTarihler_DoubleClick(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Planlar secilenPlan = (Planlar)lst.SelectedItem;
            if (secilenPlan != null)
            {
                lbPlanlar.Items.Add("Plan Id: " + secilenPlan.planID + " : " + secilenPlan.islemZamani + " : " + secilenPlan.baslangicZamani + " : " + secilenPlan.bitisZamani + " : " +
                    secilenPlan.tip + " : " + secilenPlan.aciklama + " : " + secilenPlan.alarm);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (secilenPlan != null)
            {
                PlanDuzenle planDuzenle = new PlanDuzenle(secilenPlan);
                planDuzenle.Show();

            }
        }

        private void lbTarihler_Click(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Planlar plan = (Planlar)lst.SelectedItem;
            secilenPlan = plan;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (secilenPlan != null)
            {
                BusinessLogicLayer.BLL bLL = new BusinessLogicLayer.BLL();
                int returnValue = bLL.planSil(secilenPlan.planID);
                if (returnValue > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbPlanlar.Items.Clear();
            lbTarihler.Refresh();
            listeDoldur();
        }
    }
}
