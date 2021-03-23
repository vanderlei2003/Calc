using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Txt_1valor.Focus();
            Txt_1valor.Select();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_somar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt_1valor.Text);
            valor2 = Convert.ToDouble(Txt_2valor.Text);
            resultado = valor1 + valor2;
            Lbl_mostar.Text = resultado.ToString();
            Txt_1valor.Text = "";
            Txt_2valor.Text = "";
        }

        private void Btn_subtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt_1valor.Text);
            valor2 = Convert.ToDouble(Txt_2valor.Text);
            resultado = valor1 - valor2;
            Lbl_mostar.Text = resultado.ToString();
            Txt_1valor.Text = "";
            Txt_2valor.Text = "";
        }

        private void Btn_multiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt_1valor.Text);
            valor2 = Convert.ToDouble(Txt_2valor.Text);
            resultado = valor1 * valor2;
            Lbl_mostar.Text = resultado.ToString();
            Txt_1valor.Text = "";
            Txt_2valor.Text = "";
        }

        private void Btn_dividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt_1valor.Text);
            valor2 = Convert.ToDouble(Txt_2valor.Text);
            resultado = valor1 / valor2;
            Lbl_mostar.Text = resultado.ToString();
            Txt_1valor.Text = "";
            Txt_2valor.Text = "";
        }
    }
}
