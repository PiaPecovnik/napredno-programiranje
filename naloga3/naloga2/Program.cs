namespace naloga2
{
    class Program
    {

        static void Main(string[] args)
        {
            /* 1. Preverjanje negativne vrednosti v set metodi za osnovno ceno
             Slika slika = new Slika(Tip.olje, 50, 30, "Tesnoba", 20000, false, "August Friedrich");
             slika._OsnovnaCena = -500;
             */

            /* 2. Preverjanje overload konstruktorjev
            Slika slika1 = new Slika();
            Slika slika2 = new Slika(Tip.olje, "Tesnoba", 20000, "August Friedrich");
            Slika slika3 = new Slika(Tip.tempera, 20, 31230, "Mozzarela", 2010, true, "Matjaz Tretji");

            Console.WriteLine("Slika 1 - Privzeti konstruktor");
            Console.WriteLine(slika1.IzpisPodatkov() + "\n");

            Console.WriteLine("Slika 2 - Polovicni konstruktor");
            Console.WriteLine(slika2.IzpisPodatkov() + "\n");

            Console.WriteLine("Slika 3 - Nastavitveni konstruktor");
            Console.WriteLine(slika3.IzpisPodatkov() + "\n");
            */

            /* 3. Preverjanje overload metod
            Slika slika = new Slika(Tip.akrilna, 50, 25, "Poplava", 4000, false, "Anej Zajc");
            OkvirSlike okvirSlike = new OkvirSlike("Gozd", MaterialOkvirja.les, 30);
            ZascitaSlike zascitaSLike = new ZascitaSlike("Steklenina", MaterialZascite.steklo, 13);

            Artikel artikel = new Artikel(slika, okvirSlike, zascitaSLike);

            Console.WriteLine("Cena slike je: " + artikel.IzracunCene());
            Console.WriteLine("Cena slike je: " + artikel.IzracunCene(9.5));
            Console.WriteLine("Cena slike je: " + artikel.IzracunCene(9.5, 20));
            Console.WriteLine("Cena slike je: " + artikel.IzracunCene(9.5, 20, 5));
            */

        }
    }
}