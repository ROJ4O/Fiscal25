namespace Fiscal
{
    partial class FormFiscal
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
            this.boxGeralFormFiscal = new System.Windows.Forms.GroupBox();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnContabilista = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.boxGeralFormFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxGeralFormFiscal
            // 
            this.boxGeralFormFiscal.Controls.Add(this.btnSpeed);
            this.boxGeralFormFiscal.Location = new System.Drawing.Point(12, 12);
            this.boxGeralFormFiscal.Name = "boxGeralFormFiscal";
            this.boxGeralFormFiscal.Size = new System.Drawing.Size(213, 180);
            this.boxGeralFormFiscal.TabIndex = 8;
            this.boxGeralFormFiscal.TabStop = false;
            this.boxGeralFormFiscal.Text = "Seleção do arquivo a ser gerado";
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpeed.Location = new System.Drawing.Point(57, 49);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(100, 100);
            this.btnSpeed.TabIndex = 26;
            this.btnSpeed.Text = "SPED";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnContabilista
            // 
            this.btnContabilista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContabilista.Location = new System.Drawing.Point(12, 198);
            this.btnContabilista.Name = "btnContabilista";
            this.btnContabilista.Size = new System.Drawing.Size(74, 25);
            this.btnContabilista.TabIndex = 9;
            this.btnContabilista.Text = "Contabilista";
            this.btnContabilista.UseVisualStyleBackColor = false;
            this.btnContabilista.Click += new System.EventHandler(this.btnContabilista_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(177, 198);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 25);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 231);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnContabilista);
            this.Controls.Add(this.boxGeralFormFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal";
            this.boxGeralFormFiscal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxGeralFormFiscal;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnContabilista;
        private System.Windows.Forms.Button btnSair;
    }
}

