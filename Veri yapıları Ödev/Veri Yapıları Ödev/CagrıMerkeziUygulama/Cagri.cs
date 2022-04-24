using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public class Cagri
    {
        private IslemTuru _islemTuru;

        public MusteriTemsilcisi MusteriTemsilcisi { get; private set; }

        public Musteri Musteri { get; set; }
        public DateTime CagriOlusturulduguTarih { get; private set; }
        public DateTime CagriBittigiTarih { get; private set; }
        public DateTime TemsiciyleBaslananTarih { get; private set; }
        public string GorusmeNotlari { get; private set; }

        public int CagrıSuresı { get; private set; }

        public Cagri(IslemTuru islemTuru, DateTime cagriOlusturulduguTarih)
        {
            var randomNumber = new Random();
            CagrıSuresı = randomNumber.Next(10);
            var randomBeklemeSuresi = randomNumber.Next(5);

            CagriOlusturulduguTarih = cagriOlusturulduguTarih;
            CagriBittigiTarih = CagriOlusturulduguTarih.AddMinutes(CagrıSuresı);
            TemsiciyleBaslananTarih = cagriOlusturulduguTarih.AddMinutes(randomBeklemeSuresi);

            _islemTuru = islemTuru;
        }

        public void CagriyiBitir()
        {
            GorusmeNotlari = String.Empty;
        }
    }

    public enum IslemTuru
    {
        Bireysel,
        Ticari
    }

}
