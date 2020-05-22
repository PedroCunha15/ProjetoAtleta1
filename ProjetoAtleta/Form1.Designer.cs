namespace ProjetoAtleta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_idade.Location = new System.Drawing.Point(13, 129);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(86, 13);
            this.lbl_idade.TabIndex = 13;
            this.lbl_idade.Text = "Digite sua idade:";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(102, 126);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 12;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(102, 90);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 11;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_altura.Location = new System.Drawing.Point(12, 93);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(87, 13);
            this.lbl_altura.TabIndex = 10;
            this.lbl_altura.Text = "Digite sua Altura:";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(28, 176);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(159, 20);
            this.btn_calc.TabIndex = 9;
            this.btn_calc.Text = "Calcular IMC";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(102, 52);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 8;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_peso.Location = new System.Drawing.Point(12, 55);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(84, 13);
            this.lbl_peso.TabIndex = 7;
            this.lbl_peso.Text = "Digite seu Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calcular IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(219, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_peso);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label label1;
    }
}

