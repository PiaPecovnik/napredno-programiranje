using System.Data;

namespace naloga3;

class Program
{
    static void Main(string[] args)
    {
        UnikatnaSlika unikatnaSlika = new UnikatnaSlika();
        ReprodukcijaUmetniskeSlike reprodukcija = new ReprodukcijaUmetniskeSlike();
        OkvirSlike okvirSlike = new OkvirSlike();
        ZascitaSlike zascitaSlike = new ZascitaSlike();
        string datumNarocila = "1.4.2026";
        int rokDobave = 21;
        bool izdano = false;

        Narocilo narocilo = new Narocilo(unikatnaSlika, okvirSlike, zascitaSlike, datumNarocila, rokDobave, izdano);

        Console.WriteLine(unikatnaSlika.jeUnikat() ? "Da" : "Ne"); // ? je kot if stavek
        Console.WriteLine(reprodukcija.jeUnikat() ? "Da" : "Ne");

        // pogoj: unikatnaSlika.jeUnikat() ? se izvede, če je pogoj izpolnjen -> "Da" : se izvede, če pogoj ni izpolnjen -> "Ne"

        Console.WriteLine(narocilo);


    }
}
