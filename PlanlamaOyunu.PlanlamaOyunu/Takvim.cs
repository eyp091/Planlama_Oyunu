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
    public partial class Takvim : Form
    {
        public Takvim()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            
            if (selectedDate >= DateTime.Today)
            {
                YeniPlanlar yeniPlanlar = new YeniPlanlar(selectedDate);
                yeniPlanlar.Show();
                this.Hide();
            }
            else if(selectedDate < DateTime.Today)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
