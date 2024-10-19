namespace CalculadoraIMC
{
    public partial class CalculadoraIMC : Form
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida��o de Peso a partir de um TextBox (por exemplo, txtPeso)
                if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
                {
                    MessageBox.Show("Por favor, insira um valor v�lido para o peso.");
                    return;
                }

                if (!double.TryParse(txtAltura.Text, out double altura) || altura <= 0)
                {
                    MessageBox.Show("Por favor, insira um valor v�lido para a altura.");
                    return;
                }

                MessageBox.Show($"Peso: {peso}, Altura: {altura}");

                double imc = peso / (altura * altura);

                MessageBox.Show($"IMC Calculado: {imc}");


                string classificacao;
                if (imc < 18.5)
                {
                    classificacao = "Classifica��o: Abaixo do peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    classificacao = "Classifica��o: Peso normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    classificacao = "Classifica��o: Sobrepeso";
                }
                else
                {
                    classificacao = "Classifica��o: Obesidade";
                }

                this.Hide();


                ResultadoForm resultado = new ResultadoForm(imc, classificacao);
                resultado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o IMC: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}