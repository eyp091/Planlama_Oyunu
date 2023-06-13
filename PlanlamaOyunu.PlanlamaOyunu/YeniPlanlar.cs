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
    public partial class YeniPlanlar : Form
    {
        private DateTime selectedDate;
        public YeniPlanlar(DateTime selectedDate)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            
        }
        public YeniPlanlar()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanOlustur planOlustur = new PlanOlustur(selectedDate);
            planOlustur.Show();
            
        }

        private void YeniPlanlar_Load(object sender, EventArgs e)
        {
            listeDoldur();
        }

        internal void listeDoldur()
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<Planlar> planListesi = bll.planListele();
            if (planListesi != null && planListesi.Count > 0)
            {
                lbTarihler.DataSource = planListesi;
            }
        }

        

        private void lbTarihler_DoubleClick(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Planlar secilenPlan = (Planlar)lst.SelectedItem;
            if (secilenPlan != null)
            {
                lbPlanlar.Items.Add(secilenPlan.islemZamani + " : " + secilenPlan.baslangicZamani + " : " + secilenPlan.bitisZamani + " : " +
                    secilenPlan.tip + " : " + secilenPlan.aciklama);
            }
        }
    }
}
