namespace DesignPatternsCSharp.BuilderPattern
{
    abstract class PromotionBuilder
    {
        protected Promotion promosyon;
        public Promotion Promosyon
        {
            get
            {
                return promosyon;
            }
        }
        public abstract void SetUrunAdi();
        public abstract void SetPromosyonNumarasi();
        public abstract void SetCalisanProfili();
    }
}
