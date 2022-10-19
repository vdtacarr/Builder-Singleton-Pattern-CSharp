using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern
{
     class Promotion
    {
        public string UrunAdi { get; set; }
        public int PromosyonNumarasi { get; set; }
        public string CalisanProfili { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{PromosyonNumarasi} numaralı {UrunAdi} promosyonu {CalisanProfili} calışanlarına verilmiştir.");
            return "";
        }
    }
}
