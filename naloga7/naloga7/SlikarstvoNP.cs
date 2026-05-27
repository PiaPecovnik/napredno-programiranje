namespace naloga7
{

    class SlikarstvoNP : IProdajni
    {
        private List<Racun> izdaniRacuni;
        public List<Racun> IzdaniRacuni
        {
            get { return izdaniRacuni; }
            set { izdaniRacuni = value; }
        }

        private Dictionary<string, Narocilo> zaloga;
        public Dictionary<string, Narocilo> Zaloga
        {
            get { return zaloga; }
            set { zaloga = value; }
        }

        public SlikarstvoNP() : this([], [])
        {

        }
        public SlikarstvoNP(List<Racun> _izdaniRacuni, Dictionary<string, Narocilo> _zaloga)
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
            foreach (Narocilo narocilo in seznamArtiklov.ToList())
            {
                if (zaloga.ContainsValue(narocilo))
                {
                    racun.SeznamArtiklov.Add(narocilo);
                    zaloga.Remove(narocilo.IdArtikel);
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

            foreach (KeyValuePair<string, Narocilo> narocilo in zaloga)
            {
                if (narocilo.Value.Slika.Tip == tipSlike) // dodan .Value
                {
                    steviloArtNaZalogi++;
                }
            }
            return steviloArtNaZalogi;
        }

        public bool artikelNaZalogi(string id)
        {
            foreach (KeyValuePair<string, Narocilo> narocilo in zaloga)
            {
                if (narocilo.Key == id)
                {
                    return true;
                }
            }
            return false;
        }

        public double IzračunajCeno(Racun racun)
        {
            double koncnaCena = 0;
            foreach (Narocilo narocilo in racun.SeznamArtiklov)
            {
                if (racun.Oseba.OsebaJeDavcniZavezanec)
                {
                    if (0 >= racun.Oseba.DavcnaStevilka)
                    {
                        throw new NeveljavnaOsebaZaIzdajoRacuna(" NAPAKA! Oseba je neveljavna za izdajo računa - davčni zavezanec brez davčne številke. ");
                    }
                    koncnaCena += narocilo.IzracunCene(1.22);
                }
                else { koncnaCena += narocilo.IzracunCene(); }
            }
            return koncnaCena;
        }

        public List<Narocilo> poisciNarocilaVObdobju(string datumZacetek, string datumKonec)
        {
            DateTime zacetek = DateTime.Parse(datumZacetek);
            DateTime konec = DateTime.Parse(datumKonec);

            List<Narocilo> ustreznaNarocila = zaloga
                .Select(element => element.Value)
                .Where(narocilo =>
                {
                    DateTime datum = DateTime.Parse(narocilo.DatumNarocila);
                    return datum > zacetek && datum < konec;
                })
                .ToList();

            return ustreznaNarocila;
        }

        public List<Narocilo> neizdanaNarocila()
        {
            List<Narocilo> ustreznaNarocila = zaloga
                .Select(element => element.Value)
                .Where(narocilo => !narocilo.Izdano) // je isto kot narocilo.Izdano == false
                .ToList();

            return ustreznaNarocila;
        }

        public void izbrisNarocilBrezSlike()
        {
            List<string> keys = zaloga
              .Where(element => element.Value.Slika == null)
              .Select(element => element.Key)
              .ToList();

            foreach (string key in keys)
            {
                zaloga.Remove(key);
            }
        }

        public void izpisNarocil()
        {
            List<Narocilo> vsaNarocila = zaloga
                .Select(element => element.Value)
                .ToList();

            foreach (var narocilo in vsaNarocila)
            {
                Console.WriteLine(narocilo.ToString());
            }
        }
    }
}