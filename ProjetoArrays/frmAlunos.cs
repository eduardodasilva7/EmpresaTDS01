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
        string[,] names = new string[2, 5];
        int[,] p1 = new int[2, 5];
        int[,] p2 = new int[2, 5];
        int[,] p3 = new int[2, 5];
        int[,] t1 = new int[2, 5];
        int[,] media = new int[2, 5];
        int c = 0;
        int l = 0;
        private void btnCarregaTurma_Click(object sender, EventArgs e)
        {
            if (l < 2 && c < 5)
            {
                if (int.Parse(txtP1.Text) <= 10 && int.Parse(txtP1.Text) >= 0 &&
                    int.Parse(txtP2.Text) <= 10 && int.Parse(txtP2.Text) >= 0 &&
                    int.Parse(txtP3.Text) <= 10 && int.Parse(txtP3.Text) >= 0 &&
                    int.Parse(txtT1.Text) <= 10 && int.Parse(txtT1.Text) >= 0)
                {
                    names[l, c] = txtNome.Text;
                    p1[l, c] = int.Parse(txtP1.Text);
                    p2[l, c] = int.Parse(txtP2.Text);
                    p3[l, c] = int.Parse(txtP3.Text);
                    t1[l, c] = int.Parse(txtT1.Text);
                }
                else
                {
                    MessageBox.Show("As notas só podem ser de 0 a 10.");
                }
                c++;
                txtNome.Clear();
                txtP1.Clear();
                txtP2.Clear();
                txtP3.Clear();
                txtT1.Clear();
                txtNome.Focus();

                if (c == 5)
                {
                    c = 0;
                    l++;
                }

            }
            else
            {
                MessageBox.Show("Turma completa!");
            }

            if (l == 2 && c == 0)
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
            }
        }
        
        


    }
}

