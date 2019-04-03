using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    abstract class Sayi
    {
        protected abstract List<Sayi> sayi { get; set; }

        public abstract double Değer { get; set; }

        public abstract bool Check(string s);

        public abstract void Ekle(Sayi gelen);

        public abstract int adet { get; }
    }
}
