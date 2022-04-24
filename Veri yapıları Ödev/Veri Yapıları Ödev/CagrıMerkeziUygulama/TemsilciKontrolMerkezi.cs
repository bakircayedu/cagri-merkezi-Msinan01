using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public abstract class TemsilciKontrolMerkezi
    {
        protected List<MusteriTemsilcisi> Temsilciler = new List<MusteriTemsilcisi>();

        public Cagri IsmeGoreCagrıAra(string isim)
        {

            for (int i = 0; i < Temsilciler.Count; i++)
            {
                MusteriTemsilcisi item = Temsilciler[i];
                var cagrilar = item.Cagrilar.ToArray();
                foreach (var cagri in cagrilar)
                {
                    if (cagri.Musteri.Name == isim)
                    {
                        return cagri;
                    }
                }
            }
            return null;
        }
        public MusteriTemsilcisi UygunMusteriTemsilcisiniAl()
        {
            var enUygunTemsilci = Temsilciler.First();
            for (int i = 0; i < Temsilciler.Count; i++)
            {
                var currentTemsilci = Temsilciler[i];
                if (currentTemsilci.Cagrilar.Count < enUygunTemsilci.Cagrilar.Count)
                {
                    enUygunTemsilci = currentTemsilci;
                }
            }

            return enUygunTemsilci;
        }
    }
 

}
