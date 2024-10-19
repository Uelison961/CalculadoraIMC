using System;
using System.Collections.Generic;


namespace CalculadoraIMC
{

    public partial class ResultadoForm : Form
    {
        public ResultadoForm(double imc, string classificacao)
        {
            InitializeComponent();

          
            IMC.Text = "IMC: " + imc.ToString("F2"); 
            Classificacao.Text = classificacao;      
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}