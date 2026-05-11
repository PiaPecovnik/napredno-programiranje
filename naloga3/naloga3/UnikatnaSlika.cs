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

        public UnikatnaSlika() : this(Tip.akrilna, 0, 0, "", 0, true, "", "")
        {
        }

        public UnikatnaSlika(Tip tip, int sirinaVCm, int visinaVCm, string imeSlike, int osnovnaCena, bool podokvir, string avtorSlike, string opisSlike) : base(tip, sirinaVCm, visinaVCm, imeSlike, osnovnaCena, podokvir, avtorSlike)
        {
            _opisSlike = opisSlike;
        }

        public sealed override string ToString()
        {
            return base.ToString() + "\nOpis slike: " + _opisSlike;
        }

        public override bool jeUnikat()
        {
            return true;
        }
    }
}
