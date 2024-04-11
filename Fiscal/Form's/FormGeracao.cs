using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Fiscal
{
    public partial class FormGeracao : Form
    {
        public FormGeracao()
        {
            InitializeComponent();
        }

        private void btnCanccelarGeracao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarGeracao_Click(object sender, EventArgs e)
        {
            Registro0000 registro0000 = new Registro0000();

            registro0000.formGeracao = this;
            registro0000.BlocosSped();

        }
    }
}
