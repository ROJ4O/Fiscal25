using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class NFCE
    {
        [DisplayName("Controle")]
        public int Controle { get; set; }

        [DisplayName("Data e Hora de Cadastro")]
        public DateTime DataHoraCadastro { get; set; }

        [DisplayName("Data de Emissão")]
        public DateTime DataEmissao { get; set; }

        [DisplayName("Número NF-e")]
        public string NumeroNFCE { get; set; }

        [DisplayName("Número SAT")]
        public string NumeroSAT { get; set; }

        [DisplayName("Tipo de Ambiente")]
        public string TipoAmbiente { get; set; }

        [DisplayName("Chave NF-e")]
        public string ChaveNFCE { get; set; }

        [DisplayName("Protocolo")]
        public string Protocolo { get; set; }

        [DisplayName("Protocolo de Cancelamento")]
        public string ProtocoloCancelamento { get; set; }

        [DisplayName("Código de Status")]
        public int CodigoStatus { get; set; }

        [DisplayName("Status de Envio")]
        public string StatusEnvio { get; set; }

        [DisplayName("Inutilizada")]
        public bool Inutilizada { get; set; }

        [DisplayName("Código do Cliente")]
        public int CodCliente { get; set; }

        [DisplayName("Cliente")]
        public string Cliente { get; set; }

        [DisplayName("Código do Funcionário")]
        public int CodFuncionario { get; set; }

        [DisplayName("Funcionário")]
        public string Funcionario { get; set; }

        [DisplayName("Código do Centro de Custo")]
        public int CodCentroCusto { get; set; }

        [DisplayName("Centro de Custo")]
        public string CentroCusto { get; set; }

        [DisplayName("Valor do Produto")]
        public decimal ValorProduto { get; set; }

        [DisplayName("Percentual de Acréscimo")]
        public decimal PercAcrescimo { get; set; }

        [DisplayName("Valor do Acréscimo")]
        public decimal ValorAcrescimo { get; set; }

        [DisplayName("Percentual de Desconto")]
        public decimal PercDesconto { get; set; }

        [DisplayName("Valor do Desconto")]
        public decimal ValorDesconto { get; set; }

        [DisplayName("Valor do Desconto Item")]
        public decimal ValorDescontoItem { get; set; }

        [DisplayName("Valor Base de Cálculo ICMS")]
        public decimal ValorBCICMS { get; set; }

        [DisplayName("Valor do ICMS")]
        public decimal ValorICMS { get; set; }

        [DisplayName("Valor Base de Cálculo ST")]
        public decimal ValorBCST { get; set; }

        [DisplayName("Valor do ST")]
        public decimal ValorST { get; set; }

        [DisplayName("Valor do PIS")]
        public decimal ValorPIS { get; set; }

        [DisplayName("Valor do COFINS")]
        public decimal ValorCOFINS { get; set; }

        [DisplayName("Valor do Seguro")]
        public decimal ValorSeguro { get; set; }

        [DisplayName("Valor de Outros")]
        public decimal ValorOutros { get; set; }

        [DisplayName("Valor de Outros Item")]
        public decimal ValorOutrosItem { get; set; }

        [DisplayName("Valor Base de Cálculo do Serviço")]
        public decimal ValorBCServico { get; set; }

        [DisplayName("Valor do ISS")]
        public decimal ValorISS { get; set; }

        [DisplayName("Valor do Serviço")]
        public decimal ValorServico { get; set; }

        [DisplayName("Valor Total da NF-e")]
        public decimal ValorTotalNFCE { get; set; }

        [DisplayName("Natureza da Operação")]
        public string NaturezaOperacao { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [DisplayName("Série")]
        public string Serie { get; set; }

        [DisplayName("Data de Saída/Entrada")]
        public DateTime DataSaidaEntrada { get; set; }

        [DisplayName("Hora de Saída/Entrada")]
        public string HoraSaidaEntrada { get; set; }

        [DisplayName("Tipo de Emissão")]
        public string TipoEmissao { get; set; }

        [DisplayName("Telefone do Cliente")]
        public string FoneCliente { get; set; }

        [DisplayName("CEP do Cliente")]
        public string CEPCliente { get; set; }

        [DisplayName("Endereço do Cliente")]
        public string EnderecoCliente { get; set; }

        [DisplayName("Complemento do Cliente")]
        public string ComplementoCliente { get; set; }

        [DisplayName("UF do Cliente")]
        public string UFCliente { get; set; }

        [DisplayName("Cidade do Cliente")]
        public string CidadeCliente { get; set; }

        [DisplayName("Código IBGE da Cidade do Cliente")]
        public int CodCidadeIBGECliente { get; set; }

        [DisplayName("CPF do Cliente")]
        public string CPFCliente { get; set; }

        [DisplayName("CNPJ do Cliente")]
        public string CNPJCliente { get; set; }

        [DisplayName("IM do Cliente")]
        public string IMCliente { get; set; }

        [DisplayName("CNAE do Cliente")]
        public string CNAECliente { get; set; }

        [DisplayName("Número do Cliente")]
        public string NumeroCliente { get; set; }

        [DisplayName("Bairro do Cliente")]
        public string BairroCliente { get; set; }

        [DisplayName("Justificativa do Cancelamento")]
        public string JustificativaCancelamento { get; set; }

        [DisplayName("Data e Hora do Cancelamento")]
        public DateTime DataHoraCancelamento { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Código da Comanda")]
        public string CodComanda { get; set; }

        [DisplayName("Código DAV")]
        public string CodDAV { get; set; }

        [DisplayName("Código de Pré-venda")]
        public string CodPreVenda { get; set; }

        [DisplayName("Número DAV")]
        public string NumeroDAV { get; set; }

        [DisplayName("Valor do Troco")]
        public decimal ValorTroco { get; set; }

        [DisplayName("Código OS")]
        public string CodOS { get; set; }

        [DisplayName("Já Faturado")]
        public bool JaFaturado { get; set; }

        [DisplayName("SAT")]
        public string SAT { get; set; }

        [DisplayName("Informação Adicional")]
        public string InformacaoAdicional { get; set; }

        [DisplayName("Identificação")]
        public string Identificacao { get; set; }

        [DisplayName("Código do Operador")]
        public int CodOperador { get; set; }

        [DisplayName("Operador")]
        public string Operador { get; set; }

        [DisplayName("MD5 J1")]
        public string MD5J1 { get; set; }

        [DisplayName("Indicador")]
        public string Indicador { get; set; }

        [DisplayName("Chave Anterior Contingência")]
        public string ChaveAnteriorContingencia { get; set; }

        [DisplayName("ID Pagamento VFP")]
        public string IDPagamentoVFP { get; set; }

        [DisplayName("ID Resposta Fiscal")]
        public string IDRespostaFiscal { get; set; }

        [DisplayName("Verificado")]
        public bool Verificado { get; set; }

        [DisplayName("CNF")]
        public string CNF { get; set; }

        [DisplayName("Status de Contingência")]
        public string StatusContingencia { get; set; }

        [DisplayName("Sincronizado")]
        public bool Sincronizado { get; set; }

        [DisplayName("Código da Nota Manual")]
        public string CodNotaManual { get; set; }

        [DisplayName("ID Estrangeiro")]
        public string IDEstrangeiro { get; set; }
    }
    public class NFCEEntityTypeConfiguration : IEntityTypeConfiguration<NFCE>
    {
        public void Configure(EntityTypeBuilder<NFCE> builder)
        {
            builder.ToTable("TVENDANFCE");
            builder.HasKey(e => e.Controle);
            builder.Property(e => e.Controle).HasColumnName("CONTROLE");
            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAEHORACADASTRO");
            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");
            builder.Property(e => e.NumeroNFCE).HasColumnName("NUMERONFCCE");
            builder.Property(e => e.NumeroSAT).HasColumnName("NUMEROSAT");
            builder.Property(e => e.TipoAmbiente).HasColumnName("TIPOAMBIENTE");
            builder.Property(e => e.ChaveNFCE).HasColumnName("CHAVENFCE");
            builder.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");
            builder.Property(e => e.ProtocoloCancelamento).HasColumnName("PROTOCOLOCANCELAMENTO");
            builder.Property(e => e.CodigoStatus).HasColumnName("CODIGOSTATUS");
            builder.Property(e => e.StatusEnvio).HasColumnName("STATUSENVIO");
            builder.Property(e => e.Inutilizada).HasColumnName("INUTILIZADA");
            builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");
            builder.Property(e => e.Cliente).HasColumnName("CLIENTE");
            builder.Property(e => e.CodFuncionario).HasColumnName("CODFUNCIONARIO");
            builder.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");
            builder.Property(e => e.CodCentroCusto).HasColumnName("CODCENTROCUSTO");
            builder.Property(e => e.CentroCusto).HasColumnName("CENTROCUSTO");
            builder.Property(e => e.ValorProduto).HasColumnName("VALORPRODUTO");
            builder.Property(e => e.PercAcrescimo).HasColumnName("PERCACRESCIMO");
            builder.Property(e => e.ValorAcrescimo).HasColumnName("VALORACRESCIMO");
            builder.Property(e => e.PercDesconto).HasColumnName("PERCDESCONTO");
            builder.Property(e => e.ValorDesconto).HasColumnName("VALORDESCONTO");
            builder.Property(e => e.ValorDescontoItem).HasColumnName("VALORDESCONTOITEM");
            builder.Property(e => e.ValorBCICMS).HasColumnName("VALORBCICMS");
            builder.Property(e => e.ValorICMS).HasColumnName("VALORICMS");
            builder.Property(e => e.ValorBCST).HasColumnName("VALORBCST");
            builder.Property(e => e.ValorST).HasColumnName("VALORST");
            builder.Property(e => e.ValorPIS).HasColumnName("VALORPIS");
            builder.Property(e => e.ValorCOFINS).HasColumnName("VALORCOFINS");
            builder.Property(e => e.ValorSeguro).HasColumnName("VALORSEGURO");
            builder.Property(e => e.ValorOutros).HasColumnName("VALOROUTROS");
            builder.Property(e => e.ValorOutrosItem).HasColumnName("VALOROUTROSITEM");
            builder.Property(e => e.ValorBCServico).HasColumnName("VALORBCSERVICO");
            builder.Property(e => e.ValorISS).HasColumnName("VALORISS");
            builder.Property(e => e.ValorServico).HasColumnName("VALORSERVICO");
            builder.Property(e => e.ValorTotalNFCE).HasColumnName("VALORTOTALNFCE");
            builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");
            builder.Property(e => e.Modelo).HasColumnName("MODELO");
            builder.Property(e => e.Serie).HasColumnName("SERIE");
            builder.Property(e => e.DataSaidaEntrada).HasColumnName("DATASAIDAENTRADA");
            builder.Property(e => e.HoraSaidaEntrada).HasColumnName("HORASAIDAENTRADA");
            builder.Property(e => e.TipoEmissao).HasColumnName("TIPOEMISSAO");
            builder.Property(e => e.FoneCliente).HasColumnName("FONECLIENTE");
            builder.Property(e => e.CEPCliente).HasColumnName("CEPCLIENTE");
            builder.Property(e => e.EnderecoCliente).HasColumnName("ENDERECOCLIENTE");
            builder.Property(e => e.ComplementoCliente).HasColumnName("COMPLEMENTOCLIENTE");
            builder.Property(e => e.UFCliente).HasColumnName("UFCLIENTE");
            builder.Property(e => e.CidadeCliente).HasColumnName("CIDADECLIENTE");
            builder.Property(e => e.CodCidadeIBGECliente).HasColumnName("CODCIDADEIBGECLIENTE");
            builder.Property(e => e.CPFCliente).HasColumnName("CPFCLIENTE");
            builder.Property(e => e.CNPJCliente).HasColumnName("CNPJCLIENTE");
            builder.Property(e => e.IMCliente).HasColumnName("IMCLIENTE");
            builder.Property(e => e.CNAECliente).HasColumnName("CNAECLIENTE");
            builder.Property(e => e.NumeroCliente).HasColumnName("NUMEROCLIENTE");
            builder.Property(e => e.BairroCliente).HasColumnName("BAIRROCLIENTE");
            builder.Property(e => e.JustificativaCancelamento).HasColumnName("JUSTIFICATIVACANCELAMENTO");
            builder.Property(e => e.DataHoraCancelamento).HasColumnName("DATAEHORACANCELAMENTO");
            builder.Property(e => e.Email).HasColumnName("EMAIL");
            builder.Property(e => e.CodComanda).HasColumnName("CODCOMANDA");
            builder.Property(e => e.CodDAV).HasColumnName("CODDAV");
            builder.Property(e => e.CodPreVenda).HasColumnName("CODPREVENDA");
            builder.Property(e => e.NumeroDAV).HasColumnName("NUMERODAV");
            builder.Property(e => e.ValorTroco).HasColumnName("VALORTROCO");
            builder.Property(e => e.CodOS).HasColumnName("CODOS");
            builder.Property(e => e.JaFaturado).HasColumnName("JAFATURADO");
            builder.Property(e => e.SAT).HasColumnName("SAT");
            builder.Property(e => e.InformacaoAdicional).HasColumnName("INFORMACAOADICIONAL");
            builder.Property(e => e.Identificacao).HasColumnName("IDENTIFICACAO");
            builder.Property(e => e.CodOperador).HasColumnName("CODOPERADOR");
            builder.Property(e => e.Operador).HasColumnName("OPERADOR");
            builder.Property(e => e.MD5J1).HasColumnName("MD5J1");
            builder.Property(e => e.Indicador).HasColumnName("INDICADOR");
            builder.Property(e => e.ChaveAnteriorContingencia).HasColumnName("CHAVEANTERIORCONTINGENCIA");
            builder.Property(e => e.IDPagamentoVFP).HasColumnName("IDPAGAMENTOVFP");
            builder.Property(e => e.IDRespostaFiscal).HasColumnName("IDRESPOSTAFISCAL");
            builder.Property(e => e.Verificado).HasColumnName("VERIFICADO");
            builder.Property(e => e.CNF).HasColumnName("CNF");
            builder.Property(e => e.StatusContingencia).HasColumnName("STATUSCONTINGENCIA");
            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");
            builder.Property(e => e.CodNotaManual).HasColumnName("CODNOTAMANUAL");
            builder.Property(e => e.IDEstrangeiro).HasColumnName("IDESTRANGEIRO");
        }
    }
}
