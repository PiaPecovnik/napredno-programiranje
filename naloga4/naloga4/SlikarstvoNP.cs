namespace naloga4
{

    class SlikarstvoNP : IProdajni
    {
        private List<Racun> izdaniRacuni;
        public List<Racun> IzdaniRacuni
        {
            get { return izdaniRacuni; }
            set { izdaniRacuni = value; }
        }

        private List<Artikel> zaloga;
        public List<Artikel> Zaloga
        {
            get { return zaloga; }
            set { zaloga = value; }
        }

        public SlikarstvoNP() : this([], [])
        {

        }
        public SlikarstvoNP(List<Racun> _izdaniRacuni, List<Artikel> _zaloga)
        {
            izdaniRacuni = _izdaniRacuni;
            zaloga = _zaloga;
        }

        public void ustvariRacun(Oseba oseba)
        {
            Racun novRacun = new Racun([], oseba, false);
            izdaniRacuni.Add(novRacun);
        }

        public void dodajNaRacun(List<Artikel> seznamArtiklov, Racun racun)
        {
            foreach (Artikel artikel in seznamArtiklov.ToList())
            {
                if (zaloga.Contains(artikel))
                {
                    racun.SeznamArtiklov.Add(artikel);
                    zaloga.Remove(artikel);
                }
            }
        }

        public void izdajRacun(Racun racun)
        {
            racun.Izdan = true;
        }

        public int kolicinaArtiklovNaZalogi(Tip tipSlike)
        {
            int steviloArtNaZalogi = 0;

            foreach (Artikel artikel in zaloga)
            {
                if (artikel.Slika.Tip == tipSlike)
                {
                    steviloArtNaZalogi++;
                }
            }
            return steviloArtNaZalogi;
        }

        public bool artikelNaZalogi(string id)
        {
            foreach (Artikel artikel in zaloga)
            {
                if (artikel.IdArtikel == id)
                {
                    return true;
                }
            }
            return false;
        }

        public double IzračunajCeno(Racun racun)
        {
            double koncnaCena = 0;
            foreach (Artikel artikel in racun.SeznamArtiklov)
            {
                if (racun.Oseba.OsebaJeDavcniZavezanec)
                {
                    koncnaCena += artikel.IzracunCene(1.22);
                }
                else { koncnaCena += artikel.IzracunCene(); }
            }
            return koncnaCena;
        }
    }
}