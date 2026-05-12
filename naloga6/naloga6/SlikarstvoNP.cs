namespace naloga6
{

    class SlikarstvoNP : IProdajni
    {
        private List<Racun> izdaniRacuni;
        public List<Racun> IzdaniRacuni
        {
            get { return izdaniRacuni; }
            set { izdaniRacuni = value; }
        }

        private Dictionary<string, Artikel> zaloga;
        public Dictionary<string, Artikel> Zaloga
        {
            get { return zaloga; }
            set { zaloga = value; }
        }

        public SlikarstvoNP() : this([], [])
        {

        }
        public SlikarstvoNP(List<Racun> _izdaniRacuni, Dictionary<string, Artikel> _zaloga)
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
                if (zaloga.ContainsValue(artikel))
                {
                    racun.SeznamArtiklov.Add(artikel);
                    zaloga.Remove(artikel.IdArtikel);
                }
                else
                {
                    throw new ArtikelNeObstajaException(" NAPAKA! Artikel ne obstaja v zalogi.");
                }
            }
        }

        public void izdajRacun(Racun racun)
        {
            if (racun.Izdan)
            {
                throw new RacunJeZeIzdanException(" NAPAKA! Račun je že izdan. ");
            }
            racun.Izdan = true;
        }

        public int kolicinaArtiklovNaZalogi(Tip tipSlike)
        {
            int steviloArtNaZalogi = 0;

            foreach (KeyValuePair<string, Artikel> artikel in zaloga)
            {
                if (artikel.Value.Slika.Tip == tipSlike) // dodan .Value
                {
                    steviloArtNaZalogi++;
                }
            }
            return steviloArtNaZalogi;
        }

        public bool artikelNaZalogi(string id)
        {
            foreach (KeyValuePair<string, Artikel> artikel in zaloga)
            {
                if (artikel.Key == id)
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
                    if (0 >= racun.Oseba.DavcnaStevilka)
                    {
                        throw new NeveljavnaOsebaZaIzdajoRacuna(" NAPAKA! Oseba je neveljavna za izdajo računa - davčni zavezanec brez davčne številke. ");
                    }
                    koncnaCena += artikel.IzracunCene(1.22);
                }
                else { koncnaCena += artikel.IzracunCene(); }
            }
            return koncnaCena;
        }
    }
}