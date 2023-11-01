
namespace calculadora_de_viagem
{
    partial class FormPrincipal
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
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelValorCombustivel = new System.Windows.Forms.Label();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.labelConsumoVeiculo = new System.Windows.Forms.Label();
            this.txtConsumoVeiculo = new System.Windows.Forms.TextBox();
            this.checkBoxPedagio = new System.Windows.Forms.CheckBox();
            this.labelPedagio = new System.Windows.Forms.Label();
            this.labelInfDados = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalPedagio = new System.Windows.Forms.Label();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(321, 105);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(50, 20);
            this.txtDistancia.TabIndex = 0;
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistancia.Location = new System.Drawing.Point(71, 103);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(83, 20);
            this.labelDistancia.TabIndex = 1;
            this.labelDistancia.Text = "Distancia: ";
            this.labelDistancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelValorCombustivel
            // 
            this.labelValorCombustivel.AutoSize = true;
            this.labelValorCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCombustivel.Location = new System.Drawing.Point(71, 146);
            this.labelValorCombustivel.Name = "labelValorCombustivel";
            this.labelValorCombustivel.Size = new System.Drawing.Size(214, 20);
            this.labelValorCombustivel.TabIndex = 3;
            this.labelValorCombustivel.Text = "Valor do litro do combustivel: ";
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.Location = new System.Drawing.Point(321, 146);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(50, 20);
            this.txtValorCombustivel.TabIndex = 2;
            // 
            // labelConsumoVeiculo
            // 
            this.labelConsumoVeiculo.AutoSize = true;
            this.labelConsumoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsumoVeiculo.Location = new System.Drawing.Point(71, 183);
            this.labelConsumoVeiculo.Name = "labelConsumoVeiculo";
            this.labelConsumoVeiculo.Size = new System.Drawing.Size(163, 20);
            this.labelConsumoVeiculo.TabIndex = 5;
            this.labelConsumoVeiculo.Text = "Consumo do veiculo:  ";
            this.labelConsumoVeiculo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtConsumoVeiculo
            // 
            this.txtConsumoVeiculo.Location = new System.Drawing.Point(321, 183);
            this.txtConsumoVeiculo.Name = "txtConsumoVeiculo";
            this.txtConsumoVeiculo.Size = new System.Drawing.Size(50, 20);
            this.txtConsumoVeiculo.TabIndex = 4;
            this.txtConsumoVeiculo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBoxPedagio
            // 
            this.checkBoxPedagio.AutoSize = true;
            this.checkBoxPedagio.Location = new System.Drawing.Point(321, 226);
            this.checkBoxPedagio.Name = "checkBoxPedagio";
            this.checkBoxPedagio.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPedagio.TabIndex = 6;
            this.checkBoxPedagio.UseVisualStyleBackColor = true;
            this.checkBoxPedagio.CheckedChanged += new System.EventHandler(this.checkBoxPedagio_CheckedChanged);
            // 
            // labelPedagio
            // 
            this.labelPedagio.AutoSize = true;
            this.labelPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedagio.Location = new System.Drawing.Point(71, 220);
            this.labelPedagio.Name = "labelPedagio";
            this.labelPedagio.Size = new System.Drawing.Size(242, 20);
            this.labelPedagio.TabIndex = 7;
            this.labelPedagio.Text = "Acrescentar gastos com pedágio";
            // 
            // labelInfDados
            // 
            this.labelInfDados.AutoSize = true;
            this.labelInfDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelInfDados.Location = new System.Drawing.Point(131, 27);
            this.labelInfDados.Name = "labelInfDados";
            this.labelInfDados.Size = new System.Drawing.Size(192, 31);
            this.labelInfDados.TabIndex = 8;
            this.labelInfDados.Text = "Informe Dados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(92, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular gasto da viagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTotalPedagio
            // 
            this.labelTotalPedagio.AutoSize = true;
            this.labelTotalPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPedagio.Location = new System.Drawing.Point(71, 270);
            this.labelTotalPedagio.Name = "labelTotalPedagio";
            this.labelTotalPedagio.Size = new System.Drawing.Size(199, 20);
            this.labelTotalPedagio.TabIndex = 10;
            this.labelTotalPedagio.Text = "Total gasto com pedágios: ";
            this.labelTotalPedagio.Visible = false;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Location = new System.Drawing.Point(321, 272);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(50, 20);
            this.txtPedagio.TabIndex = 11;
            this.txtPedagio.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(377, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Km";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(377, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Km/L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(285, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(285, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "R$";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.labelTotalPedagio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInfDados);
            this.Controls.Add(this.labelPedagio);
            this.Controls.Add(this.checkBoxPedagio);
            this.Controls.Add(this.labelConsumoVeiculo);
            this.Controls.Add(this.txtConsumoVeiculo);
            this.Controls.Add(this.labelValorCombustivel);
            this.Controls.Add(this.txtValorCombustivel);
            this.Controls.Add(this.labelDistancia);
            this.Controls.Add(this.txtDistancia);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Calculadora de Viagem";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelValorCombustivel;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.Label labelConsumoVeiculo;
        private System.Windows.Forms.TextBox txtConsumoVeiculo;
        private System.Windows.Forms.CheckBox checkBoxPedagio;
        private System.Windows.Forms.Label labelPedagio;
        private System.Windows.Forms.Label labelInfDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalPedagio;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

