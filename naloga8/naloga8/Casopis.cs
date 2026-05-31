namespace naloga8
{
    public delegate void Obvestilo(string novica);

    class Casopis
    {
        public event Obvestilo? NovaNovica;

        public void ObjaviNovico(string novica)
        {
            NovaNovica?.Invoke(novica);
        }
    }
}