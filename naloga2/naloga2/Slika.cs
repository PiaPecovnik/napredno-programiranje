namespace naloga2
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

    public class Slika
    {
        private Tip _tip;
        public Tip _Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }
        private int _sirinaVCm;
        public int _SirinaVCm
        {
            get { return _sirinaVCm; }
            set { _sirinaVCm = value; }
        }
        private int _visinaVCm;
        public int _VisinaVCm
        {
            get { return _visinaVCm; }
            set { _visinaVCm = value; }
        }
        private string _imeSlike;
        public string _ImeSlike
        {
            get { return _imeSlike; }
            set { _imeSlike = value; }
        }
        private int _osnovnaCena;
        public int _OsnovnaCena
        {
            get { return _osnovnaCena; }
            set { if (value < 0)
            throw new ArgumentException("Osnovna cena ne sme biti negativna! ");
                _osnovnaCena = value; }
        }
        private bool _podokvir;
        public bool _Podokvir
        {
            get { return _podokvir; }
            set { _podokvir = value; }
        }
        private string _avtorSlike;
        public string _AvtorSlike
        {
            get { return _avtorSlike; }
            set { _avtorSlike = value; }
        }

        public Slika(Tip tip, int sirinaVCm, int visinaVCm, string imeSlike, int osnovnaCena, bool podokvir, string avtorSlike)
        {
            _tip = tip;
            _sirinaVCm = sirinaVCm;
            _visinaVCm = visinaVCm;
            _imeSlike = imeSlike;
            _osnovnaCena = osnovnaCena;
            _podokvir = podokvir;
            _avtorSlike = avtorSlike;
        }

        public Slika() : this (Tip.akrilna, 0, 0, "", 0, false, "")
        {
        }

        //konstruktor s polovičnimi atributi
        public Slika(Tip tip, string imeSlike, int osnovnaCena, string avtorSlike)
        {
            
        }

        public string IzpisPodatkov()
        {
            string pretvorba = "Ne";
            if (_podokvir == true)
            {
                pretvorba = "Da";
            }

            string rezultat = "";
            rezultat += "Podatki o sliki:\n";
            rezultat += "Tip/način izdelave slike: " + _tip + "\n";
            rezultat += "Širina slike: " + _sirinaVCm + "cm\n";
            rezultat += "Višina slike: " + _visinaVCm + "cm\n";
            rezultat += "Ime slike: " + _imeSlike + "\n";
            rezultat += "Osnovna cena: " + _osnovnaCena + " eur\n";
            rezultat += "Ali ima podokvir? " + pretvorba + "\n";
            rezultat += "Avtor slike: " + _avtorSlike;

            return rezultat;
        }
    }
}