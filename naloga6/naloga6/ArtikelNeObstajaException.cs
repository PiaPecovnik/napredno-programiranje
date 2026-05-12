namespace naloga6
{
    class ArtikelNeObstajaException : Exception
    {
        public ArtikelNeObstajaException(string _message) : base(DateTime.Now.ToLocalTime() + _message)
        {

        }

        /*  mozen overload konstruktorjev

        public ArtikelNeObstajaException()
        {

        }

        public ArtikelNeObstajaException(string _message) : base(DateTime.Now.ToLocalTime() + "NAPAKA! Artikel ne obstaja v zalogi.")
        {

        }
        */
    }
}