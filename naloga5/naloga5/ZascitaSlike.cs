namespace naloga5
{
    public enum MaterialZascite
    {
        steklo,
        plastika
    }

    public class ZascitaSlike
    {
        private string imeZascite;
        public string ImeZascite
        {
            get { return imeZascite; }
            set { imeZascite = value; }
        }
        private MaterialZascite materialZascite;
        public MaterialZascite MaterialZascite
        {
            get { return materialZascite; }
            set { materialZascite = value; }
        }
        private int cenaNaKvadratniMeter;
        public int CenaNaKvadratniMeter
        {
            get { return cenaNaKvadratniMeter; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena ne sme biti negativna! ");
                cenaNaKvadratniMeter = value;
            }
        }

        public ZascitaSlike() : this("", MaterialZascite.steklo, 0)
        {
        }

        public ZascitaSlike(MaterialZascite _materialZascite, int _cenaNaKvadratniMeter) : this("", _materialZascite, _cenaNaKvadratniMeter)
        {
        }

        public ZascitaSlike(string _imeZascite, MaterialZascite _materialZascite, int _cenaNaKvadratniMeter)
        {
            imeZascite = _imeZascite;
            materialZascite = _materialZascite;
            cenaNaKvadratniMeter = _cenaNaKvadratniMeter;
        }

        public override string ToString()
        {
            string rezultat = "";
            rezultat += "Podatki o zaščiti slike:\n";
            rezultat += "Ime zaščite: " + imeZascite + "\n";
            rezultat += "Material zaščite: " + materialZascite + "\n";
            rezultat += "Cena za kvadratni meter: " + cenaNaKvadratniMeter + " eur\n";

            return rezultat;
        }
    }
}