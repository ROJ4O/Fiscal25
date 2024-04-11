using Fiscal.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public class Registro0000
    {
        public FormGeracao formGeracao;
        public void BlocosSped()
        {
            using (var context = new DataContext.ConnectBd())
            {
                IQueryable<Emitente> emit = context.Emitente;
                IQueryable<Contabilista> cont = context.Contabilista;
                IQueryable<Fornecedor> forn = context.Fornecedor;
                IQueryable<Clientes> clien = context.Clientes;
                IQueryable<Estoque> estq = context.Estoque;

                var DadosEmitente = emit.AsQueryable().First();
                var DadosContabilista = cont.AsQueryable().First();
                var DadosFornecedor = forn.AsQueryable().First();
                var DadosClientes = clien.AsQueryable().First();
                var DadosEstoque = estq.AsQueryable().First();

                string CNPJSemMascara = DadosEmitente.CNPJ.Replace(".", "").Replace("/", "").Replace("-", "");
                string TelefoneSemMascaraEmitente = DadosEmitente.Telefone.Replace("(", "").Replace(")", "").Replace(" ", "");
                string TelefoneSemMascaraContabilista = DadosContabilista.Telefone.Replace("(", "").Replace(")", "").Replace(" ", "");

                string registro0000;

                // Início do Registro 0000 
                registro0000 = "|0000|";
                registro0000 += formGeracao.txtLeiauteFiscal.Text + "|";

                if (formGeracao.radiobtnArquivoOriginal.Checked)
                {
                    registro0000 += "0" + "|";
                }
                else if (formGeracao.radiobtnArquivoSubs.Checked)
                {
                    registro0000 += "1" + "|";
                }

                registro0000 += formGeracao.dataFiscal1.Value.ToString("ddMMyyyy") + "|";
                registro0000 += formGeracao.dataFiscal2.Value.ToString("ddMMyyyy") + "|";
                // Registro de período do arquivo

                registro0000 += DadosEmitente.RazaoSocial + "|";
                registro0000 += CNPJSemMascara + "|";
                registro0000 += DadosEmitente.CPF + "|";
                registro0000 += DadosEmitente.UF + "|";
                registro0000 += DadosEmitente.IE + "|";
                registro0000 += DadosEmitente.CodCidadeIBGE + "|";
                registro0000 += DadosEmitente.IM + "|";
                registro0000 += DadosEmitente.Suframa + "|";

                if (formGeracao.radiobtnPerfilA.Checked)
                {
                    registro0000 += "A" + "|";
                }
                else if (formGeracao.radiobtnPerfilB.Checked)
                {
                    registro0000 += "B" + "|";
                }
                else if (formGeracao.radiobtnPerfilC.Checked)
                {
                    registro0000 += "C" + "|";
                }

                if (formGeracao.radiobtnOutros.Checked)
                {
                    registro0000 += "1" + "|" + Environment.NewLine;
                }
                else if (formGeracao.radiobtnIndustria.Checked)
                {
                    registro0000 += "0" + "|" + Environment.NewLine;
                }

                registro0000 += "|0001|" + "0|" + Environment.NewLine;
                // ^^ Inicío do Registro 0001 ^^

                // Início do Registro 0005
                registro0000 += "|0005|";
                registro0000 += DadosEmitente.NomeFantasia + "|";
                registro0000 += DadosEmitente.CEP + "|";
                registro0000 += DadosEmitente.Endereco + "|";
                registro0000 += DadosEmitente.Numero + "|";
                registro0000 += DadosEmitente.Complemento + "|";
                registro0000 += DadosEmitente.Bairro + "|";
                registro0000 += TelefoneSemMascaraEmitente + "|";
                registro0000 += DadosEmitente.FAX + "|";
                registro0000 += DadosEmitente.EMAIL + "|" + Environment.NewLine;

                // Início do Registro 0100
                registro0000 += "|0100|";
                registro0000 += DadosContabilista.Nome + "|";
                registro0000 += DadosContabilista.CPF + "|";
                registro0000 += DadosContabilista.CNPJ + "|";
                registro0000 += DadosContabilista.CEP + "|";
                registro0000 += DadosContabilista.Endereco + "|";
                registro0000 += DadosContabilista.Numero + "|";
                registro0000 += DadosContabilista.Complemento + "|";
                registro0000 += DadosContabilista.Bairro + "|";
                registro0000 += TelefoneSemMascaraContabilista + "|";
                registro0000 += DadosContabilista.FAX + "|";
                registro0000 += DadosContabilista.Email + "|";
                registro0000 += DadosContabilista.CodMunicipio + "|" + Environment.NewLine;

                // Início do registro 0150
                registro0000 += "|0150|";
                registro0000 += DadosFornecedor.Controle + "|";
                registro0000 += DadosFornecedor.NomeFantasia + "|";
                registro0000 += DadosFornecedor.CodigoPais + "|";
                registro0000 += DadosFornecedor.CNPJ + "|";
                registro0000 += DadosFornecedor.CPF + "|";
                registro0000 += DadosFornecedor.IE + "|";
                registro0000 += DadosFornecedor.CodigoCidadeIBGE + "|";
                registro0000 += DadosFornecedor.SUFRAMA + "|";
                registro0000 += DadosFornecedor.Endereco + "|";
                registro0000 += DadosFornecedor.Numero + "|";
                registro0000 += DadosFornecedor.Complemento + "|";
                registro0000 += DadosFornecedor.Bairro + "|";
                // ^^ Fornecedor ^^


                //  Cliente 
                registro0000 += DadosClientes.Controle + "|";
                registro0000 += DadosClientes.Cliente + "|";
                registro0000 += DadosClientes.CodigoPais + "|";
                registro0000 += DadosClientes.CNPJ + "|";
                registro0000 += DadosClientes.CPF + "|";
                registro0000 += DadosClientes.IE + "|";
                registro0000 += DadosClientes.CodigoCidadeIBGE + "|";
                registro0000 += DadosClientes.SUFRAMA + "|";
                registro0000 += DadosClientes.Endereco + "|";
                registro0000 += DadosClientes.Numero + "|";
                registro0000 += DadosClientes.Complemento + "|";
                registro0000 += DadosClientes.Bairro + "|" + Environment.NewLine;

                // Inicío Registro 0200
                registro0000 += "|0200|";
                registro0000 += DadosEstoque.Controle + "|";
                registro0000 += DadosEstoque.Produto + "|";
                registro0000 += DadosEstoque.CodigoBarras + "|";
                registro0000 += DadosEstoque.CodUnidadeMedida + "|";
                registro0000 += "|";
                registro0000 += DadosEstoque.NCM + "|";
                registro0000 += "|";
                registro0000 += "|";
                registro0000 += "|";
                registro0000 += DadosEstoque.CEST + "|";


                #region Salvar arquivo
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Arquivo de testo (*.txt)|.txt";
                saveFileDialog1.Title = "Salvar Arquivo SPED";
                saveFileDialog1.FileName = "Sped" + DateTime.Now.ToString(" M-yyyy");
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog1.FileName;
                    try
                    {

                        File.WriteAllText(caminhoArquivo, registro0000);

                        MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion
            }
        }
    }
}

