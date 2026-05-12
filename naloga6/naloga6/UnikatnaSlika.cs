namespace naloga6
{
    class UnikatnaSlika : Slika
    {
        private string opisSlike;
        public string OpisSlike
        {
            get { return opisSlike; }
            set { opisSlike = value; }
        }

        public UnikatnaSlika() : this(Tip.akrilna, 30, 30, "CeLaVie", 280, false, "Mario Cena", "Opis slike CeLaVie")
        {
        }

        public UnikatnaSlika(Tip _tip, string _imeSlike, bool _podokvir, string _avtorSlike) : this(_tip, 30, 30, _imeSlike, 280, _podokvir, _avtorSlike, "Opis slike CeLaVie")
        {
        }

        public UnikatnaSlika(Tip _tip, int _sirinaVCm, int _visinaVCm, string _imeSlike, int _osnovnaCena, bool _podokvir, string _avtorSlike, string _opisSlike) : base(_tip, _sirinaVCm, _visinaVCm, _imeSlike, _osnovnaCena, _podokvir, _avtorSlike)
        {
            opisSlike = _opisSlike;
        }

        public sealed override string ToString()
        {
            return base.ToString() + "\nOpis slike: " + opisSlike;
        }

        public override bool jeUnikat()
        {
            return true;
        }
    }
}
