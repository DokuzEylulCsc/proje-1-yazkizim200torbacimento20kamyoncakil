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
            string dosyaAdi = args.Length > 0 ? args[0] : null;

            // Geçerli bir dosya adı alana kadar dosya adı iste
            while (!File.Exists(dosyaAdi))
            {
                Console.WriteLine("Dosya Adı Giriniz:");
                dosyaAdi = Console.ReadLine();
            }


            StreamReader sr = File.OpenText(dosyaAdi);

            string s;
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
