
namespace Calc
{
    partial class FrmPrincipal
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
            this.Lbl_1valor = new System.Windows.Forms.Label();
            this.Txt_2valor = new System.Windows.Forms.TextBox();
            this.Btn_somar = new System.Windows.Forms.Button();
            this.Btn_subtrair = new System.Windows.Forms.Button();
            this.Btn_multiplicar = new System.Windows.Forms.Button();
            this.Btn_dividir = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_2valor = new System.Windows.Forms.Label();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Lbl_mostar = new System.Windows.Forms.Label();
            this.Txt_1valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_1valor
            // 
            this.Lbl_1valor.AutoSize = true;
            this.Lbl_1valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_1valor.Location = new System.Drawing.Point(30, 23);
            this.Lbl_1valor.Name = "Lbl_1valor";
            this.Lbl_1valor.Size = new System.Drawing.Size(99, 13);
            this.Lbl_1valor.TabIndex = 0;
            this.Lbl_1valor.Text = "Digite o 1º valor";
            // 
            // Txt_2valor
            // 
            this.Txt_2valor.Location = new System.Drawing.Point(33, 119);
            this.Txt_2valor.Name = "Txt_2valor";
            this.Txt_2valor.Size = new System.Drawing.Size(100, 20);
            this.Txt_2valor.TabIndex = 1;
            // 
            // Btn_somar
            // 
            this.Btn_somar.Location = new System.Drawing.Point(308, 23);
            this.Btn_somar.Name = "Btn_somar";
            this.Btn_somar.Size = new System.Drawing.Size(75, 23);
            this.Btn_somar.TabIndex = 2;
            this.Btn_somar.Text = "Somar";
            this.Btn_somar.UseVisualStyleBackColor = true;
            this.Btn_somar.Click += new System.EventHandler(this.Btn_somar_Click);
            // 
            // Btn_subtrair
            // 
            this.Btn_subtrair.Location = new System.Drawing.Point(308, 66);
            this.Btn_subtrair.Name = "Btn_subtrair";
            this.Btn_subtrair.Size = new System.Drawing.Size(75, 23);
            this.Btn_subtrair.TabIndex = 3;
            this.Btn_subtrair.Text = "Subtrair";
            this.Btn_subtrair.UseVisualStyleBackColor = true;
            this.Btn_subtrair.Click += new System.EventHandler(this.Btn_subtrair_Click);
            // 
            // Btn_multiplicar
            // 
            this.Btn_multiplicar.Location = new System.Drawing.Point(308, 106);
            this.Btn_multiplicar.Name = "Btn_multiplicar";
            this.Btn_multiplicar.Size = new System.Drawing.Size(75, 23);
            this.Btn_multiplicar.TabIndex = 4;
            this.Btn_multiplicar.Text = "Multiplicar";
            this.Btn_multiplicar.UseVisualStyleBackColor = true;
            this.Btn_multiplicar.Click += new System.EventHandler(this.Btn_multiplicar_Click);
            // 
            // Btn_dividir
            // 
            this.Btn_dividir.Location = new System.Drawing.Point(308, 148);
            this.Btn_dividir.Name = "Btn_dividir";
            this.Btn_dividir.Size = new System.Drawing.Size(75, 23);
            this.Btn_dividir.TabIndex = 5;
            this.Btn_dividir.Text = "Dividir";
            this.Btn_dividir.UseVisualStyleBackColor = true;
            this.Btn_dividir.Click += new System.EventHandler(this.Btn_dividir_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(308, 195);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 6;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_2valor
            // 
            this.Lbl_2valor.AutoSize = true;
            this.Lbl_2valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_2valor.Location = new System.Drawing.Point(30, 89);
            this.Lbl_2valor.Name = "Lbl_2valor";
            this.Lbl_2valor.Size = new System.Drawing.Size(99, 13);
            this.Lbl_2valor.TabIndex = 7;
            this.Lbl_2valor.Text = "Digite o 2º valor";
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resultado.Location = new System.Drawing.Point(30, 153);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(64, 13);
            this.Lbl_resultado.TabIndex = 8;
            this.Lbl_resultado.Text = "Resultado";
            // 
            // Lbl_mostar
            // 
            this.Lbl_mostar.AutoSize = true;
            this.Lbl_mostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostar.Location = new System.Drawing.Point(41, 185);
            this.Lbl_mostar.Name = "Lbl_mostar";
            this.Lbl_mostar.Size = new System.Drawing.Size(0, 31);
            this.Lbl_mostar.TabIndex = 9;
            // 
            // Txt_1valor
            // 
            this.Txt_1valor.Location = new System.Drawing.Point(32, 55);
            this.Txt_1valor.Name = "Txt_1valor";
            this.Txt_1valor.Size = new System.Drawing.Size(100, 20);
            this.Txt_1valor.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.Txt_1valor);
            this.Controls.Add(this.Lbl_mostar);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Lbl_2valor);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_dividir);
            this.Controls.Add(this.Btn_multiplicar);
            this.Controls.Add(this.Btn_subtrair);
            this.Controls.Add(this.Btn_somar);
            this.Controls.Add(this.Txt_2valor);
            this.Controls.Add(this.Lbl_1valor);
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Label Lbl1Valor;
        private System.Windows.Forms.TextBox Txt1valor;
        private System.Windows.Forms.Label Lbl2Valor;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox Txt2Valor;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Label Lbl_1valor;
        private System.Windows.Forms.TextBox Txt_2valor;
        private System.Windows.Forms.Button Btn_somar;
        private System.Windows.Forms.Button Btn_subtrair;
        private System.Windows.Forms.Button Btn_multiplicar;
        private System.Windows.Forms.Button Btn_dividir;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_2valor;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Label Lbl_mostar;
        private System.Windows.Forms.TextBox Txt_1valor;
    }
}

