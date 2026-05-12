namespace naloga6
{

    class Program
    {
        static void Main(string[] args)
        {
            UnikatnaSlika novaSlika = new UnikatnaSlika(Tip.pastel, 30, 20, "Mona", 400, true, "Kona Skovik", "opis nove slike");
            OkvirSlike novOkvir = new OkvirSlike("Okvir", MaterialOkvirja.umetnaMasa, 3);
            ZascitaSlike novaZascita = new ZascitaSlike("Zascita", MaterialZascite.steklo, 4);

            Narocilo novoNarocilo = new Narocilo("1", novaSlika, novOkvir, novaZascita, "14.05.2023", 3, true);
            Narocilo narocilo2 = new Narocilo("2", novaSlika, novOkvir, novaZascita, "12.05.2023", 4, false);

            Oseba novaOseba = new Oseba("Jure", "Kovac", SpolOsebe.moski, "13.05.2001", "jure.kovac@gmail.com", 0, true);

            List<Artikel> seznamArtiklov = new List<Artikel>();
            seznamArtiklov.Add(novoNarocilo);

            List<Racun> seznamRacunov = new List<Racun>();

            try
            {
                Racun racun1 = new Racun(seznamArtiklov, novaOseba, true);
                Racun racun2 = new Racun(seznamArtiklov, novaOseba, false);

                seznamRacunov.Add(racun1);
                seznamRacunov.Add(racun2);

                Dictionary<string, Artikel> novaZaloga = new Dictionary<string, Artikel>(); //popravljeno/spremenjeno iz list na dictionary
                                                                                            // .Add(Key, Value) --> Key je string v najinem primeru oz. IdArtikel, Value pa Artikel
                novaZaloga.Add(narocilo2.IdArtikel, narocilo2); // narocilo2.IdArtikel namesto "2", da se ne zatipkaš in da si ziher da spadata skupi

                SlikarstvoNP slikarstvoNP = new SlikarstvoNP(seznamRacunov, novaZaloga);

                slikarstvoNP.ustvariRacun(novaOseba);
                slikarstvoNP.dodajNaRacun(seznamArtiklov, racun1); // ArtikelNeObstajaException
                slikarstvoNP.izdajRacun(racun1); // RacunJeZeIzdanException
                Console.WriteLine("Št artiklov na zalogi: " + slikarstvoNP.kolicinaArtiklovNaZalogi(Tip.pastel));
                Console.WriteLine("ali je artikel s tem ID na zalogi: " + slikarstvoNP.artikelNaZalogi("2"));
                Console.WriteLine("cena na računu: " + slikarstvoNP.IzračunajCeno(racun1)); // NeveljavnaOsebaZaIzdajoRacunaException
            }
            catch (RacunJeZeIzdanException e)
            {
                Console.WriteLine("RacunJeZeIzdanException: " + e.Message);
            }
            catch (ArtikelNeObstajaException e)
            {
                Console.WriteLine("ArtikelNeObstajaException: " + e.Message);
            }
            catch (NeveljavnaOsebaZaIzdajoRacuna e)
            {
                Console.WriteLine("NeveljavnaOsebaZaIzdajoRacuna: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
