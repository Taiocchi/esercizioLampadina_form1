namespace Implementazione
{
    internal class Stazione
    {
        private string numeroSeriale;
        private Gru gru;

        public Gru Gru
        {
            get { return gru; }
            set { gru = value; }
        }

        public string NumeroSeriale
        {
            get { return numeroSeriale; }
        }

        public void alzaBraccio()
        {
            gru.alzaBraccio();
        }

        public void abbassaBraccio()
        {
            gru.abbassaBraccio();
        }

        public void posizioneSicurezza()
        {
            gru.posizioneSicurezza();
        }


        public Stazione(string numeroSeriale, Gru gru)
        {
            this.numeroSeriale = numeroSeriale;
            this.gru = gru;
        }
    }
}
