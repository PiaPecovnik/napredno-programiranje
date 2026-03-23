namespace naloga2
{
    class Program
    {

        static void Main(string[] args)
        {
            Slika prvaSlika = new Slika(Tip.olje, 50, 30, "Tesnoba", 20000, false, "August Friedrich");
            prvaSlika.IzpisPodatkov();
            Slika drugaSlika = new Slika(Tip.pastel, 65, 87, "Pred lovom", 5000, true, "Jurij Šubic");
            drugaSlika.IzpisPodatkov();
            Slika tretjaSlika = new Slika(Tip.vodena, 47, 36, "Modri čoln", 800, false, "Winslow Homer");
            tretjaSlika.IzpisPodatkov();

            OkvirSlike prviOkvir = new OkvirSlike("Trske", MaterialOkvirja.les, 31);
            prviOkvir.IzpisPodatkov();
            OkvirSlike drugiOkvir = new OkvirSlike("Gladina", MaterialOkvirja.kovina, 25);
            drugiOkvir.IzpisPodatkov();
            OkvirSlike tretjiOkvir = new OkvirSlike("Misterij", MaterialOkvirja.umetnaMasa, 21);
            tretjiOkvir.IzpisPodatkov();

            ZascitaSlike prvaZascita = new ZascitaSlike("Trske", MaterialZascite.steklo, 20);
            prvaZascita.IzpisPodatkov();
            ZascitaSlike drugaZascita = new ZascitaSlike("Gladina", MaterialZascite.steklo, 20);
            drugaZascita.IzpisPodatkov();
            ZascitaSlike tretjaZascita = new ZascitaSlike("Misterij", MaterialZascite.plastika, 12);
            tretjaZascita.IzpisPodatkov();

            Artikel prviArtikel = new Artikel(prvaSlika, prviOkvir, prvaZascita);
            prviArtikel.IzpisPodatkov();
            Artikel drugiArtikel = new Artikel(drugaSlika, drugiOkvir, drugaZascita);
            drugiArtikel.IzpisPodatkov();
            Artikel tretjiArtikel = new Artikel(tretjaSlika, tretjiOkvir, tretjaZascita);
            tretjiArtikel.IzpisPodatkov();

            Narocilo prvoNarocilo = new Narocilo(prvaSlika, prviOkvir, prvaZascita, "09.03.2026", 10, false);
            prvoNarocilo.IzpisPodatkov();
            Narocilo drugoNarocilo = new Narocilo(drugaSlika, drugiOkvir, drugaZascita, "23.11.2026", 22, true);
            drugoNarocilo.IzpisPodatkov();
            Narocilo tretjeNarocilo = new Narocilo(tretjaSlika, tretjiOkvir, tretjaZascita, "13.6.2026", 6, true);
            tretjeNarocilo.IzpisPodatkov();
        }
    }
}