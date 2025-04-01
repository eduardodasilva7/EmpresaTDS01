using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolhaPagamentoProjeto
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try 
            { 
                double resImpo = 0, resLimpo = 0;
                double salario = Convert.ToDouble(txtSalario.Text);

                if (salario < 2259.20)
                {
                    txtImpostoRenda.Text = "Isento";
                
                }
                else if (salario < 2826.65)
                {
                    resImpo = salario * 7.5 / 100;
                
                }
                else if (salario < 3751.05)
                {
                    resImpo = salario * 15 / 100;
                }
                else if (salario < 4664.68)
                {
                    resImpo = salario * 22.5 / 100;
                }
                else
                {
                    resImpo = salario * 27.5 / 100;
                }

                if (cbbPlanoSaude.Checked == true)
                {
                    salario -=  400;
                }

                if (cbbClube.SelectedIndex == 1) 
                {
                    salario -= 100;
                }
                else if (cbbClube.SelectedIndex == 2)
                {
                    salario -= 50;
                }
                else if (cbbClube.SelectedIndex == 3)
                {
                    salario -= 30;
                }

                txtImpostoRenda.Text = Convert.ToString(resImpo);
                resLimpo = salario - resImpo;
                txtSalarioLiquido.Text = Convert.ToString(resLimpo);
            }
            catch
            {
                MessageBox.Show("Favor inserir o valor para o salário", "Menssagem automática do sistema",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button3);
                cbbPlanoSaude.Checked = false;
                cbbClube.SelectedItem = null;
                txtSalario.Focus();
            }
              

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();
            txtImpostoRenda.Clear();
            txtSalarioLiquido.Clear();
            cbbPlanoSaude.Checked = false;
            txtSalario.Focus();
            cbbClube.SelectedItem = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
