namespace naloga5;

class Program
{
    static void Main(string[] args)
    {
        UnikatnaSlika novaSlika = new UnikatnaSlika(Tip.pastel, 30, 20, "Mona", 400, true, "Kona Skovik", "opis nove slike");
        OkvirSlike novOkvir = new OkvirSlike("Okvir", MaterialOkvirja.umetnaMasa, 3);
        ZascitaSlike novaZascita = new ZascitaSlike("Zascita", MaterialZascite.steklo, 4);

        Narocilo novoNarocilo = new Narocilo("1", novaSlika, novOkvir, novaZascita, "14.05.2023", 3, true);
        Narocilo narocilo2 = new Narocilo("2", novaSlika, novOkvir, novaZascita, "12.05.2023", 4, false);

        Oseba novaOseba = new Oseba("Jure", "Kovac", SpolOsebe.moski, "13.05.2001", "jure.kovac@gmail.com", 12345678, false);
        Oseba drugaOseba = new Oseba("Jure", "Kovac", SpolOsebe.moski, "13.05.2001", "jure.kovac@gmail.com", 12345678, false);
        Oseba tretjaOseba = new Oseba("Tinka", "Novak", SpolOsebe.zenska, "09.07,1999", "tinka.novak@gmail.com", 12341234, true);

        Console.WriteLine(novaOseba.Equals(drugaOseba));
        Console.WriteLine(novaOseba.Equals(tretjaOseba));

        List<Artikel> seznamArtiklov = new List<Artikel>();
        seznamArtiklov.Add(novoNarocilo);

        Racun racun1 = new Racun(seznamArtiklov, novaOseba, false);
        Racun racun2 = new Racun(seznamArtiklov, novaOseba, false);

        List<Racun> seznamRacunov = new List<Racun>();
        seznamRacunov.Add(racun1);
        seznamRacunov.Add(racun2);

        Dictionary<string, Artikel> novaZaloga = new Dictionary<string, Artikel>(); //popravljeno/spremenjeno iz list na dictionary
        // .Add(Key, Value) --> Key je string v najinem primeru oz. IdArtikel, Value pa Artikel
        novaZaloga.Add(narocilo2.IdArtikel, narocilo2); // narocilo2.IdArtikel namesto "2", da se ne zatipkaš in da si ziher da spadata skupi

        SlikarstvoNP slikarstvoNP = new SlikarstvoNP(seznamRacunov, novaZaloga);

        slikarstvoNP.ustvariRacun(novaOseba);
        slikarstvoNP.dodajNaRacun(seznamArtiklov, racun1);
        slikarstvoNP.izdajRacun(racun1);
        Console.WriteLine("Št artiklov na zalogi: " + slikarstvoNP.kolicinaArtiklovNaZalogi(Tip.pastel));
        Console.WriteLine("ali je artikel s tem ID na zalogi: " + slikarstvoNP.artikelNaZalogi("2"));
        Console.WriteLine("cena na računu: " + slikarstvoNP.IzračunajCeno(racun1));
    }
}
