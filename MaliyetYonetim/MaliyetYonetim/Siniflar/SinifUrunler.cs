using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifUrunler : Araclar, CRUD
    {
        public ModelUrunler murunler;
        public bool Ekle()
        {
            cmd = new SqlCommand("insert into urunler(urunad,birimfiyat,aciklama,tur) values(@urunad,@birimfiyat,@aciklama,@tur)", baglan);
            cmd.Parameters.AddWithValue("@urunad", murunler.Urunad);
            cmd.Parameters.AddWithValue("@birimfiyat", murunler.Birimfiyat);
            cmd.Parameters.AddWithValue("@aciklama", murunler.Aciklama);
            cmd.Parameters.AddWithValue("@tur", murunler.Tur); 
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update urunler set urunad=@urunad,birimfiyat=@birimfiyat,aciklama=@aciklama,tur=@tur where urunId=@urunId ", baglan);
            cmd.Parameters.AddWithValue("@urunad", murunler.Urunad);
            cmd.Parameters.AddWithValue("@birimfiyat", murunler.Birimfiyat);
            cmd.Parameters.AddWithValue("@aciklama", murunler.Aciklama);
            cmd.Parameters.AddWithValue("@tur", murunler.Tur);
            cmd.Parameters.AddWithValue("@urunId", murunler.Urunid);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from urunler where urunId=@urunId", baglan);
            cmd.Parameters.AddWithValue("@urunId", murunler.Urunid);
            return cmdCalistir();
        }
    }
}
