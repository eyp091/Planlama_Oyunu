using PlanlamaOyunu.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;
        
        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int KayitEkle(string Ad, string Soyad, string KullaniciAdi, string Sifre, string Email, string Tcno, string Adres, string Tel, string Tip)
        {
            if(!string.IsNullOrEmpty(Ad) && !string.IsNullOrEmpty(Soyad) && !string.IsNullOrEmpty(KullaniciAdi))
            {
                return dll.kayitEkle(new Entities.Kullanici()
                {
                    kullaniciId = Guid.NewGuid(),
                    ad = Ad,
                    soyad = Soyad,
                    kullaniciAdi = KullaniciAdi,
                    sifre = Sifre,
                    email = Email,
                    tcNo = Tcno,
                    adres = Adres,
                    tel = Tel,
                    tip = Tip
                });
            }
            else
            {
                return -1; //Eksik parametre hatası.
            }
        }

        public int sistemKontrol(string kullaniciAdi, string sifre)
        {
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return dll.sistemKontrol(new Entities.Kullanici()
                {
                    kullaniciAdi=kullaniciAdi,
                    sifre = sifre
                });
            }
            else
            {
                return -1; //Eksik parametre hatası.
            }
        }

        public int planEkle(string kullaniciAdi, string islemZamani, string baslangicZamani, string bitisZamani, string tip, string aciklama)
        {
            return dll.planEkle(new Entities.Planlar()
            {
                kullaniciAdi = kullaniciAdi,
                islemZamani=islemZamani,
                baslangicZamani=baslangicZamani,
                bitisZamani=bitisZamani,
                tip = tip,
                aciklama=aciklama
            });
        }

        public List<Planlar> planListele()
        {
            List<Planlar> planListesi = new List<Planlar>();
            try
            {
                SqlDataReader reader = dll.planListele();
                while (reader.Read())
                {
                    planListesi.Add(new Planlar()
                    {
                        kullaniciAdi = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        islemZamani = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        baslangicZamani = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        bitisZamani = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        tip = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        aciklama = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return planListesi;
        }
    }
}
