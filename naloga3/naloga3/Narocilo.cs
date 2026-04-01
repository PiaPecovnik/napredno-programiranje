namespace naloga3
{
    class Narocilo : Artikel
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

        public Narocilo(Slika slika, string datumNarocila, bool izdano) : this(slika, new OkvirSlike(), new ZascitaSlike(), datumNarocila, 0, izdano)
        {
        }

        public Narocilo(Slika slika, OkvirSlike okvirSlike, ZascitaSlike zascitaSlike, string datumNarocila, int rokDobave, bool izdano) : base(slika, okvirSlike, zascitaSlike)
        {
            _datumNarocila = datumNarocila;
            _rokDobave = rokDobave;
            _izdano = izdano;
        }

        public sealed override string IzpisPodatkov()
        {
            string pretvorba = "Ne";
            if (_izdano == true)
            {
                pretvorba = "Da";
            }

            string rezultat = "Podatki o naročilu:\n";
            rezultat += base.IzpisPodatkov();

            rezultat += "Datum naročila: " + _datumNarocila + "\n";
            rezultat += "Rok dobave: " + _rokDobave + " dni\n";
            rezultat += "Ali je bilo izdano? " + pretvorba + "\n";

            return rezultat;
        }
    }
}
