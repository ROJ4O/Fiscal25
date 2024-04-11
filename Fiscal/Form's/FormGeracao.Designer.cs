namespace Fiscal
{
    partial class FormGeracao
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
            this.btnCanccelarGeracao = new System.Windows.Forms.Button();
            this.dataFiscal1 = new System.Windows.Forms.DateTimePicker();
            this.dataFiscal2 = new System.Windows.Forms.DateTimePicker();
            this.gboxPeriodoFiscal = new System.Windows.Forms.GroupBox();
            this.btnConfirmarGeracao = new System.Windows.Forms.Button();
            this.gboxFinalidadeFiscal = new System.Windows.Forms.GroupBox();
            this.radiobtnArquivoSubs = new System.Windows.Forms.RadioButton();
            this.radiobtnArquivoOriginal = new System.Windows.Forms.RadioButton();
            this.gboxPerfiGer = new System.Windows.Forms.GroupBox();
            this.radiobtnPerfilC = new System.Windows.Forms.RadioButton();
            this.radiobtnPerfilA = new System.Windows.Forms.RadioButton();
            this.radiobtnPerfilB = new System.Windows.Forms.RadioButton();
            this.gboxLeiauteFiscal = new System.Windows.Forms.GroupBox();
            this.txtLeiauteFiscal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnIndustria = new System.Windows.Forms.RadioButton();
            this.radiobtnOutros = new System.Windows.Forms.RadioButton();
            this.gboxPeriodoFiscal.SuspendLayout();
            this.gboxFinalidadeFiscal.SuspendLayout();
            this.gboxPerfiGer.SuspendLayout();
            this.gboxLeiauteFiscal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCanccelarGeracao
            // 
            this.btnCanccelarGeracao.Location = new System.Drawing.Point(13, 251);
            this.btnCanccelarGeracao.Name = "btnCanccelarGeracao";
            this.btnCanccelarGeracao.Size = new System.Drawing.Size(259, 20);
            this.btnCanccelarGeracao.TabIndex = 1;
            this.btnCanccelarGeracao.Text = "Cancelar";
            this.btnCanccelarGeracao.UseVisualStyleBackColor = true;
            this.btnCanccelarGeracao.Click += new System.EventHandler(this.btnCanccelarGeracao_Click);
            // 
            // dataFiscal1
            // 
            this.dataFiscal1.Location = new System.Drawing.Point(6, 19);
            this.dataFiscal1.Name = "dataFiscal1";
            this.dataFiscal1.Size = new System.Drawing.Size(248, 20);
            this.dataFiscal1.TabIndex = 1;
            this.dataFiscal1.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // dataFiscal2
            // 
            this.dataFiscal2.Checked = false;
            this.dataFiscal2.Location = new System.Drawing.Point(6, 45);
            this.dataFiscal2.Name = "dataFiscal2";
            this.dataFiscal2.Size = new System.Drawing.Size(248, 20);
            this.dataFiscal2.TabIndex = 0;
            this.dataFiscal2.Value = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            // 
            // gboxPeriodoFiscal
            // 
            this.gboxPeriodoFiscal.Controls.Add(this.dataFiscal2);
            this.gboxPeriodoFiscal.Controls.Add(this.dataFiscal1);
            this.gboxPeriodoFiscal.Location = new System.Drawing.Point(12, 5);
            this.gboxPeriodoFiscal.Name = "gboxPeriodoFiscal";
            this.gboxPeriodoFiscal.Size = new System.Drawing.Size(259, 77);
            this.gboxPeriodoFiscal.TabIndex = 4;
            this.gboxPeriodoFiscal.TabStop = false;
            this.gboxPeriodoFiscal.Text = "Período";
            // 
            // btnConfirmarGeracao
            // 
            this.btnConfirmarGeracao.Location = new System.Drawing.Point(12, 225);
            this.btnConfirmarGeracao.Name = "btnConfirmarGeracao";
            this.btnConfirmarGeracao.Size = new System.Drawing.Size(260, 20);
            this.btnConfirmarGeracao.TabIndex = 5;
            this.btnConfirmarGeracao.Text = "Confirmar";
            this.btnConfirmarGeracao.UseVisualStyleBackColor = true;
            this.btnConfirmarGeracao.Click += new System.EventHandler(this.btnConfirmarGeracao_Click);
            // 
            // gboxFinalidadeFiscal
            // 
            this.gboxFinalidadeFiscal.Controls.Add(this.radiobtnArquivoSubs);
            this.gboxFinalidadeFiscal.Controls.Add(this.radiobtnArquivoOriginal);
            this.gboxFinalidadeFiscal.Location = new System.Drawing.Point(13, 82);
            this.gboxFinalidadeFiscal.Name = "gboxFinalidadeFiscal";
            this.gboxFinalidadeFiscal.Size = new System.Drawing.Size(259, 40);
            this.gboxFinalidadeFiscal.TabIndex = 4;
            this.gboxFinalidadeFiscal.TabStop = false;
            this.gboxFinalidadeFiscal.Text = "Finalidade Arquivo";
            // 
            // radiobtnArquivoSubs
            // 
            this.radiobtnArquivoSubs.AutoSize = true;
            this.radiobtnArquivoSubs.Location = new System.Drawing.Point(142, 17);
            this.radiobtnArquivoSubs.Name = "radiobtnArquivoSubs";
            this.radiobtnArquivoSubs.Size = new System.Drawing.Size(111, 17);
            this.radiobtnArquivoSubs.TabIndex = 7;
            this.radiobtnArquivoSubs.Text = "Arquivo Substituto";
            this.radiobtnArquivoSubs.UseVisualStyleBackColor = true;
            // 
            // radiobtnArquivoOriginal
            // 
            this.radiobtnArquivoOriginal.AutoSize = true;
            this.radiobtnArquivoOriginal.Checked = true;
            this.radiobtnArquivoOriginal.Location = new System.Drawing.Point(17, 17);
            this.radiobtnArquivoOriginal.Name = "radiobtnArquivoOriginal";
            this.radiobtnArquivoOriginal.Size = new System.Drawing.Size(97, 17);
            this.radiobtnArquivoOriginal.TabIndex = 6;
            this.radiobtnArquivoOriginal.TabStop = true;
            this.radiobtnArquivoOriginal.Text = "Arquivo original";
            this.radiobtnArquivoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnArquivoOriginal.UseVisualStyleBackColor = true;
            // 
            // gboxPerfiGer
            // 
            this.gboxPerfiGer.Controls.Add(this.radiobtnPerfilC);
            this.gboxPerfiGer.Controls.Add(this.radiobtnPerfilA);
            this.gboxPerfiGer.Controls.Add(this.radiobtnPerfilB);
            this.gboxPerfiGer.Location = new System.Drawing.Point(12, 122);
            this.gboxPerfiGer.Name = "gboxPerfiGer";
            this.gboxPerfiGer.Size = new System.Drawing.Size(259, 46);
            this.gboxPerfiGer.TabIndex = 8;
            this.gboxPerfiGer.TabStop = false;
            this.gboxPerfiGer.Text = "Perfil de Geração";
            // 
            // radiobtnPerfilC
            // 
            this.radiobtnPerfilC.AutoSize = true;
            this.radiobtnPerfilC.Location = new System.Drawing.Point(195, 17);
            this.radiobtnPerfilC.Name = "radiobtnPerfilC";
            this.radiobtnPerfilC.Size = new System.Drawing.Size(58, 17);
            this.radiobtnPerfilC.TabIndex = 8;
            this.radiobtnPerfilC.Text = "Perfil C";
            this.radiobtnPerfilC.UseVisualStyleBackColor = true;
            // 
            // radiobtnPerfilA
            // 
            this.radiobtnPerfilA.AutoSize = true;
            this.radiobtnPerfilA.Location = new System.Drawing.Point(17, 17);
            this.radiobtnPerfilA.Name = "radiobtnPerfilA";
            this.radiobtnPerfilA.Size = new System.Drawing.Size(58, 17);
            this.radiobtnPerfilA.TabIndex = 6;
            this.radiobtnPerfilA.Text = "Perfil A";
            this.radiobtnPerfilA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnPerfilA.UseVisualStyleBackColor = true;
            // 
            // radiobtnPerfilB
            // 
            this.radiobtnPerfilB.AutoSize = true;
            this.radiobtnPerfilB.Checked = true;
            this.radiobtnPerfilB.Location = new System.Drawing.Point(107, 17);
            this.radiobtnPerfilB.Name = "radiobtnPerfilB";
            this.radiobtnPerfilB.Size = new System.Drawing.Size(58, 17);
            this.radiobtnPerfilB.TabIndex = 7;
            this.radiobtnPerfilB.TabStop = true;
            this.radiobtnPerfilB.Text = "Perfil B";
            this.radiobtnPerfilB.UseVisualStyleBackColor = true;
            // 
            // gboxLeiauteFiscal
            // 
            this.gboxLeiauteFiscal.Controls.Add(this.txtLeiauteFiscal);
            this.gboxLeiauteFiscal.Location = new System.Drawing.Point(13, 174);
            this.gboxLeiauteFiscal.Name = "gboxLeiauteFiscal";
            this.gboxLeiauteFiscal.Size = new System.Drawing.Size(61, 45);
            this.gboxLeiauteFiscal.TabIndex = 9;
            this.gboxLeiauteFiscal.TabStop = false;
            this.gboxLeiauteFiscal.Text = "Leiaute";
            // 
            // txtLeiauteFiscal
            // 
            this.txtLeiauteFiscal.Location = new System.Drawing.Point(12, 16);
            this.txtLeiauteFiscal.Name = "txtLeiauteFiscal";
            this.txtLeiauteFiscal.Size = new System.Drawing.Size(38, 20);
            this.txtLeiauteFiscal.TabIndex = 0;
            this.txtLeiauteFiscal.Text = "018";
            this.txtLeiauteFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnIndustria);
            this.groupBox1.Controls.Add(this.radiobtnOutros);
            this.groupBox1.Location = new System.Drawing.Point(80, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leiaute Arquivo";
            // 
            // radiobtnIndustria
            // 
            this.radiobtnIndustria.AutoSize = true;
            this.radiobtnIndustria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnIndustria.Location = new System.Drawing.Point(109, 19);
            this.radiobtnIndustria.Name = "radiobtnIndustria";
            this.radiobtnIndustria.Size = new System.Drawing.Size(67, 17);
            this.radiobtnIndustria.TabIndex = 9;
            this.radiobtnIndustria.Text = "Industría";
            this.radiobtnIndustria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnIndustria.UseVisualStyleBackColor = true;
            // 
            // radiobtnOutros
            // 
            this.radiobtnOutros.AutoSize = true;
            this.radiobtnOutros.Checked = true;
            this.radiobtnOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnOutros.Location = new System.Drawing.Point(21, 19);
            this.radiobtnOutros.Name = "radiobtnOutros";
            this.radiobtnOutros.Size = new System.Drawing.Size(56, 17);
            this.radiobtnOutros.TabIndex = 8;
            this.radiobtnOutros.TabStop = true;
            this.radiobtnOutros.Text = "Outros";
            this.radiobtnOutros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnOutros.UseVisualStyleBackColor = true;
            // 
            // FormGeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxLeiauteFiscal);
            this.Controls.Add(this.gboxPerfiGer);
            this.Controls.Add(this.gboxFinalidadeFiscal);
            this.Controls.Add(this.btnConfirmarGeracao);
            this.Controls.Add(this.gboxPeriodoFiscal);
            this.Controls.Add(this.btnCanccelarGeracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGeracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração";
            this.gboxPeriodoFiscal.ResumeLayout(false);
            this.gboxFinalidadeFiscal.ResumeLayout(false);
            this.gboxFinalidadeFiscal.PerformLayout();
            this.gboxPerfiGer.ResumeLayout(false);
            this.gboxPerfiGer.PerformLayout();
            this.gboxLeiauteFiscal.ResumeLayout(false);
            this.gboxLeiauteFiscal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCanccelarGeracao;
        private System.Windows.Forms.GroupBox gboxPeriodoFiscal;
        private System.Windows.Forms.Button btnConfirmarGeracao;
        private System.Windows.Forms.GroupBox gboxFinalidadeFiscal;
        private System.Windows.Forms.GroupBox gboxPerfiGer;
        private System.Windows.Forms.GroupBox gboxLeiauteFiscal;
        public System.Windows.Forms.TextBox txtLeiauteFiscal;
        public System.Windows.Forms.RadioButton radiobtnArquivoSubs;
        public System.Windows.Forms.RadioButton radiobtnArquivoOriginal;
        public System.Windows.Forms.DateTimePicker dataFiscal1;
        public System.Windows.Forms.DateTimePicker dataFiscal2;
        public System.Windows.Forms.RadioButton radiobtnPerfilA;
        public System.Windows.Forms.RadioButton radiobtnPerfilB;
        public System.Windows.Forms.RadioButton radiobtnPerfilC;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radiobtnOutros;
        public System.Windows.Forms.RadioButton radiobtnIndustria;
    }
}