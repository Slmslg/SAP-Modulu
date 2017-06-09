using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifSiparis : Araclar, CRUD
    {
        public ModelSiparisler msiparis;

        public bool Ekle()
        {
            cmd = new SqlCommand("insert into sIparIsler(malzemeId,adet,tarih,tahminigelirtarihi,aciklama,tutar) values(@malzemeid,@adet,@tarih,@tahminigelirtarihi,@aciklama,@tutar)", baglan);
            cmd.Parameters.AddWithValue("@malzemeid", msiparis.Malzemeid);
            cmd.Parameters.AddWithValue("@adet", msiparis.Adet);
            cmd.Parameters.AddWithValue("@tarih", msiparis.Tarih);
            cmd.Parameters.AddWithValue("@tahminigelirtarihi", msiparis.Tahminigelistarihi);
            cmd.Parameters.AddWithValue("@aciklama", msiparis.Aciklama);
            cmd.Parameters.AddWithValue("@tutar", msiparis.Tutar);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update sIparIsler set malzemeId=@malzemeid,adet=@adet,tarih=@tarih,tahminigelirtarihi=@tahminigelirtarihi,aciklama=@aciklama,tutar=@tutar where SiparisID=@SiparisID ", baglan);
            cmd.Parameters.AddWithValue("@malzemeid", msiparis.Malzemeid);
            cmd.Parameters.AddWithValue("@adet", msiparis.Adet);
            cmd.Parameters.AddWithValue("@tarih", msiparis.Tarih);
            cmd.Parameters.AddWithValue("@tahminigelirtarihi", msiparis.Tahminigelistarihi);
            cmd.Parameters.AddWithValue("@aciklama", msiparis.Aciklama);
            cmd.Parameters.AddWithValue("@tutar", msiparis.Tutar);
            cmd.Parameters.AddWithValue("@SiparisID", msiparis.Siparisid);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from sIparIsler where SiparisID=@SiparisID", baglan);
            cmd.Parameters.AddWithValue("@SiparisID", msiparis.Siparisid);
            return cmdCalistir();
        }
    }
}
