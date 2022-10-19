using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderPattern.PromotionExample
{
     class SendPromotion
    {
        public void Gonder(PromotionBuilder builder)
        {
            builder.SetCalisanProfili();
            builder.SetPromosyonNumarasi();
            builder.SetUrunAdi();
        }
    }
}
