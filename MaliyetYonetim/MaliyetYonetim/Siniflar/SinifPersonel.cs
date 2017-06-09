using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifPersonel : Araclar, CRUD
    {
        public ModelPersonel mpersonel;

        public bool Ekle()
        {
            cmd = new SqlCommand("insert into Personel(Ad,soyad,tc,unvan,maas,giristarihi) values(@Ad,@soyad,@tc,@unvan,@maas,@giristarihi)", baglan);
            cmd.Parameters.AddWithValue("@Ad", mpersonel.Ad);
            cmd.Parameters.AddWithValue("@soyad", mpersonel.Soyad);
            cmd.Parameters.AddWithValue("@tc", mpersonel.TC);
            cmd.Parameters.AddWithValue("@unvan", mpersonel.Unvan);
            cmd.Parameters.AddWithValue("@maas", mpersonel.Maas);
            cmd.Parameters.AddWithValue("@giristarihi", mpersonel.GirisTarihi);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update Personel set Ad=@Ad,soyad=@soyad,tc=@tc,unvan=@unvan,maas=@maas,giristarihi=@giristarihi where personelId=@personelId ", baglan);
            cmd.Parameters.AddWithValue("@Ad", mpersonel.Ad);
            cmd.Parameters.AddWithValue("@soyad", mpersonel.Soyad);
            cmd.Parameters.AddWithValue("@tc", mpersonel.TC);
            cmd.Parameters.AddWithValue("@unvan", mpersonel.Unvan);
            cmd.Parameters.AddWithValue("@maas", mpersonel.Maas);
            cmd.Parameters.AddWithValue("@giristarihi", mpersonel.GirisTarihi);
            cmd.Parameters.AddWithValue("@personelId", mpersonel.PersonelId);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from personel where personelId=@personelId", baglan);
            cmd.Parameters.AddWithValue("@personelId", mpersonel.PersonelId);
            return cmdCalistir();
        }
    }
}
