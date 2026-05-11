namespace naloga5
{
    interface IProdajni
    {
        void ustvariRacun(Oseba oseba);
        void dodajNaRacun(List<Artikel> seznamArtiklov, Racun racun);
        void izdajRacun(Racun racun);
        int kolicinaArtiklovNaZalogi(Tip tip);
        bool artikelNaZalogi(string id);
        double IzračunajCeno(Racun racun);
    }
}