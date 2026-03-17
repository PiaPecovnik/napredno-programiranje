namespace naloga1
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
            set { _cenaZaMeter = value; }
        }

        public OkvirSlike()
        {
            _imeOkvirja = "";
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