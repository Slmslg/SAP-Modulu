using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaliyetYonetim.Siniflar
{
    class Modeller : Araclar
    {
    }
    class ModelPersonel
    {
        string personelId, ad, soyad, tC, unvan, maas, girisTarihi;

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string GirisTarihi
        {
            get
            {
                return girisTarihi;
            }

            set
            {
                girisTarihi = value;
            }
        }

        public string Maas
        {
            get
            {
                return maas;
            }

            set
            {
                maas = value;
            }
        }

        public string PersonelId
        {
            get
            {
                return personelId;
            }

            set
            {
                personelId = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string TC
        {
            get
            {
                return tC;
            }

            set
            {
                tC = value;
            }
        }

        public string Unvan
        {
            get
            {
                return unvan;
            }

            set
            {
                unvan = value;
            }
        }
    }
    class ModelTur
    {
        string turId, turad, aciklama;

        public string TurId
        {
            get
            {
                return turId;
            }

            set
            {
                turId = value;
            }
        }

        public string TurAd
        {
            get
            {
                return turad;
            }

            set
            {
                turad = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
    }
    class ModelTurCins
    {
        string turid,cinsid,turcinsid,cinsad, aciklama;

        public string TurId
        {
            get
            {
                return turid;
            }

            set
            {
                turid = value;
            }
        }

        public string CinsId
        {
            get
            {
                return cinsid;
            }

            set
            {
                cinsid = value;
            }
        }
        public string TurCinsId
        {
            get
            {
                return turcinsid;
            }

            set
            {
                turcinsid = value;
            }
        }
        public string CinsAd
        {
            get
            {
                return cinsad;
            }

            set
            {
                cinsad = value;
            }
        }
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    class ModelMusteri
    {
        string musteriId, musteriAd, musteriSoyad, musteriTC, musteriAdres, musteriTelefon;

        public string MusteriId
        {
            get
            {
                return musteriId;
            }
            set
            {
                musteriId = value;
            }
        }

        public string MusteriAd
        {
            get
            {
                return musteriAd;
            }
            set
            {
                musteriAd = value;
            }
        }

        public string MusteriSoyad
        {
            get
            {
                return musteriSoyad;
            }
            set
            {
                musteriSoyad = value;
            }
        }

        public string MusteriTC
        {
            get
            {
                return musteriTC;
            }
            set
            {
                musteriTC = value;
            }
        }

        public string MusteriAdres
        {
            get
            {
                return musteriAdres;
            }
            set
            {
                musteriAdres = value;
            }
        }

        public string MusteriTelefon
        {
            get
            {
                return musteriTelefon;
            }
            set
            {
                musteriTelefon = value;
            }
        }
    }
    class ModelUrunler
    {
        string urunid, urunad, birimfiyat, aciklama, tur,turid;

        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }

        public string Birimfiyat
        {
            get
            {
                return birimfiyat;
            }

            set
            {
                birimfiyat = value;
            }
        }

        public string Tur
        {
            get
            {
                return tur;
            }

            set
            {
                tur = value;
            }
        }

        public string Urunad
        {
            get
            {
                return urunad;
            }

            set
            {
                urunad = value;
            }
        }

        public string Urunid
        {
            get
            {
                return urunid;
            }

            set
            {
                urunid = value;
            }
        }
        public string Turid
        {
            get
            {
                return turid;
            }

            set
            {
                turid = value;
            }
        }
    }

    class ModelFirma
    {
        string firmaId, firmaAd, firmaAdres, firmaTelefon;

        public string FirmaId
        {
            get
            {
                return firmaId;
            }
            set
            {
                firmaId = value;
            }
        }

        public string FirmaAd
        {
            get
            {
                return firmaAd;
            }
            set
            {
                firmaAd = value;
            }
        }

        public string FirmaAdres
        {
            get
            {
                return firmaAdres;
            }
            set
            {
                firmaAdres = value;
            }
        }

        public string FirmaTelefon
        {
            get
            {
                return firmaTelefon;
            }
            set
            {
                firmaTelefon = value;
            }
        }
    }
    /*********** GELİR MODELİ ***************/
    class ModelGelir
    {
        string gelirID, tur, aciklama, tarih,tutar;
        /*-------Gelir ID-----*/
        public string GelirID
        {
            get
            {
                return gelirID;
            }

            set
            {
                gelirID = value;
            }
        }
        /*-----------*/
        /*-------Tur------*/
        public string Tur
        {
            get
            {
                return tur;
            }

            set
            {
                tur = value;
            }
        }
        /*-----------*/
        /*-------Açıklama-----*/
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
        /*-----------*/
        /*-------Tarih-----*/
        public String Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }
        /*-----------*/
        /*-------Tutar-----*/
        public String Tutar
        {
            get
            {
                return tutar;
            }

            set
            {
                tutar = value;
            }
        }
        /*-----------*/
    }
    /***************************************/

    /*********** GİDER MODELİ ***************/
    class ModelGider
    {
        string giderID, tur, aciklama, tarih, tutar;

        /*-------Gider ID-----*/
        public string GiderID
        {
            get
            {
                return giderID;
            }

            set
            {
                giderID = value;
            }
        }
        /*-----------*/
        /*-------Tur------*/
        public string Tur
        {
            get
            {
                return tur;
            }

            set
            {
                tur = value;
            }
        }
        /*-----------*/
        /*-------Açıklama-----*/
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
        /*-----------*/
        /*-------Tarih-----*/
        public String Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }
        /*-----------*/
        /*-------Tutar-----*/
        public string Tutar
        {
            get
            {
                return tutar;
            }

            set
            {
                tutar = value;
            }
        }
        /*-----------*/
        /***************************************/
    }
    /***************************************/
    /*********** MALZEMELER MODELİ ***************/
    class ModelMalzeme
    {
        string malzemeID, malzemeAd, birimFiyat, aciklama, turid,cinsid,turcinsid, birim, adet;
       
        /*-------Malzeme ID-----*/
        public string MalzemeID
        {
            get
            {
                return malzemeID;
            }

            set
            {
                malzemeID = value;
            }
        }
        /*-----------*/
        /*-------Malzeme Ad------*/
        public string MalzemeAd
        {
            get
            {
                return malzemeAd;
            }

            set
            {
                malzemeAd = value;
            }
        }
        /*-----------*/
        /*-------Açıklama-----*/
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }
        /*-----------*/
        /*-------Birim Fiyat-----*/
        public String BirimFiyat
        {
            get
            {
                return birimFiyat;
            }

            set
            {
                birimFiyat = value;
            }
        }
        /*-----------*/
        /*-------Tur-----*/
        public String TurId
        {
            get
            {
                return turid;
            }

            set
            {
                turid = value;
            }
        }
        public String TurCinsId
        {
            get
            {
                return turcinsid;
            }

            set
            {
                turcinsid = value;
            }
        }
        public String CinsId
        {
            get
            {
                return cinsid;
            }

            set
            {
                cinsid = value;
            }
        }
        /*-----------*/
        /*-------Adet-----*/
        public String Adet
        {
            get
            {
                return adet;
            }

            set
            {
                adet = value;
            }
        }
        /*-----------*/
        /*-------Birim-----*/
        public string Birim
        {
            get
            {
                return birim;
            }

            set
            {
                birim = value;
            }
        }
        /*-----------*/
    }
    /***************************************/
    class ModelSatis
    {
        string satisId, firmaId, urunId, musteriId, adet, tarih, tutar, aciklama;

        public string SatisId
        {
            get
            {
                return satisId;
            }
            set
            {
                satisId = value;
            }
        }

        public string UrunId
        {
            get
            {
                return urunId;
            }
            set
            {
                urunId = value;
            }
        }

        public string MusteriId
        {
            get
            {
                return musteriId;
            }
            set
            {
                musteriId = value;
            }
        }
        public string FirmaId
        {
            get
            {
                return firmaId;
            }
            set
            {
                firmaId = value;
            }
        }
        public string Adet
        {
            get
            {
                return adet;
            }
            set
            {
                adet = value;
            }
        }
        public string Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                tarih = value;
            }
        }

       public string Tutar
        {
            get
            {
                return tutar;
            }
            set
            {
                tutar = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return aciklama;
            }
            set
            {
                aciklama = value;
            }
        }
    }

    class ModelUrun
    {
        string urunId, urunAd, birimFiyat, aciklama, tur;

        public string UrunId
        {
            get
            {
                return urunId;
            }
            set
            {
                urunId = value;
            }
        }

        public string UrunAd
        {
            get
            {
                return urunAd;
            }
            set
            {
                urunAd = value;
            }
        }

        public string BirimFiyat
        {
            get
            {
                return birimFiyat;
            }
            set
            {
                birimFiyat = value;
            }
        }
        public string Aciklama
        {
            get
            {
                return aciklama;
            }
            set
            {
                aciklama = value;
            }
        }
        public string Tur
        {
            get
            {
                return tur;
            }
            set
            {
                tur = value;
            }
        }
    }

    class ModelSiparisler
    {
        string siparisid, malzemeid, adet, aciklama, tutar;
        DateTime tarih; DateTime tahminigelistarihi;
        public string Aciklama
        {
            get
            {
                return aciklama;
            }

            set
            {
                aciklama = value;
            }
        }

        public string Adet
        {
            get
            {
                return adet;
            }

            set
            {
                adet = value;
            }
        }

        public string Malzemeid
        {
            get
            {
                return malzemeid;
            }

            set
            {
                malzemeid = value;
            }
        }

        public string Siparisid
        {
            get
            {
                return siparisid;
            }

            set
            {
                siparisid = value;
            }
        }





        public string Tutar
        {
            get
            {
                return tutar;
            }

            set
            {
                tutar = value;
            }
        }

        public DateTime Tahminigelistarihi
        {
            get
            {
                return tahminigelistarihi;
            }

            set
            {
                tahminigelistarihi = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return tarih;
            }

            set
            {
                tarih = value;
            }
        }
    }
}
