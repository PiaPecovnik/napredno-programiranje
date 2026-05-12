namespace naloga6
{

    public enum MaterialOkvirja
    {
        les,
        umetnaMasa,
        kovina
    }

    public class OkvirSlike
    {
        private string imeOkvirja;
        public string ImeOkvirja
        {
            get { return imeOkvirja; }
            set { imeOkvirja = value; }
        }
        private MaterialOkvirja materialOkvirja;
        public MaterialOkvirja MaterialOkvirja
        {
            get { return materialOkvirja; }
            set { materialOkvirja = value; }
        }
        private int cenaZaMeter;
        public int CenaZaMeter
        {
            get { return cenaZaMeter; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cena ne sme biti negativna! ");
                cenaZaMeter = value;
            }
        }

        public OkvirSlike() : this("", MaterialOkvirja.les, 0)
        {
        }

        public OkvirSlike(MaterialOkvirja _materialOkvirja, int _cenaZaMeter) : this("", _materialOkvirja, _cenaZaMeter)
        {
        }

        public OkvirSlike(string _imeOkvirja, MaterialOkvirja _materialOkvirja, int _cenaZaMeter)
        {
            imeOkvirja = _imeOkvirja;
            materialOkvirja = _materialOkvirja;
            cenaZaMeter = _cenaZaMeter;
        }

        public override string ToString()
        {
            string rezultat = "";
            rezultat += "Podatki o okvirju:\n";
            rezultat += "Ime okvirja: " + imeOkvirja + "\n";
            rezultat += "Material okvirja: " + materialOkvirja + "\n";
            rezultat += "Cena za meter: " + cenaZaMeter + " eur\n";

            return rezultat;
        }
    }
}