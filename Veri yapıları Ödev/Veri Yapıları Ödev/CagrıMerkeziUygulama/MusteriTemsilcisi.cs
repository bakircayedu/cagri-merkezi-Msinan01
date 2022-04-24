using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public class MusteriTemsilcisi
    {
        public Queue<Cagri> Cagrilar { get; } = new Queue<Cagri>();
        public Cagri GuncelCagri { get; private set; }
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public bool TemsilciMesguliyeti = false;
        public String TemsilciName { get; private set; }
        private float cagriSayaci;



        public MusteriTemsilcisi(string name)
        {
            TemsilciName = name;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        public void CagriyiSirayaEkle(Cagri cagri)
        {
            Cagrilar.Enqueue(cagri);
        }

        void Update(object sender, EventArgs e)
        {
            if (!TemsilciMesguliyeti)
            {
                if (Cagrilar.Count != 0)
                {
                    TemsilciMesguliyeti = true;
                    GuncelCagri = Cagrilar.Dequeue();
                }
            }
            else
            {
                cagriSayaci++;

                if (cagriSayaci == GuncelCagri.CagrıSuresı)
                {
                    cagriSayaci = 0;
                    TemsilciMesguliyeti = false;
                }
            }

        }

        public void CagrilariIsle()
        {
            GuncelCagri = Cagrilar.Dequeue();
        }
    }
}
