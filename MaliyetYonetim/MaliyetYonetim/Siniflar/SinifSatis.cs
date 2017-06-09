using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class SinifSatis:Araclar,CRUD
    {
        public ModelSatis msatis;

        public bool Ekle()
        {



            cmd = new SqlCommand("insert into SATIS(UrunID,Adet,Tarih,FirmaId,Tutar,Aciklama,MusteriID) values(@urunId,@adet,@tarih,@firmaId,@tutar,@aciklama,@musteriId)", baglan);
            cmd.Parameters.AddWithValue("@urunId", msatis.UrunId);
            cmd.Parameters.AddWithValue("@adet", msatis.Adet);
            cmd.Parameters.AddWithValue("@tarih", msatis.Tarih);
            cmd.Parameters.AddWithValue("@firmaId", msatis.FirmaId);
            cmd.Parameters.AddWithValue("@tutar", msatis.Tutar);
            cmd.Parameters.AddWithValue("@aciklama", msatis.Aciklama);
            cmd.Parameters.AddWithValue("@musteriId", msatis.MusteriId);
            return cmdCalistir();

        }

        public bool Guncelle()
        {
            //update SATIS set UrunID=@urunId,Adet=@adet,Tarih=@tarih,FirmaId=@firmaId,Tutar=@tutar,Aciklama=@aciklama,MusteriID=@musteriId where SatisID=@satisid

            //update SATIS set UrunID='"+msatis.UrunId+"',Adet='"+msatis.Adet+"',Tarih='"+msatis.Tarih+"',FirmaId='"+msatis.FirmaId+"',Tutar='"+msatis.Tutar+"',Aciklama='"+msatis.Aciklama+"',MusteriID='"+msatis.MusteriId+"' where SatisID='"+msatis.SatisId+"'"
            cmd = new SqlCommand("update SATIS set Adet=@adet,Tarih=@tarih,Tutar=@tutar,Aciklama=@aciklama where SatisID=@satisid", baglan);

            //cmd.Parameters.AddWithValue("@urunId", msatis.UrunId);
            cmd.Parameters.AddWithValue("@adet", msatis.Adet);
            cmd.Parameters.AddWithValue("@tarih", msatis.Tarih);
           // cmd.Parameters.AddWithValue("@firmaId", msatis.FirmaId);
            cmd.Parameters.AddWithValue("@tutar", msatis.Tutar);
            cmd.Parameters.AddWithValue("@aciklama", msatis.Aciklama);
           // cmd.Parameters.AddWithValue("@musteriId", msatis.MusteriId);
            cmd.Parameters.AddWithValue("@satisid", msatis.SatisId);

            return cmdCalistir();
        }

        public bool Sil()
        {
            cmd = new SqlCommand("delete from satis where SatisID=@satisid", baglan);

            cmd.Parameters.AddWithValue("@satisid", msatis.SatisId);

            return cmdCalistir();
        }
    }
}
