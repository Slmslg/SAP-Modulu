using MaliyetYonetim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaliyetYonetim.AracDoldur
{
    class cmbUrun:Araclar
    {
        public  double birimfiyat;
        public cmbUrun() { }
        public cmbUrun(ComboBox cmb)
        {

            ComboBoxItem urun;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select UrunId,UrunAd,BirimFiyat from Urunler order by UrunAd asc", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                urun = new ComboBoxItem();
                urun.Value = dr["UrunId"];
                urun.Text = dr["UrunAd"].ToString();
                cmb.Items.Add(urun);
            }
            baglan.Close();
        }

        public double cmbBirimFiyat(ComboBoxItem cmb)
        {
            baglan.Open();
            cmd = new SqlCommand("select BirimFiyat from Urunler where  UrunId=@urunid", baglan);
            cmd.Parameters.AddWithValue("@urunid",cmb.Value);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                birimfiyat =Double.Parse( dr["BirimFiyat"].ToString());
            }
            return birimfiyat;

        }
        public cmbUrun(ComboBox cmb, string urunid)
        {
            ComboBoxItem tur;
            cmb.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select UrunId,UrunAd,BirimFiyat from Urunler where UrunId=@urunid", baglan);
            cmd.Parameters.AddWithValue("@urunid", urunid);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               // birimfiyat = dr["BirimFiyat"].ToString();
                tur = new ComboBoxItem();
                tur.Value = dr["UrunId"];
                tur.Text = dr["TurAd"].ToString();
                cmb.Items.Add(tur);
            }
            baglan.Close();
        }


    }
}
