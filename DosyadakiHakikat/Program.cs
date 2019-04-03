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
            StreamReader sr;
            bool dosyaGecerliMi = false;
            string dosyaAdi = args.Length > 0 ? args[0] : null;
            // Geçerli bir dosya adı alana kadar dosya adı iste
            do
            {
                try
                {
                    sr = File.OpenText(dosyaAdi);
                    dosyaGecerliMi = true;
                }
                catch (FileNotFoundException )
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }

            } while (!dosyaGecerliMi);

            sr = File.OpenText(dosyaAdi);


            string s;
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
