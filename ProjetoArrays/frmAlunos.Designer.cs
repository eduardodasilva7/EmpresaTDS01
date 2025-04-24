namespace ProjetoArrays
{
    partial class frmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            this.ltbAlunos = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCarregaTurma = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.lblP3 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.lblP2 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbAlunos
            // 
            this.ltbAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbAlunos.FormattingEnabled = true;
            this.ltbAlunos.ItemHeight = 20;
            this.ltbAlunos.Location = new System.Drawing.Point(376, 29);
            this.ltbAlunos.Name = "ltbAlunos";
            this.ltbAlunos.Size = new System.Drawing.Size(396, 364);
            this.ltbAlunos.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(524, 492);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 57);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(284, 492);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 57);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCarregaTurma
            // 
            this.btnCarregaTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaTurma.Location = new System.Drawing.Point(39, 492);
            this.btnCarregaTurma.Name = "btnCarregaTurma";
            this.btnCarregaTurma.Size = new System.Drawing.Size(200, 57);
            this.btnCarregaTurma.TabIndex = 7;
            this.btnCarregaTurma.Text = "Carrega Turma";
            this.btnCarregaTurma.UseVisualStyleBackColor = true;
            this.btnCarregaTurma.Click += new System.EventHandler(this.btnCarregaTurma_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtT1);
            this.gpbDados.Controls.Add(this.lblT1);
            this.gpbDados.Controls.Add(this.txtP3);
            this.gpbDados.Controls.Add(this.lblP3);
            this.gpbDados.Controls.Add(this.txtP2);
            this.gpbDados.Controls.Add(this.lblP2);
            this.gpbDados.Controls.Add(this.txtP1);
            this.gpbDados.Controls.Add(this.lblP1);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(13, 12);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(342, 381);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Carrege os dados";
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(92, 267);
            this.txtT1.MaxLength = 100;
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(100, 26);
            this.txtT1.TabIndex = 5;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(22, 270);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(71, 20);
            this.lblT1.TabIndex = 8;
            this.lblT1.Text = "Trabalho";
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(92, 216);
            this.txtP3.MaxLength = 100;
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(100, 26);
            this.txtP3.TabIndex = 4;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Location = new System.Drawing.Point(22, 219);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(62, 20);
            this.lblP3.TabIndex = 6;
            this.lblP3.Text = "Prova 3";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(90, 169);
            this.txtP2.MaxLength = 100;
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 26);
            this.txtP2.TabIndex = 3;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(22, 172);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(62, 20);
            this.lblP2.TabIndex = 4;
            this.lblP2.Text = "Prova 2";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(92, 120);
            this.txtP1.MaxLength = 100;
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 26);
            this.txtP1.TabIndex = 2;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(22, 123);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(62, 20);
            this.lblP1.TabIndex = 2;
            this.lblP1.Text = "Prova 1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 70);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregaTurma);
            this.Controls.Add(this.ltbAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbAlunos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregaTurma;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label lblP2;
    }
}