namespace naloga5
{
    class Narocilo : Artikel
    {
        private string datumNarocila;
        public string DatumNarocila
        {
            get { return datumNarocila; }
            set { datumNarocila = value; }
        }
        private int rokDobave;
        public int RokDobave
        {
            get { return rokDobave; }
            set { rokDobave = value; }
        }
        private bool izdano;
        public bool Izdano
        {
            get { return izdano; }
            set { izdano = value; }
        }

        public Narocilo() : this("1", new UnikatnaSlika(), new OkvirSlike(), new ZascitaSlike(), "", 0, false)
        {
        }

        public Narocilo(Slika _slika, string _datumNarocila, bool _izdano) : this("1", _slika, new OkvirSlike(), new ZascitaSlike(), _datumNarocila, 0, _izdano)
        {
        }

        public Narocilo(string _idArtikel, Slika _slika, OkvirSlike _okvirSlike, ZascitaSlike _zascitaSlike, string _datumNarocila, int _rokDobave, bool _izdano) : base(_idArtikel, _slika, _okvirSlike, _zascitaSlike)
        {
            datumNarocila = _datumNarocila;
            rokDobave = _rokDobave;
            izdano = _izdano;
        }

        public sealed override string ToString()
        {
            string pretvorba = "Ne";
            if (izdano == true)
            {
                pretvorba = "Da";
            }

            string rezultat = "Podatki o naročilu:\n";
            rezultat += base.ToString();

            rezultat += "Datum naročila: " + datumNarocila + "\n";
            rezultat += "Rok dobave: " + rokDobave + " dni\n";
            rezultat += "Ali je bilo izdano? " + pretvorba + "\n";

            return rezultat;
        }
    }
}
