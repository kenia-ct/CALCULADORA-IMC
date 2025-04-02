using System.Security.Cryptography;

namespace calculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imc, altura, peso;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtEstatura.Text);
            imc = peso / (altura * altura);
            string categoria = "";
            if (imc < 18.5)
            {
                categoria = "Bajo Peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                categoria = "Peso Normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                categoria = "Sobre Peso";
            }
            else if (imc >= 30 && imc < 35)
            {
                categoria = "Obesidad Tipo 1";
            }
            else if (imc >= 35 && imc < 40)
            {
                categoria = "Obesidad Tipo 2";
            }
            else
            {
                categoria = "Obesidad Tipo 3";
            }
            MessageBox.Show("Su IMC es: " + imc.ToString("0.00") +
           "\nCategoría: " + categoria, "Resultado IMC", MessageBoxButtons.OK);
        }
    }
               }

