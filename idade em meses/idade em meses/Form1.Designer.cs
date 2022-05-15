namespace idade_em_meses
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldigiteidade = new System.Windows.Forms.Label();
            this.btnidade = new System.Windows.Forms.Button();
            this.txtNerd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldigiteidade
            // 
            this.lbldigiteidade.AutoSize = true;
            this.lbldigiteidade.Font = new System.Drawing.Font("Javanese Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigiteidade.Location = new System.Drawing.Point(162, -5);
            this.lbldigiteidade.Name = "lbldigiteidade";
            this.lbldigiteidade.Size = new System.Drawing.Size(503, 109);
            this.lbldigiteidade.TabIndex = 0;
            this.lbldigiteidade.Text = "DIGITE SUA IDADE";
            // 
            // btnidade
            // 
            this.btnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnidade.Location = new System.Drawing.Point(60, 154);
            this.btnidade.Name = "btnidade";
            this.btnidade.Size = new System.Drawing.Size(675, 273);
            this.btnidade.TabIndex = 1;
            this.btnidade.Text = "CLIQUE, CLIQUE IMEDIATAMENTE";
            this.btnidade.UseVisualStyleBackColor = true;
            this.btnidade.Click += new System.EventHandler(this.btnidade_Click);
            // 
            // txtNerd
            // 
            this.txtNerd.Location = new System.Drawing.Point(378, 84);
            this.txtNerd.Name = "txtNerd";
            this.txtNerd.Size = new System.Drawing.Size(43, 20);
            this.txtNerd.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNerd);
            this.Controls.Add(this.btnidade);
            this.Controls.Add(this.lbldigiteidade);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldigiteidade;
        private System.Windows.Forms.Button btnidade;
        private System.Windows.Forms.TextBox txtNerd;
    }
}

