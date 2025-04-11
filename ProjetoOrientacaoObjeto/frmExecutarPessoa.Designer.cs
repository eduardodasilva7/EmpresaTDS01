namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutarPessoa
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbMostrarRegistros = new System.Windows.Forms.GroupBox();
            this.lblCPFMst = new System.Windows.Forms.Label();
            this.lblTelefoneMst = new System.Windows.Forms.Label();
            this.lblEmailMst = new System.Windows.Forms.Label();
            this.lblIdadeMst = new System.Windows.Forms.Label();
            this.lblNomeMst = new System.Windows.Forms.Label();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbMostrarRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(27, 482);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 69);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.mktTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mktCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtIdade);
            this.gpbDadosPessoais.Controls.Add(this.lblIdade);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(860, 190);
            this.gpbDadosPessoais.TabIndex = 1;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mktCPF
            // 
            this.mktCPF.Location = new System.Drawing.Point(354, 120);
            this.mktCPF.Mask = "000,000,000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(130, 26);
            this.mktCPF.TabIndex = 6;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(296, 121);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(34, 122);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(601, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(543, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(354, 43);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 26);
            this.txtIdade.TabIndex = 3;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(296, 44);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbMostrarRegistros
            // 
            this.gpbMostrarRegistros.Controls.Add(this.lblCPFMst);
            this.gpbMostrarRegistros.Controls.Add(this.lblTelefoneMst);
            this.gpbMostrarRegistros.Controls.Add(this.lblEmailMst);
            this.gpbMostrarRegistros.Controls.Add(this.lblIdadeMst);
            this.gpbMostrarRegistros.Controls.Add(this.lblNomeMst);
            this.gpbMostrarRegistros.Location = new System.Drawing.Point(12, 241);
            this.gpbMostrarRegistros.Name = "gpbMostrarRegistros";
            this.gpbMostrarRegistros.Size = new System.Drawing.Size(860, 188);
            this.gpbMostrarRegistros.TabIndex = 2;
            this.gpbMostrarRegistros.TabStop = false;
            this.gpbMostrarRegistros.Text = "Mostrar Registros";
            // 
            // lblCPFMst
            // 
            this.lblCPFMst.AutoSize = true;
            this.lblCPFMst.Location = new System.Drawing.Point(296, 127);
            this.lblCPFMst.Name = "lblCPFMst";
            this.lblCPFMst.Size = new System.Drawing.Size(40, 20);
            this.lblCPFMst.TabIndex = 4;
            this.lblCPFMst.Text = "CPF";
            // 
            // lblTelefoneMst
            // 
            this.lblTelefoneMst.AutoSize = true;
            this.lblTelefoneMst.Location = new System.Drawing.Point(34, 127);
            this.lblTelefoneMst.Name = "lblTelefoneMst";
            this.lblTelefoneMst.Size = new System.Drawing.Size(71, 20);
            this.lblTelefoneMst.TabIndex = 3;
            this.lblTelefoneMst.Text = "Telefone";
            // 
            // lblEmailMst
            // 
            this.lblEmailMst.AutoSize = true;
            this.lblEmailMst.Location = new System.Drawing.Point(543, 53);
            this.lblEmailMst.Name = "lblEmailMst";
            this.lblEmailMst.Size = new System.Drawing.Size(48, 20);
            this.lblEmailMst.TabIndex = 2;
            this.lblEmailMst.Text = "Email";
            // 
            // lblIdadeMst
            // 
            this.lblIdadeMst.AutoSize = true;
            this.lblIdadeMst.Location = new System.Drawing.Point(296, 53);
            this.lblIdadeMst.Name = "lblIdadeMst";
            this.lblIdadeMst.Size = new System.Drawing.Size(50, 20);
            this.lblIdadeMst.TabIndex = 1;
            this.lblIdadeMst.Text = "Idade";
            // 
            // lblNomeMst
            // 
            this.lblNomeMst.AutoSize = true;
            this.lblNomeMst.Location = new System.Drawing.Point(34, 53);
            this.lblNomeMst.Name = "lblNomeMst";
            this.lblNomeMst.Size = new System.Drawing.Size(51, 20);
            this.lblNomeMst.TabIndex = 0;
            this.lblNomeMst.Text = "Nome";
            // 
            // mktTelefone
            // 
            this.mktTelefone.Location = new System.Drawing.Point(111, 118);
            this.mktTelefone.Mask = "(00) 00000-0000";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(165, 26);
            this.mktTelefone.TabIndex = 9;
            // 
            // frmExecutarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 563);
            this.Controls.Add(this.gpbMostrarRegistros);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnCadastrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExecutarPessoa";
            this.Text = "frmExecutarPessoa";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbMostrarRegistros.ResumeLayout(false);
            this.gpbMostrarRegistros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbMostrarRegistros;
        private System.Windows.Forms.Label lblNomeMst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPFMst;
        private System.Windows.Forms.Label lblTelefoneMst;
        private System.Windows.Forms.Label lblEmailMst;
        private System.Windows.Forms.Label lblIdadeMst;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
    }
}