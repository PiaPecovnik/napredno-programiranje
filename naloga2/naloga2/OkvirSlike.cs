namespace naloga2
{

    public enum MaterialOkvirja
    {
        les,
        umetnaMasa,
        kovina
    }

    public class OkvirSlike
    {
        private string _imeOkvirja;
        public string _ImeOkvirja
        {
            get { return _imeOkvirja; }
            set { _imeOkvirja = value; }
        }
        private MaterialOkvirja _materialOkvirja;
        public MaterialOkvirja _MaterialOkvirja
        {
            get { return _materialOkvirja; }
            set { _materialOkvirja = value; }
        }
        private int _cenaZaMeter;
        public int _CenaZaMeter
        {
            get { return _cenaZaMeter; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena ne sme biti negativna! ");
                _cenaZaMeter = value;
            }
        }

        public OkvirSlike() : this("", MaterialOkvirja.les, 0)
        {
        }

        public OkvirSlike(MaterialOkvirja materialOkvirja, int cenaZaMeter) : this("", materialOkvirja, cenaZaMeter)
        {
        }

        public OkvirSlike(string imeOkvirja, MaterialOkvirja materialOkvirja, int cenaZaMeter)
        {
            _imeOkvirja = imeOkvirja;
            _materialOkvirja = materialOkvirja;
            _cenaZaMeter = cenaZaMeter;
        }

        public string IzpisPodatkov()
        {
            string rezultat = "";
            rezultat += "Podatki o okvirju:\n";
            rezultat += "Ime okvirja: " + _imeOkvirja + "\n";
            rezultat += "Material okvirja: " + _materialOkvirja + "\n";
            rezultat += "Cena za meter: " + _cenaZaMeter + " eur\n";

            return rezultat;
        }
    }
}