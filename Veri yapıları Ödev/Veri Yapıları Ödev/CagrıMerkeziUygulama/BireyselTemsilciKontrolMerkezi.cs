using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public class BireyselTemsilciKontrolMerkezi : TemsilciKontrolMerkezi
    {
        public BireyselTemsilciKontrolMerkezi()
        {
            Temsilciler.Add(new MusteriTemsilcisi("RATKAY"));
            Temsilciler.Add(new MusteriTemsilcisi("GURKAN"));

        }
    }

}
