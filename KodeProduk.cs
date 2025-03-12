using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4;

namespace Modul4
{
    class KodeProduk
    {
        public string Produk { get; set; }

        public string Kode { get; set; }

        public static List<KodeProduk> GetKodeProduks()
        {
            return new List<KodeProduk>
            {
                new KodeProduk { Produk = "Laptop", Kode = "E100" },
                new KodeProduk { Produk = "Smartphone", Kode = "E101" },
                new KodeProduk { Produk = "Tablet", Kode = "E102" },
                new KodeProduk { Produk = "Headset", Kode = "E103" },
                new KodeProduk { Produk = "Keyboard", Kode = "E104" },
                new KodeProduk { Produk = "Mouse", Kode = "E105" },
                new KodeProduk { Produk = "Printer", Kode = "E106" },
                new KodeProduk { Produk = "Monitor", Kode = "E107" },
                new KodeProduk { Produk = "Smartwatch", Kode = "E108" },
                new KodeProduk { Produk = "kamera", Kode = "E109" },
            };
        }
    }
}
