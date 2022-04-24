using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public class TicariTemsilciKontrolMerkezi : TemsilciKontrolMerkezi
    {
        public TicariTemsilciKontrolMerkezi()
        {
            Temsilciler.Add(new MusteriTemsilcisi("OMER"));
            Temsilciler.Add(new MusteriTemsilcisi("ALPEREN"));

        }
    }

}
