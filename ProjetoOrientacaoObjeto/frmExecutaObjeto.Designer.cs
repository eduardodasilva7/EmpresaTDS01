namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaObjeto
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMutiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(96, 52);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(241, 125);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(56, 487);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(78, 20);
            this.lblResposta.TabIndex = 1;
            this.lblResposta.Text = "Resposta";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(444, 52);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(241, 125);
            this.btnSubtrair.TabIndex = 2;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMutiplicar
            // 
            this.btnMutiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutiplicar.Location = new System.Drawing.Point(96, 225);
            this.btnMutiplicar.Name = "btnMutiplicar";
            this.btnMutiplicar.Size = new System.Drawing.Size(241, 125);
            this.btnMutiplicar.TabIndex = 3;
            this.btnMutiplicar.Text = "Mutiplicar";
            this.btnMutiplicar.UseVisualStyleBackColor = true;
            this.btnMutiplicar.Click += new System.EventHandler(this.btnMutiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(444, 225);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(241, 125);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // frmExecutaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMutiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnSomar);
            this.MaximizeBox = false;
            this.Name = "frmExecutaObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executa Objeto ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMutiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}