using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Fiscal
{
    public partial class FormFiscal : Form
    {
        public FormFiscal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContabilista_Click(object sender, EventArgs e)
        {
            // Criar uma instância do FormContabilista
            FormContabilista formContabilista = new FormContabilista();

            // Mostra o FormContabilista
            formContabilista.Show();
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            FormGeracao formGeracao = new FormGeracao();

            formGeracao.Show();
        }
    }
}    