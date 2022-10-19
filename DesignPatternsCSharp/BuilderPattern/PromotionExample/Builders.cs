using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern
{
    class AmirlerConcreteBuilder : PromotionBuilder
    {
        public AmirlerConcreteBuilder()
        {
            promosyon = new Promotion();
        }
        public override void SetCalisanProfili() => promosyon.CalisanProfili = "Amirler";
        public override void SetPromosyonNumarasi() => promosyon.PromosyonNumarasi = 100;
        public override void SetUrunAdi() => promosyon.UrunAdi = "Job";
    }
    //ConcreteBuilder Class
    class IscilerConcreteBuilder : PromotionBuilder
    {
        public IscilerConcreteBuilder()
        {
            promosyon = new Promotion();
        }
        public override void SetCalisanProfili() => promosyon.CalisanProfili = "İşçiler";
        public override void SetPromosyonNumarasi() => promosyon.PromosyonNumarasi = 270;
        public override void SetUrunAdi() => promosyon.UrunAdi = "Ceket";
    }
    //ConcreteBuilder Class
    class KadinlarConcreteBuilder : PromotionBuilder
    {
        public KadinlarConcreteBuilder()
        {
            promosyon = new Promotion();
        }
        public override void SetCalisanProfili() => promosyon.CalisanProfili = "Kadınlar";
        public override void SetPromosyonNumarasi() => promosyon.PromosyonNumarasi = 125;
        public override void SetUrunAdi() => promosyon.UrunAdi = "Tesbih";
    }
}
