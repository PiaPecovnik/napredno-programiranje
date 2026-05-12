namespace naloga6
{
    class RacunJeZeIzdanException : Exception
    {
        public RacunJeZeIzdanException(string _message) : base(DateTime.Now.ToLocalTime() + _message)
        {

        }


        /*  mozno je delat tut overload konstruktorjev v exception-ih
        public RacunJeZeIzdanException()
        {

        }

        public RacunJeZeIzdanException(string _message) : base(DateTime.Now + " NAPAKA! Račun je že izdan. " + _message)
        {

        }
        */
    }
}