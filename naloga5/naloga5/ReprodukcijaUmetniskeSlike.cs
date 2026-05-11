namespace naloga5
{
    public enum Kvaliteta
    {
        nizka,
        srednja,
        visoka
    }

    class ReprodukcijaUmetniskeSlike : Slika
    {
        private string originalniAvtor;
        public string OriginalniAvtor
        {
            get { return originalniAvtor; }
            set { originalniAvtor = value; }
        }

        private Kvaliteta kvaliteta;
        public Kvaliteta Kvaliteta
        {
            get { return kvaliteta; }
            set { kvaliteta = value; }
        }

        public ReprodukcijaUmetniskeSlike() : this(Tip.pastel, 0, 0, "", 0, true, "", "", Kvaliteta.nizka)
        {

        }

        public ReprodukcijaUmetniskeSlike(Tip _tip, int _sirinaVCm, int _visinaVCm, string _imeSlike, int _osnovnaCena, bool _podokvir, string _avtorSlike, string _originalniAvtor, Kvaliteta _kvaliteta) : base(_tip, _sirinaVCm, _visinaVCm, _imeSlike, _osnovnaCena, _podokvir, _avtorSlike)
        {
            originalniAvtor = _originalniAvtor;
            kvaliteta = _kvaliteta;
        }

        public sealed override string ToString()
        {
            return base.ToString() + "\nOriginalni avtor: " + originalniAvtor + "\nKvaliteta slike: " + kvaliteta;
        }

        public override bool jeUnikat()
        {
            return false;
        }
    }
}
