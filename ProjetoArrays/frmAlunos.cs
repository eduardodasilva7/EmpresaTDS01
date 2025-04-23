using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtT1.Clear();
            txtNome.Focus();
            ltbAlunos.Items.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarregaTurma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    

                    media[i, j] = (p1[i, j] + p2[i, j] + p3[i, j] + t1[i, j]) / 4;
                    if (media[i, j] >= 6)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Aprovado");

                    }
                    else if (media[i, j] >= 4)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Recupeção");

                    }
                    else if (media[i, j] <= 3)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Reprovado");

                    }

                }
            }

            /*for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    names[i, j] = txtNome.Text;
                    p1[i, j] = int.Parse(txtP1.Text);
                    p2[i, j] = int.Parse(txtP2.Text);
                    p3[i, j] = int.Parse(txtP3.Text);
                    t1[i, j] = int.Parse(txtT1.Text);

                    media[i, j] = (p1[i, j] + p2[i, j] + p3[i, j] + t1[i, j]) / 4;
                    if (media[i, j] >= 6)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Aprovado");
                        
                    }
                    else if (media[i, j] >= 4)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Recupeção");
                        
                    }
                    else if (media[i, j] <= 3)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Reprovado");
                        
                    }

                }
            }*/
        }
        string[,] names = new string[2, 5];
        int[,] p1 = new int[2, 5];
        int[,] p2 = new int[2, 5];
        int[,] p3 = new int[2, 5];
        int[,] t1 = new int[2, 5];
        int[,] media = new int[2, 5];
        int c = 0;
        int l = 0;
        private void btnCarregaNome_Click(object sender, EventArgs e)
        {
            
            if (l < 2 && c < 5)
            {
                names[c, l] = txtNome.Text;
                p1[c, l] = int.Parse(txtP1.Text);
                p2[c, l] = int.Parse(txtP2.Text);
                p3[c, l] = int.Parse(txtP3.Text);
                t1[c, l] = int.Parse(txtT1.Text);


                txtNome.Clear();
                txtP1.Clear();
                txtP2.Clear();
                txtP3.Clear();
                txtT1.Clear();
                txtNome.Focus();
                c++;
                if (c == 2)
                {
                    c = 0;
                    l++;
                }
                
            }
            else
            {
                MessageBox.Show("Turma completa!");
            }
        }
    }
}
