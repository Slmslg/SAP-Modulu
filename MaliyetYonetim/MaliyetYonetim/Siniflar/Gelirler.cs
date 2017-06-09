using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaliyetYonetim.Siniflar
{
    class Gelirler : Araclar, CRUD
    {
        public ModelGelir mgelir;
        public bool Ekle()
        {                    //
            cmd = new SqlCommand("insert into GELIRLER(Tur, Aciklama,Tutar,Tarih) values(@Tur,@Aciklama,@Tutar,@Tarih)", baglan);
            cmd.Parameters.AddWithValue("@Tur", mgelir.Tur);
            cmd.Parameters.AddWithValue("@Aciklama", mgelir.Aciklama);
            cmd.Parameters.AddWithValue("@Tutar", mgelir.Tutar);
            cmd.Parameters.AddWithValue("@Tarih", mgelir.Tarih);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("UPDATE GELIRLER SET Tur=@Tur,Aciklama=@Aciklama,Tutar=@Tutar,Tarih=@Tarih WHERE GelirID=@GelirID", baglan);
            cmd.Parameters.AddWithValue("@Tur", mgelir.Tur);
            cmd.Parameters.AddWithValue("@Aciklama", mgelir.Aciklama);
            cmd.Parameters.AddWithValue("@Tutar", mgelir.Tutar);
            cmd.Parameters.AddWithValue("@Tarih", mgelir.Tarih);
            cmd.Parameters.AddWithValue("@GelirID", mgelir.GelirID);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("DELETE FROM GELIRLER WHERE GelirID=@GelirID", baglan);
            cmd.Parameters.AddWithValue("@GelirID", mgelir.GelirID);
            return cmdCalistir();
        }
        
    }
}
