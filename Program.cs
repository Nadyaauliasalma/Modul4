using System;
using Modul4;
using Modul4;
using static Modul4.FanLaptop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Soal 1");
        foreach (KodeProduk.produkElektronik prd in Enum.GetValues(typeof(KodeProduk.produkElektronik)))
        {
            Console.WriteLine("Kode produk " + prd + ": " + KodeProduk.getKodeProduk(prd));
        }

        Console.WriteLine("\nSoal 2");
        FanLaptop fan = new FanLaptop();
        fan.Simulasi();
    }
}