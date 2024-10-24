namespace Implementazione
{
    public partial class Form1 : Form
    {
        private Gru gru1;
        private Stazione stazione1;

        public Form1()
        {
            InitializeComponent();

            gru1 = new Gru("1", "1", 3, 170, 420);

            stazione1 = new Stazione("1", gru1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1200, 700);
            gru1.AltezzaBraccio = Gancio.Top;
        }

        private void Alza_Click(object sender, EventArgs e)
        {
            stazione1.alzaBraccio();
            AggiornaInterfaccia();
        }

        private void Abbassa_Click(object sender, EventArgs e)
        {
            stazione1.abbassaBraccio();
            AggiornaInterfaccia();
        }
        private void AggiornaInterfaccia()
        {
            Gancio.Top = gru1.AltezzaBraccio;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            gru1.AltezzaBraccio = gru1.AltezzaMinima;
            AggiornaInterfaccia();
        }

        private void Applica_Click(object sender, EventArgs e)
        {
            gru1.AltezzaMassima = Convert.ToInt16(Altezza_Massima.Text);
            gru1.AltezzaMinima = Convert.ToInt16(Altezza_Minima.Text);
            Gancio.Top = gru1.AltezzaMinima; 
        }
    }
}
