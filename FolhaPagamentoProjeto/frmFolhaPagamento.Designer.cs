namespace FolhaPagamentoProjeto
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cbbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblClube = new System.Windows.Forms.Label();
            this.cbbClube = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoRende = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(45, 72);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(123, 26);
            this.dtpDataFolha.TabIndex = 0;
            this.dtpDataFolha.TabStop = false;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Location = new System.Drawing.Point(41, 49);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataFolha.TabIndex = 1;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(43, 151);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(47, 174);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // cbbPlanoSaude
            // 
            this.cbbPlanoSaude.AutoSize = true;
            this.cbbPlanoSaude.Location = new System.Drawing.Point(45, 257);
            this.cbbPlanoSaude.Name = "cbbPlanoSaude";
            this.cbbPlanoSaude.Size = new System.Drawing.Size(145, 24);
            this.cbbPlanoSaude.TabIndex = 2;
            this.cbbPlanoSaude.Text = "Plano de Saúde ";
            this.cbbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // lblClube
            // 
            this.lblClube.AutoSize = true;
            this.lblClube.Location = new System.Drawing.Point(43, 332);
            this.lblClube.Name = "lblClube";
            this.lblClube.Size = new System.Drawing.Size(110, 20);
            this.lblClube.TabIndex = 5;
            this.lblClube.Text = "Clube de lazer";
            // 
            // cbbClube
            // 
            this.cbbClube.FormattingEnabled = true;
            this.cbbClube.Items.AddRange(new object[] {
            "",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbbClube.Location = new System.Drawing.Point(47, 370);
            this.cbbClube.Name = "cbbClube";
            this.cbbClube.Size = new System.Drawing.Size(121, 28);
            this.cbbClube.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(700, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 60);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Location = new System.Drawing.Point(323, 142);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(124, 20);
            this.lblSalarioFolha.TabIndex = 8;
            this.lblSalarioFolha.Text = "Salário da Folha";
            // 
            // lblImpostoRende
            // 
            this.lblImpostoRende.AutoSize = true;
            this.lblImpostoRende.Location = new System.Drawing.Point(323, 207);
            this.lblImpostoRende.Name = "lblImpostoRende";
            this.lblImpostoRende.Size = new System.Drawing.Size(141, 20);
            this.lblImpostoRende.TabIndex = 9;
            this.lblImpostoRende.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(323, 277);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(520, 271);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Location = new System.Drawing.Point(520, 201);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 26);
            this.txtImpostoRenda.TabIndex = 12;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Location = new System.Drawing.Point(520, 136);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioFolha.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(700, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 60);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(700, 292);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 60);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRende);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbClube);
            this.Controls.Add(this.lblClube);
            this.Controls.Add(this.cbbPlanoSaude);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox cbbPlanoSaude;
        private System.Windows.Forms.Label lblClube;
        private System.Windows.Forms.ComboBox cbbClube;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoRende;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}