using System.Diagnostics;

namespace calcu
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string ope;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ope = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ope = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ope = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ope = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (ope)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
    }
}