using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadakiHakikat
{
    class IntSort
    {
        private readonly Sayi[] array;
        private readonly Sayi temp;
        public IntSort(TamSayi[] gelenArray)
        {
            temp = new TamSayi();
            array = new Sayi[gelenArray.Length];
            //Bubble Sort ile sıralama
            for (int i = 0; i < gelenArray.Length; i++)
            {
                for (int j = 0; j < gelenArray.Length - 1; j++)
                {
                    if(gelenArray[j].Değer > gelenArray[j + 1].Değer)
                    {
                        temp = gelenArray[j + 1];
                        gelenArray[j + 1] = gelenArray[j];
                        gelenArray[j] = (TamSayi)temp;
                    }
                }
                array = gelenArray;
            }
        }
        public IntSort(NoktaliSayi[] gelenArray)
        {
            temp = new NoktaliSayi();
            array = new Sayi[gelenArray.Length];
            for (int i = 0; i < gelenArray.Length; i++)
            {
                for (int j = 0; j < gelenArray.Length - 1; j++)
                {
                    if (gelenArray[j].Değer > gelenArray[j + 1].Değer)
                    {
                        temp = gelenArray[j + 1];
                        gelenArray[j + 1] = gelenArray[j];
                        gelenArray[j] = (NoktaliSayi)temp;
                    }
                }
                array = gelenArray;
            }
        }
        public Sayi[] GetSortedArray()
        {
            return array;
        }
        public void PrintSortedArray()
        {
            foreach (Sayi item in array)
            {
                Console.WriteLine(item.Değer);
            }
        }
    }
}
