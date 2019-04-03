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
            bool logMode = false;
            string dosyaAdi;

            void Log(string mesaj)
            {
                if (!logMode)
                {
                    StreamWriter sw = File.AppendText("log.txt");
                    sw.WriteLine(mesaj);
                    sw.Flush();
                    sw.Close();
                }
            }

            if (args.Length > 0)
            {
                if (args[0] == "-L")
                {
                    dosyaAdi = args.Length > 1 ? args[1] : null;
                    logMode = true;
                }
                else
                {
                    dosyaAdi = args[0];
                }
            }
            else dosyaAdi = null;
            Log("Dosyadaki Hakikat V1.0 " + DateTime.Now.ToString() + " Tarihinde Başladı");

            // Geçerli bir dosya adı alana kadar dosya adı iste
            do
            {
                try
                {
                    sr = File.OpenText(dosyaAdi);
                    dosyaGecerliMi = true;
                    Log(DateTime.Now + " tarihinde " + dosyaAdi + " isimli dosya başarıyla açıldı.");
                }
                catch (FileNotFoundException )
                {
                    Log(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile FileNotFoundException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    Log(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile ArgumentNullException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Log(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile ArgumentException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }

            } while (!dosyaGecerliMi);

            sr = File.OpenText(dosyaAdi);

            //Logun Ekrana Yazdırılması
            string s;
            while ((s = sr.ReadLine()) != null && logMode) Console.WriteLine(s);

            Log("Program " + DateTime.Now.ToString() + " Tarihinde Sonlandı\n-----------------------------------------\n");
            Console.WriteLine("Program Bitti Çıkmak İçin Enter'e Basınız");
            Console.ReadLine();
        }
    }
}
