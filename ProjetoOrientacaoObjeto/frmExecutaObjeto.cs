using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmExecutaObjeto : Form
    {
        public frmExecutaObjeto()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double resp = 0;
            Calculadora calcSoma = new Calculadora();

            resp = calcSoma.Somar(5,6.7);

            lblResposta.Text = resp.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double resp = 0;
            Calculadora calcSub = new Calculadora();

            resp = calcSub.Subtrair(40.74, 20.55);

            lblResposta.Text = resp.ToString();
        }

        private void btnMutiplicar_Click(object sender, EventArgs e)
        {
            double resp = 0;
            Calculadora calcMult = new Calculadora();

            resp = calcMult.Mutiplicar(40.74, 20.55);

            lblResposta.Text = resp.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double resp = 0;
            Calculadora calcDiv = new Calculadora();

            resp = calcDiv.Dividir(60.74, 5.55);

            lblResposta.Text = resp.ToString();
        }
    }
}
