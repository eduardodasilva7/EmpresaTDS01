using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, idade, altura, imc;
            try
            {
                peso = Convert.ToDouble(txtPeso.Text);
                idade = Convert.ToDouble(txtIdade.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                imc = (peso / (altura * altura)) * 10000;

                if (ccbM.Checked)
                {

                    if (imc < 20)
                    {
                        txtIMC.Text = $"Seu peso está abaixo do que deveria. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 24.9)
                    {
                        txtIMC.Text = $"Seu peso está normal. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 29.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade leve. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 39.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade moderada. Seu IMC é de {imc:F2}";
                    }
                    else if (imc > 39.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade mórbida. Seu IMC é de {imc:F2}";
                    }
                }

                if (ccbF.Checked)
                {

                    if (imc < 19)
                    {
                        txtIMC.Text = $"Seu peso está abaixo do que deveria. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 23.9)
                    {
                        txtIMC.Text = $"Seu peso está normal. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 28.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade leve. Seu IMC é de {imc:F2}";
                    }
                    else if (imc < 38.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade moderada. Seu IMC é de {imc:F2}";
                    }
                    else if (imc > 38.9)
                    {
                        txtIMC.Text = $"Você está com uma obesidade mórbida. Seu IMC é de {imc:F2}";
                    }
                }
                if (ccbM.Checked == false && ccbF.Checked == false)
                {
                    MessageBox.Show("Favor infor o sexo", "Menssagem automática do sistema",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button3);
                    gpbSexo.Focus();
                }

                if (ccbM.Checked && ccbF.Checked)
                {
                    
                    MessageBox.Show("Favor selecionar so um valor em sexo", "Menssagem automática do sistema",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button3);
                    ccbF.Checked = false;
                    ccbM.Checked = false;
                    txtAltura.Clear();
                    txtIdade.Clear();
                    txtPeso.Clear();
                    txtIMC.Clear();
                    gpbSexo.Focus();
                    

                }

            } catch (Exception) {
                MessageBox.Show("Favor inserir todas as informações", "Menssagem automática do sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button3);
                ccbF.Checked = false;
                ccbM.Checked = false;
                txtAltura.Clear();
                txtIdade.Clear();
                txtIMC.Clear();
                txtPeso.Clear();
                gpbSexo.Focus();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ccbF.Checked = false;
            ccbM.Checked = false;
            txtAltura.Clear();
            txtIdade.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            gpbSexo.Focus();
        }
    }
}
