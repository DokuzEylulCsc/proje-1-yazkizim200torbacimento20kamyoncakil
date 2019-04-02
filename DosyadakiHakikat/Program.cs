using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyadakiHakikat
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            StreamReader sr = File.OpenText(args[0]);
            while((s = sr.ReadLine()) != null)
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
