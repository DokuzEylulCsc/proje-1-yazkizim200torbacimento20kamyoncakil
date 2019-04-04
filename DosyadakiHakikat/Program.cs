﻿using System;
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
            string dosyaAdi;
            string s;
            int girdiAdedi = 0;
            TamSayi tamSayi = new TamSayi();
            NoktaliSayi noktaliSayi = new NoktaliSayi();
            Log log = new Log();

            if (args.Length > 0)
            {
                if (args[0] == "-L")
                {
                    dosyaAdi = args.Length > 1 ? args[1] : null;
                    log.LogMode = true;
                }
                else
                {
                    dosyaAdi = args[0];
                }
            }
            else dosyaAdi = null;
            log.Başla();

            // Geçerli bir dosya adı alana kadar dosya adı iste
            do
            {
                try
                {
                    sr = File.OpenText(dosyaAdi);
                    dosyaGecerliMi = true;
                    log.Kaydet(DateTime.Now + " tarihinde " + dosyaAdi + " isimli dosya başarıyla açıldı.");
                }
                catch (FileNotFoundException )
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile FileNotFoundException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile ArgumentNullException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    log.Kaydet(DateTime.Now + " tarihinde " + dosyaAdi + " dosya adı ile ArgumentException gerçekleşti.");
                    Console.WriteLine("Dosya Adı Giriniz:");
                    dosyaAdi = Console.ReadLine();
                }

            } while (!dosyaGecerliMi);

            sr = File.OpenText(dosyaAdi);

            //Logun Ekrana Yazdırılması
            while (log.LogMode && (s = sr.ReadLine()) != null) Console.WriteLine(s);


            while (!log.LogMode && (s = sr.ReadLine()) != null)
            {
                girdiAdedi++;
                if (noktaliSayi.Check(s))
                {
                    NoktaliSayi temp = new NoktaliSayi();
                    temp.Değer = Convert.ToDouble(s);
                    noktaliSayi.Ekle(temp);
                }
                else if (tamSayi.Check(s))
                {
                    TamSayi temp = new TamSayi();
                    temp.Değer = Convert.ToInt32(s);
                    tamSayi.Ekle(temp);
                }
            }
            if (!log.LogMode)
            {
                IntSort intSort1 = new IntSort(tamSayi.getArray());
                IntSort intSort2 = new IntSort(noktaliSayi.getArray());
                Console.WriteLine("Sıralanmış Tam Sayi Arrayi");
                intSort1.PrintSortedArray();
                Console.WriteLine("Sıralanmış Noktali Sayi Arrayi");
                intSort2.PrintSortedArray();
            }

            if (!log.LogMode)
            {
                Console.WriteLine("Toplam Satır Adedi: " + girdiAdedi);
                Console.WriteLine($"Geçerli Sayi Adedi: {tamSayi.adet + noktaliSayi.adet}" + 
                    $"(%{100*(tamSayi.adet + noktaliSayi.adet) /girdiAdedi})");
                Console.WriteLine($"Geçersiz Satır Adedi: {girdiAdedi - tamSayi.adet - noktaliSayi.adet }" +
                    $"(%{100 - (100 * (tamSayi.adet + noktaliSayi.adet ) / girdiAdedi)})");
            }
            log.Bitir();
            Console.WriteLine("Program Bitti Çıkmak İçin Enter'e Basınız");
            Console.ReadLine();
        }
    }
}
