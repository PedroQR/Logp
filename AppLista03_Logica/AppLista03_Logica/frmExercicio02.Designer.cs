namespace AppLista03_Logica
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
            this.lblex1 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnmedia = new System.Windows.Forms.Button();
            this.btnporcent = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblex1
            // 
            this.lblex1.AutoSize = true;
            this.lblex1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblex1.Location = new System.Drawing.Point(15, 27);
            this.lblex1.Name = "lblex1";
            this.lblex1.Size = new System.Drawing.Size(160, 30);
            this.lblex1.TabIndex = 0;
            this.lblex1.Text = "exercício 1";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(12, 80);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(115, 108);
            this.lblnum.TabIndex = 2;
            this.lblnum.Text = "NUM1\r\nNUM2\r\nNUM3";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(133, 81);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(139, 31);
            this.txtnum1.TabIndex = 4;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(332, 40);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(125, 59);
            this.btnsoma.TabIndex = 7;
            this.btnsoma.Text = "soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(332, 105);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(125, 59);
            this.btnmedia.TabIndex = 8;
            this.btnmedia.Text = "média";
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // btnporcent
            // 
            this.btnporcent.Location = new System.Drawing.Point(332, 170);
            this.btnporcent.Name = "btnporcent";
            this.btnporcent.Size = new System.Drawing.Size(125, 59);
            this.btnporcent.TabIndex = 9;
            this.btnporcent.Text = "porcentagem";
            this.btnporcent.UseVisualStyleBackColor = true;
            this.btnporcent.Click += new System.EventHandler(this.btnporcent_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(133, 118);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(139, 31);
            this.txtnum2.TabIndex = 10;
            // 
            // txtnum3
            // 
            this.txtnum3.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum3.Location = new System.Drawing.Point(133, 155);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(139, 31);
            this.txtnum3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 258);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.btnporcent);
            this.Controls.Add(this.btnmedia);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblex1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblex1;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Button btnporcent;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
    }
}

