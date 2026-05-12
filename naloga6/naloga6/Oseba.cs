namespace naloga6
{
    public enum SpolOsebe
    {
        drugo,
        zenska,
        moski
    }

    class Oseba
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string priimek;
        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        private SpolOsebe spol;
        public SpolOsebe Spol
        {
            get { return spol; }
            set { spol = value; }
        }

        private string datumRojstva;
        public string DatumRojstva
        {
            get { return datumRojstva; }
            set { datumRojstva = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int davcnaStevilka;
        public int DavcnaStevilka
        {
            get { return davcnaStevilka; }
            set { davcnaStevilka = value; }
        }

        private bool osebaJeDavcniZavezanec;
        public bool OsebaJeDavcniZavezanec
        {
            get { return osebaJeDavcniZavezanec; }
            set { osebaJeDavcniZavezanec = value; }
        }

        public Oseba() : this("", "", SpolOsebe.drugo, "", "", 0, false)
        {

        }

        public Oseba(string _ime, string _priimek, SpolOsebe _spol, string _datumRojstva, string _email, int _davcnaStevilka, bool _osebaJeDavcniZavezanec)
        {
            ime = _ime;
            priimek = _priimek;
            spol = _spol;
            datumRojstva = _datumRojstva;
            email = _email;
            davcnaStevilka = _davcnaStevilka;
            osebaJeDavcniZavezanec = _osebaJeDavcniZavezanec;
        }

        public override bool Equals(object? drugaOseba)
        {
            if (drugaOseba == null || GetType() != drugaOseba.GetType())
            {
                return false;
            }

            Oseba druga = (Oseba)drugaOseba;
            return this.davcnaStevilka == druga.davcnaStevilka;
        }

        public override int GetHashCode()
        {
            return this.davcnaStevilka.GetHashCode();
        }
    }
}