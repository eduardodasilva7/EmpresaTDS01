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
    public partial class frmExecutarPessoa : Form
    {
        public frmExecutarPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            Pessoa ps = new Pessoa();
            ps.setNome(txtNome.Text);
            ps.setIdade(int.Parse(txtIdade.Text));
            ps.setEmail(txtEmail.Text);
            ps.setTelefone(mktTelefone.Text);
            ps.setCPF(mktCPF.Text);

            lblNomeMst.Text = ps.getNome();
            lblIdadeMst.Text = ps.getIdade().ToString();
            lblEmailMst.Text = ps.getEmail();
            lblTelefoneMst.Text = ps.getTelefone();
            lblCPFMst.Text = ps.getCPF();
        }

        
    }
}
