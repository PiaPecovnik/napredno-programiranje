namespace naloga5
{

    public enum Tip
    {
        natisnjena,
        olje,
        pastel,
        akrilna,
        vodena,
        tempera
    }

    abstract class Slika
    {
        private Tip tip;
        public Tip Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        private int sirinaVCm;
        public int SirinaVCm
        {
            get { return sirinaVCm; }
            set { sirinaVCm = value; }
        }
        private int visinaVCm;
        public int VisinaVCm
        {
            get { return visinaVCm; }
            set { visinaVCm = value; }
        }
        private string imeSlike;
        public string ImeSlike
        {
            get { return imeSlike; }
            set { imeSlike = value; }
        }
        private int osnovnaCena;
        public int OsnovnaCena
        {
            get { return osnovnaCena; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Osnovna cena ne sme biti negativna! ");
                osnovnaCena = value;
            }
        }
        private bool podokvir;
        public bool Podokvir
        {
            get { return podokvir; }
            set { podokvir = value; }
        }
        private string avtorSlike;
        public string AvtorSlike
        {
            get { return avtorSlike; }
            set { avtorSlike = value; }
        }

        public Slika() : this(Tip.akrilna, 0, 0, "", 0, false, "")
        {
        }

        public Slika(Tip _tip, string _imeSlike, int _osnovnaCena, string _avtorSlike) : this(_tip, 0, 0, _imeSlike, _osnovnaCena, false, _avtorSlike)
        {
        }

        public Slika(Tip _tip, int _sirinaVCm, int _visinaVCm, string _imeSlike, int _osnovnaCena, bool _podokvir, string _avtorSlike)
        {
            tip = _tip;
            sirinaVCm = _sirinaVCm;
            visinaVCm = _visinaVCm;
            imeSlike = _imeSlike;
            osnovnaCena = _osnovnaCena;
            podokvir = _podokvir;
            avtorSlike = _avtorSlike;
        }

        public override string ToString()
        {
            string pretvorba = "Ne";
            if (podokvir == true)
            {
                pretvorba = "Da";
            }

            string rezultat = "";
            rezultat += "Podatki o sliki:\n";
            rezultat += "Tip/način izdelave slike: " + tip + "\n";
            rezultat += "Širina slike: " + sirinaVCm + "cm\n";
            rezultat += "Višina slike: " + visinaVCm + "cm\n";
            rezultat += "Ime slike: " + imeSlike + "\n";
            rezultat += "Osnovna cena: " + osnovnaCena + " eur\n";
            rezultat += "Ali ima podokvir? " + pretvorba + "\n";
            rezultat += "Avtor slike: " + avtorSlike;

            return rezultat;
        }

        public abstract bool jeUnikat();
    }
}
