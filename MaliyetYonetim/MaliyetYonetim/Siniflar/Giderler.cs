using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class Giderler : Araclar, CRUD
    {
        public ModelGider mgiderler;
        public bool Ekle()
        {
            //
            cmd = new SqlCommand("insert into GIDERLER(Tur,Aciklama,Tutar,Tarih) values(@Tur,@Aciklama,@Tutar,@Tarih)", baglan);
            cmd.Parameters.AddWithValue("@Tur", mgiderler.Tur);
            cmd.Parameters.AddWithValue("@Aciklama", mgiderler.Aciklama);
            cmd.Parameters.AddWithValue("@Tutar", mgiderler.Tutar);
            cmd.Parameters.AddWithValue("@Tarih", mgiderler.Tarih);
            return cmdCalistir();
        }

        public bool Guncelle()
        {                       
            cmd = new SqlCommand("UPDATE GIDERLER SET Tur=@Tur,Aciklama=@Aciklama,Tutar=@Tutar,Tarih=@Tarih WHERE GiderID=@GiderID", baglan);
            cmd.Parameters.AddWithValue("@Tur", mgiderler.Tur);
            cmd.Parameters.AddWithValue("@Aciklama", mgiderler.Aciklama);
            cmd.Parameters.AddWithValue("@Tutar", mgiderler.Tutar);
            cmd.Parameters.AddWithValue("@Tarih", mgiderler.Tarih);
            cmd.Parameters.AddWithValue("@GiderID", mgiderler.GiderID);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("DELETE FROM GIDERLER WHERE GiderID=@GiderID", baglan);
            cmd.Parameters.AddWithValue("@GiderID", mgiderler.GiderID);
            return cmdCalistir();
        }
    }
}
