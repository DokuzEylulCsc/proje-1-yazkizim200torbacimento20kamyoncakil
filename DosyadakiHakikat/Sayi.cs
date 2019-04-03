using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    abstract class Sayi
    {
        public abstract List<object> sayi { get; set; }

        public abstract bool Check(string s);
    }
}
