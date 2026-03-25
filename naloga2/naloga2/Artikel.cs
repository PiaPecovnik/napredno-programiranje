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

        public Artikel() : this(new Slika(), new OkvirSlike(), new ZascitaSlike())
        {
        }

        public Artikel(Slika slika, OkvirSlike okvirSlike) : this(slika, okvirSlike, new ZascitaSlike())
        {

        }

        public Artikel(Slika slika, OkvirSlike okvirSlike, ZascitaSlike zascitaSlike)
        {
            _slika = slika;
            _okvirSlike = okvirSlike;
            _zascitaSlike = zascitaSlike;
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

        /* Overload metod - izracun cene artikla */
        public double IzracunCene()
        {
            double cenaOkvirja = (2 * _slika._VisinaVCm + 2 * _slika._SirinaVCm) / 100 * _okvirSlike._CenaZaMeter;
            double cenaZascite = _slika._VisinaVCm * _slika._SirinaVCm / 10000 * _zascitaSlike._CenaNaKvadratniMeter;
            double resitev = _slika._OsnovnaCena + cenaOkvirja + cenaZascite;

            return resitev;
        }

        public double IzracunCene(double DDV)
        {
            double resitev = IzracunCene() * DDV;

            return resitev;
        }

        public double IzracunCene(double DDV, int popust)
        {
            double cenaSPopustom = IzracunCene(DDV) - (IzracunCene(DDV) * popust / 100);

            return cenaSPopustom;
        }

        public double IzracunCene(double DDV, int popust, double stroskiDostave)
        {
            double cenaSStroskiDostave = IzracunCene(DDV, popust) + stroskiDostave;

            return cenaSStroskiDostave;
        }
    }
}