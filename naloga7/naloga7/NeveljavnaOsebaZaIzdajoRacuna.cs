namespace naloga7
{
    class NeveljavnaOsebaZaIzdajoRacuna : Exception
    {
        public NeveljavnaOsebaZaIzdajoRacuna(string _message) : base(DateTime.Now.ToLocalTime() + _message)
        {

        }
    }
}