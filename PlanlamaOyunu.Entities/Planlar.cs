using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.Entities
{
    public class Planlar
    {
        public string kullaniciAdi { get; set; }
        public string islemZamani { get; set; }
        public string baslangicZamani { get; set; }
        public string bitisZamani { get; set; }
        public string tip { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ",  islemZamani);
        }
    }
}
