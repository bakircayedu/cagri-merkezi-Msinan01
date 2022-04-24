using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagrıMerkeziProgramı
{
    public class Musteri
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public IslemTuru IslemTuru { get; private set; }

        public Musteri(string name, string surname, IslemTuru islemTürü)
        {
            Name = name;
            Surname = surname;
            IslemTuru = islemTürü;
        }
    }
}
