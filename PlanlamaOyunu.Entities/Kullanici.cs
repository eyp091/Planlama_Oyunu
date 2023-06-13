using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.Entities
{
    public class Kullanici
    {
        public Guid kullaniciId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string tcNo { get; set; }
        public string adres { get; set; }
        public string tel { get; set; }
        public string tip { get; set; }
    }
}
