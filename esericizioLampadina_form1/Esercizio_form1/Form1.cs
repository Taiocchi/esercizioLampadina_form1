namespace Esercizio_form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Accendi_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void Spegni_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Alza_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 40;
            pictureBox2.Top -= 40;
        }

        private void Abbassa_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 40;
            pictureBox2.Top += 40;
        }
    }
}