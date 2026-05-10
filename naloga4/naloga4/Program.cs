using System.Data;

namespace naloga4;

class Program
{
    static void Main(string[] args)
    {
        UnikatnaSlika novaSlika = new UnikatnaSlika(Tip.pastel, 30, 20, "Mona", 400, true, "Kona Skovik", "opis nove slike");
        OkvirSlike novOkvir = new OkvirSlike("Okvir", MaterialOkvirja.umetnaMasa, 3);
        ZascitaSlike novaZascita = new ZascitaSlike("Zascita", MaterialZascite.steklo, 4);

        Narocilo novoNarocilo = new Narocilo("1", novaSlika, novOkvir, novaZascita, "14.05.2023", 3, true);

        Oseba novaOseba = new Oseba("Jure", "Kovac", SpolOsebe.moski, "13.05.2001", "jure.kovac@gmail.com", 12345678, false);
        Oseba drugaOseba = new Oseba("Jure", "Kovac", SpolOsebe.moski, "13.05.2001", "jure.kovac@gmail.com", 12345678, false);
        Oseba tretjaOseba = new Oseba("Tinka", "Novak", SpolOsebe.zenska, "09.07,1999", "tinka.novak@gmail.com", 12341234, true);

        Console.WriteLine(novaOseba.Equals(drugaOseba));
        Console.WriteLine(novaOseba.Equals(tretjaOseba));

        List<Artikel> seznamArtiklov = new List<Artikel>();
        seznamArtiklov.Add(novoNarocilo); // Append ni pravi

        Racun racun1 = new Racun(seznamArtiklov, novaOseba, false);
        Racun racun2 = new Racun(seznamArtiklov, novaOseba, false);

        List<Racun> seznamRacunov = new List<Racun>();
        seznamRacunov.Add(racun1); // Append ni pravi
        seznamRacunov.Add(racun2); // Append ni pravi

        SlikarstvoNP slikarstvoNP = new SlikarstvoNP(seznamRacunov, seznamArtiklov);

        slikarstvoNP.ustvariRacun(novaOseba);
        slikarstvoNP.dodajNaRacun(seznamArtiklov, racun1); // Napaka!
        slikarstvoNP.izdajRacun(racun1);
        Console.WriteLine("Št artiklov na zalogi: " + slikarstvoNP.kolicinaArtiklovNaZalogi(Tip.pastel));
        Console.WriteLine("ali je artikel s tem ID na zalogi: " + slikarstvoNP.artikelNaZalogi("2"));
        Console.WriteLine("cena na računu: " + slikarstvoNP.IzračunajCeno(racun1));
    }
}
