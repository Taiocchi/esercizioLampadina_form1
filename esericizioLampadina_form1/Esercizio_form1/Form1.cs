namespace Esercizio_form1
{
    public partial class Form1 : Form
    {
        private Lampadina lampadina;

        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
            lampadina.Altezza1 = pictureBox1.Top;
            lampadina.Altezza2 = pictureBox2.Top;
            lampadina.Stato1 = pictureBox1.Visible;
            lampadina.Stato2 = pictureBox2.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            lampadina.Accendi();
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            lampadina.Spegni();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Alza_Click(object sender, EventArgs e)
        {
            lampadina.Alza();
        }

        private void Abbassa_Click(object sender, EventArgs e)
        {
            lampadina.Abbassa();
        }
    }
    public class Lampadina
    {
        private bool stato1;
        private bool stato2;
        private int altezza1;
        private int altezza2;

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
                if (value >= 0 && value <= 320) // Supponiamo che l'altezza vada da 0 a 100
                    altezza1 = value;
            }
        }
        public int Altezza2
        {
            get { return altezza2; }
            set
            {
                if (value >= 0 && value <= 320) // Supponiamo che l'altezza vada da 0 a 100
                    altezza2 = value;
            }
        }

        public void Accendi()
        {
            Stato2 = false;
            Stato1 = true;
        }

        public void Spegni()
        {
            Stato1 = false;
            Stato2 = true;
        }

        public void Alza()
        {
            Altezza1 += 10;
            Altezza2 += 10;
        }

        public void Abbassa()
        {
            Altezza1 -= 10;
            Altezza2 -= 10;
        }
    }
}
