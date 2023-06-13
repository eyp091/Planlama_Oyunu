using PlanlamaOyunu.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PlanlamaOyunu.DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnValues;

        public DLL()
        {
            con = new SqlConnection("Data Source=DESKTOP-230280V;Initial Catalog=PlanlamaOyunu;Integrated Security=True");
        }

        //Bağalntının davranışına göre durumunu belirlediğimiz metot. 
        public void BaglantiAyarla()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public int kayitEkle(Kullanici kullanici)
        {
            try
            {
                cmd = new SqlCommand("insert into tblKullanici (KullaniciId, Ad, Soyad, KullaniciAdi, Sifre, Email, Tcno, Adres, Tel, Tip) " +
                    "values (@KullaniciId, @Ad, @Soyad, @KullaniciAdi, @Sifre, @Email, @Tcno, @Adres, @Tel, @Tip)", con);

                cmd.Parameters.Add("@KullaniciId", SqlDbType.UniqueIdentifier).Value = kullanici.kullaniciId;
                cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = kullanici.ad;
                cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = kullanici.soyad;
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = kullanici.kullaniciAdi;
                cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = kullanici.sifre;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = kullanici.email;
                cmd.Parameters.Add("@Tcno", SqlDbType.NVarChar).Value = kullanici.tcNo;
                cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = kullanici.adres;
                cmd.Parameters.Add("@Tel", SqlDbType.NVarChar).Value = kullanici.tel;
                cmd.Parameters.Add("@Tip", SqlDbType.NVarChar).Value = kullanici.tip;
                BaglantiAyarla();
                returnValues = cmd.ExecuteNonQuery(); //Soyguyu database'e gönderir.
            }
            catch (Exception ex)
            {

            }
            finally
            {
                BaglantiAyarla();
            }
            return returnValues;
        }

        public int sistemKontrol(Kullanici kullanici)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from tblKullanici where KullaniciAdi = @kullaniciAdi and Sifre = @sifre", con);
                cmd.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = kullanici.kullaniciAdi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = kullanici.sifre;
                BaglantiAyarla();
                returnValues = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                BaglantiAyarla();
            }
            return returnValues;
        }

        public int planEkle(Planlar planlar)
        {
            try
            {
                cmd = new SqlCommand("insert into tblPlan (KullaniciAdi, IslemZamani, BaslangicZamani, BitisZamani, Tip, Aciklama) " +
                    "values (@KullaniciAdi, @IslemZamani, @BaslangicZamani, @BitisZamani, @Tip, @Aciklama)", con);
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = planlar.kullaniciAdi;
                cmd.Parameters.Add("@IslemZamani", SqlDbType.NVarChar).Value = planlar.islemZamani;
                cmd.Parameters.Add("@BaslangicZamani", SqlDbType.NVarChar).Value = planlar.baslangicZamani;
                cmd.Parameters.Add("@BitisZamani", SqlDbType.NVarChar).Value = planlar.bitisZamani;
                cmd.Parameters.Add("@Tip", SqlDbType.NVarChar).Value = planlar.tip;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = planlar.aciklama;
                BaglantiAyarla();
                returnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                BaglantiAyarla();
            }
            return returnValues;
        }

        public SqlDataReader planListele()
        {
            cmd = new SqlCommand("select * from tblPlan", con);
            BaglantiAyarla();
            return cmd.ExecuteReader();
        }
    }

   
}
