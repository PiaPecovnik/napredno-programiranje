namespace naloga5
{
    abstract class Artikel
    {
        private Slika slika;
        public Slika Slika
        {
            get { return slika; }
            set { slika = value; }
        }

        private OkvirSlike okvirSlike;
        public OkvirSlike OkvirSlike
        {
            get { return okvirSlike; }
            set { okvirSlike = value; }
        }

        private ZascitaSlike zascitaSlike;
        public ZascitaSlike ZascitaSlike
        {
            get { return zascitaSlike; }
            set { zascitaSlike = value; }
        }

        private string idArtikel;
        public string IdArtikel
        {
            get { return idArtikel; }
            set { idArtikel = value; }
        }

        public Artikel() : this("", new UnikatnaSlika(), new OkvirSlike(), new ZascitaSlike())
        {

        }

        public Artikel(Slika _slika, OkvirSlike _okvirSlike) : this("", _slika, _okvirSlike, new ZascitaSlike())
        {

        }

        public Artikel(string _idArtikel, Slika _slika, OkvirSlike _okvirSlike, ZascitaSlike _zascitaSlike)
        {
            idArtikel = _idArtikel;
            slika = _slika;
            okvirSlike = _okvirSlike;
            zascitaSlike = _zascitaSlike;
        }

        public override string ToString()
        {
            string rezultat = "";
            rezultat += "ID: " + idArtikel + "\n";
            rezultat += "Slika: \n" + slika.ToString() + "\n";
            rezultat += "Okvir: \n" + okvirSlike.ToString() + "\n";
            rezultat += "Zaščita: \n" + zascitaSlike.ToString() + "\n";

            return rezultat;
        }

        /* Overload metod - izracun cene artikla */
        public double IzracunCene()
        {
            double cenaOkvirja = (2 * slika.VisinaVCm + 2 * slika.SirinaVCm) / 100 * okvirSlike.CenaZaMeter;
            double cenaZascite = slika.VisinaVCm * slika.SirinaVCm / 10000 * zascitaSlike.CenaNaKvadratniMeter;
            double resitev = slika.OsnovnaCena + cenaOkvirja + cenaZascite;

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

        public override bool Equals(object? obj) // dobi not ceu objekt 
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Artikel drugiArtikel = (Artikel)obj; // Ga inicializira v Artikel objekt oz. spremenljivko

            return this.IdArtikel == drugiArtikel.IdArtikel; // Primerja Id drugegaArtikla s svojim
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.idArtikel);
        }
    }
}