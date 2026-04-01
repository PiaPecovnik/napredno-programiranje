namespace naloga3
{
    class UnikatnaSlika : Slika
    {
        private string _opisSlike;
        public string _OpisSlike
        {
            get { return _opisSlike; }
            set { _opisSlike = value; }
        }

        public UnikatnaSlika()
        {
        }

        public UnikatnaSlika(Tip tip, int sirinaVCm, int visinaVCm, string imeSlike, int osnovnaCena, bool podokvir, string avtorSlike, string opisSlike) : base(tip, sirinaVCm, visinaVCm, imeSlike, osnovnaCena, podokvir, avtorSlike)
        {
            _opisSlike = opisSlike;
        }

        public sealed override string IzpisPodatkov()
        {
            return base.IzpisPodatkov() + "\nOpis slike: " + _opisSlike;
        }

        public override bool jeUnikat()
        {
            return true;
        }
    }
}
