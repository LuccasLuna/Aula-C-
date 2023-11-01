
namespace tabuada
{
    partial class FrmTabuada
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
            this.textNum = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.listResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(120, 51);
            this.textNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(76, 26);
            this.textNum.TabIndex = 0;
            this.textNum.TextChanged += new System.EventHandler(this.textNum_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(242, 51);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(112, 26);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click_1);
            // 
            // listResultados
            // 
            this.listResultados.FormattingEnabled = true;
            this.listResultados.ItemHeight = 20;
            this.listResultados.Location = new System.Drawing.Point(120, 87);
            this.listResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listResultados.Name = "listResultados";
            this.listResultados.Size = new System.Drawing.Size(234, 264);
            this.listResultados.TabIndex = 2;
            // 
            // FrmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 391);
            this.Controls.Add(this.listResultados);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.textNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTabuada";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.ListBox listResultados;
    }
}

