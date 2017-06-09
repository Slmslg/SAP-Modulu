using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class Cinsler : Araclar, CRUD
    {
        public ModelTurCins mturcins;
        public bool Ekle()
        {
            cmd = new SqlCommand("CinsEkle @turid,@cinsAd,@aciklama", baglan);
            cmd.Parameters.AddWithValue("@turid", mturcins.TurId);
            cmd.Parameters.AddWithValue("@cinsAd", mturcins.CinsAd);
            cmd.Parameters.AddWithValue("@aciklama", mturcins.Aciklama);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update Cins set CinsAd=@cinsAd,Acıklama=@aciklama where CinsId=@cinsid ", baglan);
            cmd.Parameters.AddWithValue("@cinsAd", mturcins.CinsAd);
            cmd.Parameters.AddWithValue("@aciklama", mturcins.Aciklama);
            cmd.Parameters.AddWithValue("@cinsid", mturcins.CinsId);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from Cins where CinsId=@cinsid", baglan);
            cmd.Parameters.AddWithValue("@cinsid", mturcins.CinsId);
            return cmdCalistir();
        }
    }
}
