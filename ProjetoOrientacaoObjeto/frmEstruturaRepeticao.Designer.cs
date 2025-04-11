namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.ltbListaDesejo = new System.Windows.Forms.ListBox();
            this.lblListaDesejo = new System.Windows.Forms.Label();
            this.btnCarregaListaDesejos = new System.Windows.Forms.Button();
            this.lblDigiteEstado = new System.Windows.Forms.Label();
            this.txtDigEstado = new System.Windows.Forms.TextBox();
            this.btnDigEstado = new System.Windows.Forms.Button();
            this.btnLimparEstado = new System.Windows.Forms.Button();
            this.btnLimparItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(64, 100);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(165, 28);
            this.cbbEstado.TabIndex = 1;
            this.cbbEstado.TabStop = false;
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Location = new System.Drawing.Point(70, 456);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(159, 47);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estado";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(70, 66);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // ltbListaDesejo
            // 
            this.ltbListaDesejo.FormattingEnabled = true;
            this.ltbListaDesejo.ItemHeight = 20;
            this.ltbListaDesejo.Location = new System.Drawing.Point(422, 100);
            this.ltbListaDesejo.Name = "ltbListaDesejo";
            this.ltbListaDesejo.Size = new System.Drawing.Size(278, 204);
            this.ltbListaDesejo.TabIndex = 3;
            // 
            // lblListaDesejo
            // 
            this.lblListaDesejo.AutoSize = true;
            this.lblListaDesejo.Location = new System.Drawing.Point(418, 66);
            this.lblListaDesejo.Name = "lblListaDesejo";
            this.lblListaDesejo.Size = new System.Drawing.Size(124, 20);
            this.lblListaDesejo.TabIndex = 4;
            this.lblListaDesejo.Text = "Lista de desejos";
            // 
            // btnCarregaListaDesejos
            // 
            this.btnCarregaListaDesejos.Location = new System.Drawing.Point(422, 457);
            this.btnCarregaListaDesejos.Name = "btnCarregaListaDesejos";
            this.btnCarregaListaDesejos.Size = new System.Drawing.Size(201, 47);
            this.btnCarregaListaDesejos.TabIndex = 5;
            this.btnCarregaListaDesejos.Text = "Carrega Lista Desejos";
            this.btnCarregaListaDesejos.UseVisualStyleBackColor = true;
            this.btnCarregaListaDesejos.Click += new System.EventHandler(this.btnCarregaListaDesejos_Click);
            // 
            // lblDigiteEstado
            // 
            this.lblDigiteEstado.AutoSize = true;
            this.lblDigiteEstado.Location = new System.Drawing.Point(70, 221);
            this.lblDigiteEstado.Name = "lblDigiteEstado";
            this.lblDigiteEstado.Size = new System.Drawing.Size(131, 20);
            this.lblDigiteEstado.TabIndex = 6;
            this.lblDigiteEstado.Text = "Digite um Estado";
            // 
            // txtDigEstado
            // 
            this.txtDigEstado.Location = new System.Drawing.Point(64, 244);
            this.txtDigEstado.Name = "txtDigEstado";
            this.txtDigEstado.Size = new System.Drawing.Size(218, 26);
            this.txtDigEstado.TabIndex = 2;
            this.txtDigEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDigEstado_KeyDown);
            // 
            // btnDigEstado
            // 
            this.btnDigEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigEstado.Location = new System.Drawing.Point(64, 285);
            this.btnDigEstado.Name = "btnDigEstado";
            this.btnDigEstado.Size = new System.Drawing.Size(106, 28);
            this.btnDigEstado.TabIndex = 3;
            this.btnDigEstado.Text = "Inserir Estado";
            this.btnDigEstado.UseVisualStyleBackColor = true;
            this.btnDigEstado.Click += new System.EventHandler(this.btnDigEstado_Click);
            // 
            // btnLimparEstado
            // 
            this.btnLimparEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstado.Location = new System.Drawing.Point(176, 285);
            this.btnLimparEstado.Name = "btnLimparEstado";
            this.btnLimparEstado.Size = new System.Drawing.Size(106, 28);
            this.btnLimparEstado.TabIndex = 7;
            this.btnLimparEstado.Text = "Limpar Estado";
            this.btnLimparEstado.UseVisualStyleBackColor = true;
            this.btnLimparEstado.Click += new System.EventHandler(this.btnLimparEstado_Click);
            // 
            // btnLimparItem
            // 
            this.btnLimparItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparItem.Location = new System.Drawing.Point(64, 328);
            this.btnLimparItem.Name = "btnLimparItem";
            this.btnLimparItem.Size = new System.Drawing.Size(218, 28);
            this.btnLimparItem.TabIndex = 8;
            this.btnLimparItem.Text = "Limpar Item Selecionado";
            this.btnLimparItem.UseVisualStyleBackColor = true;
            this.btnLimparItem.Click += new System.EventHandler(this.btnLimparItem_Click);
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLimparItem);
            this.Controls.Add(this.btnLimparEstado);
            this.Controls.Add(this.btnDigEstado);
            this.Controls.Add(this.txtDigEstado);
            this.Controls.Add(this.lblDigiteEstado);
            this.Controls.Add(this.btnCarregaListaDesejos);
            this.Controls.Add(this.lblListaDesejo);
            this.Controls.Add(this.ltbListaDesejo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.cbbEstado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEstruturaRepeticao";
            this.Text = "frmEstruturaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ListBox ltbListaDesejo;
        private System.Windows.Forms.Label lblListaDesejo;
        private System.Windows.Forms.Button btnCarregaListaDesejos;
        private System.Windows.Forms.Label lblDigiteEstado;
        private System.Windows.Forms.TextBox txtDigEstado;
        private System.Windows.Forms.Button btnDigEstado;
        private System.Windows.Forms.Button btnLimparEstado;
        private System.Windows.Forms.Button btnLimparItem;
    }
}