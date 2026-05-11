namespace naloga3
{
    public enum Kvaliteta
    {
        nizka,
        srednja,
        visoka
    }

    class ReprodukcijaUmetniskeSlike : Slika
    {
        private string _originalniAvtor;
        public string _OriginalniAvtor
        {
            get { return _originalniAvtor; }
            set { _originalniAvtor = value; }
        }

        private Kvaliteta _kvaliteta;
        public Kvaliteta _Kvaliteta
        {
            get { return _kvaliteta; }
            set { _kvaliteta = value; }
        }

        public ReprodukcijaUmetniskeSlike() : this(Tip.natisnjena, 0, 0, "", 0, true, "", "", Kvaliteta.srednja)
        {

        }

        public ReprodukcijaUmetniskeSlike(Tip tip, int sirinaVCm, int visinaVCm, string imeSlike, int osnovnaCena, bool podokvir, string avtorSlike, string originalniAvtor, Kvaliteta kvaliteta) : base(tip, sirinaVCm, visinaVCm, imeSlike, osnovnaCena, podokvir, avtorSlike)
        {
            _originalniAvtor = originalniAvtor;
            _kvaliteta = kvaliteta;
        }

        public sealed override string ToString()
        {
            return base.ToString() + "\nOriginalni avtor: " + _originalniAvtor + "\nKvaliteta slike: " + _kvaliteta;
        }

        public override bool jeUnikat()
        {
            return false;
        }
    }
}
