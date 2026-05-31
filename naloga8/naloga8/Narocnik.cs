namespace naloga8
{
    class Narocnik
    {
        private string imeNarocnika;
        public string ImeNarocnika
        {
            get { return imeNarocnika; }
            set { imeNarocnika = value; }
        }

        public Narocnik(string _imeNarocnika)
        {
            imeNarocnika = _imeNarocnika;
        }

        public void NarociSe(Casopis casopis)
        {
            casopis.NovaNovica += IzpisiNovico;
        }
        public void OdjaviSe(Casopis casopis)
        {
            casopis.NovaNovica -= IzpisiNovico;
        }
        public void IzpisiNovico(string novica)
        {
            Console.WriteLine($"{ImeNarocnika} je prejel novico: {novica}");
        }
    }
}