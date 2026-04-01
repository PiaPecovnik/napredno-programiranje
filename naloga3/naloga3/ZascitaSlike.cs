namespace naloga3
{
    public enum MaterialZascite
    {
        steklo,
        plastika
    }

    public class ZascitaSlike
    {
        private string _imeZascite;
        public string _ImeZascite
        {
            get { return _imeZascite; }
            set { _imeZascite = value; }
        }
        private MaterialZascite _materialZascite;
        public MaterialZascite _MaterialZascite
        {
            get { return _materialZascite; }
            set { _materialZascite = value; }
        }
        private int _cenaNaKvadratniMeter;
        public int _CenaNaKvadratniMeter
        {
            get { return _cenaNaKvadratniMeter; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena ne sme biti negativna! ");
                _cenaNaKvadratniMeter = value;
            }
        }

        public ZascitaSlike() : this("", MaterialZascite.steklo, 0)
        {
        }

        public ZascitaSlike(MaterialZascite materialZascite, int cenaNaKvadratniMeter) : this("", materialZascite, cenaNaKvadratniMeter)
        {
        }

        public ZascitaSlike(string imeZascite, MaterialZascite materialZascite, int cenaNaKvadratniMeter)
        {
            _imeZascite = imeZascite;
            _materialZascite = materialZascite;
            _cenaNaKvadratniMeter = cenaNaKvadratniMeter;
        }

        public string IzpisPodatkov()
        {
            string rezultat = "";
            rezultat += "Podatki o zaščiti slike:\n";
            rezultat += "Ime zaščite: " + _imeZascite + "\n";
            rezultat += "Material zaščite: " + _materialZascite + "\n";
            rezultat += "Cena za kvadratni meter: " + _cenaNaKvadratniMeter + " eur\n";

            return rezultat;
        }
    }
}