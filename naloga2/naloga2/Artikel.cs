namespace naloga2
{
    public class Artikel
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

        public Artikel(Slika slika, OkvirSlike okvirSlike, ZascitaSlike zascitaSlike)
        {
            _slika = slika;
            _okvirSlike = okvirSlike;
            _zascitaSlike = zascitaSlike;
        }

        //konstruktor s polovičnimi atributi
        public Artikel(Slika slika, OkvirSlike okvirSlike)
        {
            
        }

        public Artikel() : this (new Slika(), new OkvirSlike(), new ZascitaSlike())
        {
        }
        public string IzpisPodatkov()
        {
            string rezultat = "";
            rezultat += "Osnovni podatki artikla:\n";
            rezultat += "Slika: " + _slika + "\n";
            rezultat += "Okvir: " + _okvirSlike + "\n";
            rezultat += "Zaščita: " + _zascitaSlike + "\n";

            return rezultat;
        }
    }
}