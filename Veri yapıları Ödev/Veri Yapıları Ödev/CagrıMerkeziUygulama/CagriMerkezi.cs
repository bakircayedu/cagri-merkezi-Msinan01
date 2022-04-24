using System;

namespace CagrıMerkeziProgramı
{

    public class CagriMerkezi
    {
        private static CagriMerkezi Instance;
        private TicariTemsilciKontrolMerkezi _ticariTemsilciler;
        private BireyselTemsilciKontrolMerkezi _bireyselTemsilciler;

        public static CagriMerkezi GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CagriMerkezi();
            }
            return Instance;

        }
        public CagriMerkezi()
        {
            _ticariTemsilciler = new TicariTemsilciKontrolMerkezi();
            _bireyselTemsilciler = new BireyselTemsilciKontrolMerkezi();
        }

        public void AramaYap(Musteri musteri)
        {
            DateTime cagrininOlusturulduguTarih = DateTime.Now;
            Cagri cagri = new Cagri(musteri.IslemTuru, cagrininOlusturulduguTarih);

            switch (musteri.IslemTuru)
            {
                case IslemTuru.Bireysel:
                    _bireyselTemsilciler.UygunMusteriTemsilcisiniAl().CagriyiSirayaEkle(cagri);
                    break;
                case IslemTuru.Ticari:
                    _ticariTemsilciler.UygunMusteriTemsilcisiniAl().CagriyiSirayaEkle(cagri);
                    break;
            }
        }

      
    }
}
