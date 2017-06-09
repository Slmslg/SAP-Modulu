using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifMusteri : Araclar, CRUD
    {
        public ModelMusteri mMusteri;

        public bool Ekle()
        {
            cmd = new SqlCommand("insert into MUSTERILER(TC,MusteriAd,MusteriSoyad,Adres,Telefon) values(@tc,@ad,@soyad,@adres,@telefon)", baglan);
            cmd.Parameters.AddWithValue("@tc", mMusteri.MusteriTC);
            cmd.Parameters.AddWithValue("@ad", mMusteri.MusteriAd);
            cmd.Parameters.AddWithValue("@soyad", mMusteri.MusteriSoyad);
            cmd.Parameters.AddWithValue("@adres", mMusteri.MusteriAdres);
            cmd.Parameters.AddWithValue("@telefon", mMusteri.MusteriTelefon);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update MUSTERILER set TC=@tc,MusteriAd=@ad,MusteriSoyad=@soyad,Adres=@adres,Telefon=@telefon where MusteriID=@id ", baglan);
            cmd.Parameters.AddWithValue("@tc", mMusteri.MusteriTC);
            cmd.Parameters.AddWithValue("@ad", mMusteri.MusteriAd);
            cmd.Parameters.AddWithValue("@soyad", mMusteri.MusteriSoyad);
            cmd.Parameters.AddWithValue("@adres", mMusteri.MusteriAdres);
            cmd.Parameters.AddWithValue("@telefon", mMusteri.MusteriTelefon);
            cmd.Parameters.AddWithValue("@id", mMusteri.MusteriId);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from MUSTERILER where MusteriID=@id", baglan);
            cmd.Parameters.AddWithValue("@id", mMusteri.MusteriId);
            return cmdCalistir();
        }

    }
}
