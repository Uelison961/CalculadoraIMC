namespace CalculadoraIMC
{
    partial class ResultadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoForm));
            label1 = new Label();
            IMC = new Label();
            Classificacao = new Label();
            Sair = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 65);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 0;
            label1.Text = "resultado:";
            // 
            // IMC
            // 
            IMC.AutoSize = true;
            IMC.BackColor = Color.AliceBlue;
            IMC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IMC.Location = new Point(394, 124);
            IMC.Name = "IMC";
            IMC.Size = new Size(98, 28);
            IMC.TabIndex = 1;
            IMC.Text = "Resultado";
            // 
            // Classificacao
            // 
            Classificacao.AutoSize = true;
            Classificacao.BackColor = Color.AliceBlue;
            Classificacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Classificacao.Location = new Point(394, 175);
            Classificacao.Name = "Classificacao";
            Classificacao.Size = new Size(121, 28);
            Classificacao.TabIndex = 2;
            Classificacao.Text = "Classificacao";
            // 
            // Sair
            // 
            Sair.BackColor = Color.AliceBlue;
            Sair.Location = new Point(462, 257);
            Sair.Name = "Sair";
            Sair.Size = new Size(94, 29);
            Sair.TabIndex = 3;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = false;
            Sair.Click += Sair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, -5);
            label2.Name = "label2";
            label2.Size = new Size(100, 54);
            label2.TabIndex = 4;
            label2.Text = "imc";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 300);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ResultadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(658, 289);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Sair);
            Controls.Add(Classificacao);
            Controls.Add(IMC);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResultadoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IMC;
        private Label Classificacao;
        private Button Sair;
        private Label label2;
        private PictureBox pictureBox1;
    }
}