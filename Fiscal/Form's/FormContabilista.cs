using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Fiscal.DataContext;

namespace Fiscal
{
    public partial class FormContabilista : Form
    {
        public FormContabilista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormContabilista_Load(object sender, EventArgs e)
        {
            using (var dadosCont = new ConnectBd())
            {
                var DadosCont = dadosCont.Contabilista.FirstOrDefault();

                txtNomeContador.Text = DadosCont.Nome;
                txtCnpjContador.Text = DadosCont.CNPJ;
                txtCrc.Text = DadosCont.CRC;
                txtCpfContador.Text = DadosCont.CPF;
                txtCepContador.Text = DadosCont.CEP;
                txtEndContador.Text = DadosCont.Endereco;
                txtNumContador.Text = DadosCont.Numero;
                txtCompContador.Text = DadosCont.Complemento;
                txtBairroContador.Text = DadosCont.Bairro;
                txtTelContador.Text = DadosCont.Telefone;
                txtFaxContador.Text = DadosCont.FAX;
                txtEmailContador.Text = DadosCont.Email;
                txtCodMunContador.Text = DadosCont.CodMunicipio;
                txtAnaliticaContador.Text = DadosCont.CodContaAnalitica;
            }
        }
    }
}
