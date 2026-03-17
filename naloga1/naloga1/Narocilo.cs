namespace naloga1
{
    class Narocilo
    {
        private Slika _slika;
        public Slika _Slika
        {
            get { return _slika; }
            set { _slika = value; }
        }
        private OkvirSlike _okvirSlike;
        public OkvirSlike _OkvirSlike
        {
            get { return _okvirSlike; }
            set { _okvirSlike = value; }
        }
        private ZascitaSlike _zascitaSlike;
        public ZascitaSlike _ZascitaSlike
        {
            get { return _zascitaSlike; }
            set { _zascitaSlike = value; }
        }
        private string _datumNarocila;
        public string _DatumNarocila
        {
            get { return _datumNarocila; }
            set { _datumNarocila = value; }
        }
        private int _rokDobave;
        public int _RokDobave
        {
            get { return _rokDobave; }
            set { _rokDobave = value; }
        }
        private bool _izdano;
        public bool _Izdano
        {
            get { return _izdano; }
            set { _izdano = value; }
        }

        public Narocilo()
        {
            _slika = new Slika();
            _okvirSlike = new OkvirSlike();
            _zascitaSlike = new ZascitaSlike();
            _datumNarocila = "";
        }

        public Narocilo(Slika slika, OkvirSlike okvirSlike, ZascitaSlike zascitaSlike, string datumNarocila, int rokDobave, bool izdano)
        {
            _slika = slika;
            _okvirSlike = okvirSlike;
            _zascitaSlike = zascitaSlike;
            _datumNarocila = datumNarocila;
            _rokDobave = rokDobave;
            _izdano = izdano;
        }
        public string IzpisPodatkov()
        {
            string pretvorba = "Ne";
            if (_izdano == true)
            {
                pretvorba = "Da";
            }

            string rezultat = "";
            rezultat += "Podatki o naročilu:\n";
            rezultat += "Slika: " + _slika + "\n";
            rezultat += "Okvir: " + _okvirSlike + "\n";
            rezultat += "Zaščita: " + _zascitaSlike + "\n";
            rezultat += "Datum naročila: " + _datumNarocila + "\n";
            rezultat += "Rok dobave: " + _rokDobave + " dni\n";
            rezultat += "Ali je bilo izdano? " + pretvorba + "\n";

            return rezultat;
        }
    }
}