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
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
            //carregaCombo();
            txtDigEstado.Focus();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            carregaCombo();
        }

        public void carregaCombo()
        {
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão Redondo");
            cbbEstado.Items.Add("São Luiz");
            cbbEstado.Items.Add("Campo Grande");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("Jardim Angela");
            cbbEstado.Items.Add("Campo Limpo");

        }

        public void carregaListaEstado()
        {
            ltbListaDesejo.Items.Clear();
            ltbListaDesejo.Items.Add("Santo Amaro");
            ltbListaDesejo.Items.Add("São Luiz");
            ltbListaDesejo.Items.Add("Campo Grande");
            ltbListaDesejo.Items.Add("Piraporinha");
            ltbListaDesejo.Items.Add("Jardim Angela");
        }

        private void btnCarregaListaDesejos_Click(object sender, EventArgs e)
        {
            carregaListaEstado();

        }

        private void btnDigEstado_Click(object sender, EventArgs e)
        {
            if (txtDigEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores");
                txtDigEstado.Clear();
                txtDigEstado.Focus();
            }
            else
            {
                inserirEstado();
            }
        }
        public void inserirEstado()
        {
            
            ltbListaDesejo.Items.Add(txtDigEstado.Text);
            txtDigEstado.Clear();
            txtDigEstado.Focus();
            
        }
        private void txtDigEstado_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
                {
                    inserirEstado();
                }
            
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            ltbListaDesejo.Items.Clear();
            txtDigEstado.Focus();
        }

        private void btnLimparItem_Click(object sender, EventArgs e)
        {
            ltbListaDesejo.Items.Remove(ltbListaDesejo.SelectedItem);
            txtDigEstado.Focus();
        }
    }
}
