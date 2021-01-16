using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,float,double,bool ==> Değer tip
            //array,class,interface ==> Referans tip
            // stack ==> değer tipler , heap ==> referans tipler
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
        }
    }
}
