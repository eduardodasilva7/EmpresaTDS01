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
            ltbAlunos.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarregaMatriz_Click(object sender, EventArgs e)
        {
            /*
             nomes[0,0] = 'João';
             nomes[0,1] = 'Pedro';
             nomes[0,2] = 'Ana'; 

             prova1[0,0] = 10;
             prova1[0,1] = 3;
             prova1[0,2] = 6; 

             prova2[0,0] = 5;
             prova2[0,1] = 6;
             prova2[0,2] = 8; 
             */

            string[,] names = new string[5, 2];
            int[,] p1 = new int[5, 2];
            int[,] p2 = new int[5, 2];
            int[,] p3 = new int[5, 2];
            int[,] t1 = new int[5, 2];
            int[,] media = new int[5, 2];

            names[0, 0] = "João";
            names[0, 1] = "Pedro";
            names[1, 0] = "Ana";
            names[1, 1] = "Luiz";
            names[2, 0] = "Mariana";
            names[2, 1] = "Carlos";
            names[3, 0] = "Julia";
            names[3, 1] = "Rafael";
            names[4, 0] = "Bruna";
            names[4, 1] = "Tiago";


            p1[0, 0] = 10;
            p1[0, 1] = 4;
            p1[1, 0] = 2;
            p1[1, 1] = 4;
            p1[2, 0] = 7;
            p1[2, 1] = 6;
            p1[3, 0] = 9;
            p1[3, 1] = 5;
            p1[4, 0] = 8;
            p1[4, 1] = 7;

            p2[0, 0] = 9;
            p2[0, 1] = 5;
            p2[1, 0] = 4;
            p2[1, 1] = 4;
            p2[2, 0] = 6;
            p2[2, 1] = 7;
            p2[3, 0] = 8;
            p2[3, 1] = 5;
            p2[4, 0] = 9;
            p2[4, 1] = 6;

            p3[0, 0] = 10;
            p3[0, 1] = 8;
            p3[1, 0] = 3;
            p3[1, 1] = 4;
            p3[2, 0] = 8;
            p3[2, 1] = 6;
            p3[3, 0] = 10;
            p3[3, 1] = 7;
            p3[4, 0] = 7;
            p3[4, 1] = 6;

            t1[0, 0] = 6;
            t1[0, 1] = 5;
            t1[1, 0] = 3;
            t1[1, 1] = 4;
            t1[2, 0] = 7;
            t1[2, 1] = 6;
            t1[3, 0] = 9;
            t1[3, 1] = 7;
            t1[4, 0] = 8;
            t1[4, 1] = 6;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j <2; j++)
                {
                    media[i, j] = (p1[i, j] + p2[i, j] + p3[i,j] + t1[i, j]) / 4;
                    if (media[i, j] >= 6)
                    {
                        ltbAlunos.Items.Add($"{names[i, j]}: {media[i, j]} Aprovado");
                    }
                    else if(media[i, j] >= 4)
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
