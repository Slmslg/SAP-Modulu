using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class Malzemeler : Araclar, CRUD
    {
        public ModelMalzeme malzemeler;
        public bool Ekle()
        {
            cmd = new SqlCommand("insert into MALZEME(MalzemeAdi,BirimFiyat,Aciklama,TurCinsId,Adet,Birim) values(@MalzemeAd,@BirimFiyat,@Aciklama,(Select TurCinsId from TurCins where TurID=@turid and CinsId=@cinsid),@adet,@birim)", baglan);
            cmd.Parameters.AddWithValue("@MalzemeAd", malzemeler.MalzemeAd);
            cmd.Parameters.AddWithValue("@BirimFiyat", malzemeler.BirimFiyat);
            cmd.Parameters.AddWithValue("@Aciklama", malzemeler.Aciklama);
            cmd.Parameters.AddWithValue("@turid", malzemeler.TurId);
            cmd.Parameters.AddWithValue("@cinsid", malzemeler.CinsId);
            cmd.Parameters.AddWithValue("@adet", malzemeler.Adet);
            cmd.Parameters.AddWithValue("@Birim", malzemeler.Birim);
            //cmd.ExecuteNonQuery();
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("UPDATE MALZEME SET MalzemeAdi=@MalzemeAd,BirimFiyat=@BirimFiyat,Aciklama=@Aciklama,Tur=@Tur,Adet=@Adet,Birim=@Birim WHERE MalzemeID=@MalzemeID", baglan);
            cmd.Parameters.AddWithValue("@MalzemeAd", malzemeler.MalzemeAd);
            cmd.Parameters.AddWithValue("@BirimFiyat", malzemeler.BirimFiyat);
            cmd.Parameters.AddWithValue("@Aciklama", malzemeler.Aciklama);
            cmd.Parameters.AddWithValue("@Tur", malzemeler.Tur);
            cmd.Parameters.AddWithValue("@Adet", malzemeler.Adet);
            cmd.Parameters.AddWithValue("@Birim", malzemeler.Birim);
           // cmd.ExecuteNonQuery();
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("DELETE FROM MALZEME WHERE MalzemeID=@MalzemeID", baglan);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeler.MalzemeID);
            //cmd.ExecuteNonQuery();
            return cmdCalistir();
        }
    }
}
