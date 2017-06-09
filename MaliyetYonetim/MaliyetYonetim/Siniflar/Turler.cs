using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class Turler : Araclar, CRUD
    {

        public  ModelTur mturler;
       
        public bool Ekle()
        {
            cmd = new SqlCommand("insert into Tur(TurAd,Aciklama) values(@turad,@aciklama)", baglan);
            cmd.Parameters.AddWithValue("@turad", mturler.TurAd);
            cmd.Parameters.AddWithValue("@aciklama", mturler.Aciklama);
            return cmdCalistir();
        }

        public bool Guncelle()
        {
            cmd = new SqlCommand("update Tur set TurAd=@turad,Aciklama=@aciklama where TurId=@turId ", baglan);
            cmd.Parameters.AddWithValue("@turad", mturler.TurAd);
            cmd.Parameters.AddWithValue("@aciklama", mturler.Aciklama);
            cmd.Parameters.AddWithValue("@turId", mturler.TurId);
            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from Tur where TurId=@turId", baglan);
            cmd.Parameters.AddWithValue("@turId", mturler.TurId);
            return cmdCalistir();
        }
    }
}
