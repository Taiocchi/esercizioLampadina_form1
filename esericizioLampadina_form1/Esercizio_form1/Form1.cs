namespace Esercizio_form1
{
    public partial class Form1 : Form
    {
        private Lampadina lampadina;

        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaUI();
        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            lampadina.Accendi();
            AggiornaUI(); 
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            lampadina.Spegni();
            AggiornaUI(); 
        }

        private void Alza_Click(object sender, EventArgs e)
        {
            lampadina.Alza();
            AggiornaUI(); 
        }

        private void Abbassa_Click(object sender, EventArgs e)
        {
            lampadina.Abbassa();
            AggiornaUI(); 
        }

        private void AggiornaUI()
        {
            pictureBox1.Visible = lampadina.Stato1;
            pictureBox2.Visible = lampadina.Stato2;

            pictureBox1.Top = lampadina.Altezza1;
            pictureBox2.Top = lampadina.Altezza2;
        }
    }

    public class Lampadina
    {
        private bool stato1 = false;
        private bool stato2 = true;
        private int altezza1 = 121;
        private int altezza2 = 121;

        public bool Stato1
        {
            get { return stato1; }
            set { stato1 = value; }
        }
        public bool Stato2
        {
            get { return stato2; }
            set { stato2 = value; }
        }

        public int Altezza1
        {
            get { return altezza1; }
            set
            {
                if (value >= 0 && value <= 320)
                    altezza1 = value;
            }
        }
        public int Altezza2
        {
            get { return altezza2; }
            set
            {
                if (value >= 0 && value <= 320)
                    altezza2 = value;
            }
        }

        public void Accendi()
        {
            Stato1 = true;
            Stato2 = false;
        }

        public void Spegni()
        {
            Stato1 = false;
            Stato2 = true;
        }

        public void Alza()
        {
            Altezza1 -= 10;
            Altezza2 -= 10;
        }

        public void Abbassa()
        {
            // Aumenta le altezze, ma solo se non superano il limite superiore
            Altezza1 += 10;
            Altezza2 += 10;
        }
    }
}
