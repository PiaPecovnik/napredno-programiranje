namespace naloga8;

class Program
{
    static void Main(string[] args)
    {
        Casopis casopis1 = new Casopis();

        Narocnik narocnik1 = new Narocnik("Janez");
        Narocnik narocnik2 = new Narocnik("Maja");
        Narocnik narocnik3 = new Narocnik("Nika");

        narocnik1.NarociSe(casopis1);
        narocnik2.NarociSe(casopis1);
        narocnik3.NarociSe(casopis1);

        narocnik1.OdjaviSe(casopis1);

        casopis1.ObjaviNovico("Novica!");
    }
}
