namespace naloga5
{

    class Racun
    {
        private List<Artikel> seznamArtiklov;
        public List<Artikel> SeznamArtiklov
        {
            get { return seznamArtiklov; }
            set { seznamArtiklov = value; }
        }

        private Oseba oseba;
        public Oseba Oseba
        {
            get { return oseba; }
            set { oseba = value; }
        }

        private bool izdan;
        public bool Izdan
        {
            get { return izdan; }
            set { izdan = value; }
        }

        public Racun() : this([], new Oseba(), false)
        {

        }

        public Racun(List<Artikel> _seznamArtiklov, Oseba _oseba, bool _izdan)
        {
            seznamArtiklov = _seznamArtiklov;
            oseba = _oseba;
            izdan = _izdan;
        }
    }
}