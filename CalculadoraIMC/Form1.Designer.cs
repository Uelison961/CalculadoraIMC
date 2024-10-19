namespace CalculadoraIMC
{
    partial class CalculadoraIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraIMC));
            txtAltura = new TextBox();
            label1 = new Label();
            bntCalcular = new Button();
            label2 = new Label();
            txtPeso = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(300, 82);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(237, 27);
            txtAltura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 41);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 1;
            label1.Text = "Digite a altura em metros:";
            // 
            // bntCalcular
            // 
            bntCalcular.BackColor = Color.Maroon;
            bntCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCalcular.Location = new Point(300, 227);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(102, 43);
            bntCalcular.TabIndex = 2;
            bntCalcular.Text = "Calcular";
            bntCalcular.UseVisualStyleBackColor = false;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 123);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 3;
            label2.Text = "Digite o peso em KG:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(300, 164);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(237, 27);
            txtPeso.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Location = new Point(435, 227);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 6;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 302);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // CalculadoraIMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(549, 306);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(bntCalcular);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculadoraIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculadoraIMC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltura;
        private Label label1;
        private Button bntCalcular;
        private Label label2;
        private TextBox txtPeso;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
