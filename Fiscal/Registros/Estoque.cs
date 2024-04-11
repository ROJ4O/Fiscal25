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
    public class Estoque
    {
        [DisplayName("CONTROLE")]
        public string Controle { get; set; }

        [DisplayName("PRODUTO")]
        public string Produto { get; set; }

        [DisplayName("TIPOBARRA")]
        public string TipoBarra { get; set; }

        [DisplayName("CODBARRAS")]
        public string CodigoBarras { get; set; }

        [DisplayName("UNIDADE")]
        public string Unidade { get; set; }

        [DisplayName("PRECOCUSTO")]
        public string PrecoCusto { get; set; }

        [DisplayName("PERCLUCRO")]
        public string PercentualLucro { get; set; }

        [DisplayName("PRECOVENDA")]
        public string PrecoVenda { get; set; }

        [DisplayName("CODGRUPO")]
        public string CodGrupo { get; set; }

        [DisplayName("GRUPO")]
        public string Grupo { get; set; }

        [DisplayName("CODFORNECEDOR")]
        public string CodFornecedor { get; set; }

        [DisplayName("FORNECEDOR")]
        public string Fornecedor { get; set; }

        [DisplayName("TAMANHO")]
        public string Tamanho { get; set; }

        [DisplayName("PESO")]
        public string Peso { get; set; }

        [DisplayName("CUSTOULTIMACOMPRA")]
        public string CustoUltimaCompra { get; set; }

        [DisplayName("CUSTOMEDIO")]
        public string CustoMedio { get; set; }

        [DisplayName("QTDETOTALCOMPRADA")]
        public string QtdeTotalComprada { get; set; }

        [DisplayName("QTDETOTALVENDIDA")]
        public string QtdeTotalVendida { get; set; }

        [DisplayName("DATAULTIMACOMPRA")]
        public string DataUltimaCompra { get; set; }

        [DisplayName("DATAULTIMAVENDA")]
        public string DataUltimaVenda { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public string DataHoraCadastro { get; set; }

        [DisplayName("QTDEMINIMA")]
        public string QtdeMinima { get; set; }

        [DisplayName("QTDEMAXIMA")]
        public string QtdeMaxima { get; set; }

        [DisplayName("QTDE")]
        public string Qtde { get; set; }

        [DisplayName("ATIVO")]
        public string Ativo { get; set; }

        [DisplayName("NCM")]
        public string NCM { get; set; }

        [DisplayName("PERCREDITOCICMS")]
        public string PercentualCreditoICMS { get; set; }

        [DisplayName("USAGRADE")]
        public string UsaGrade { get; set; }

        [DisplayName("USASERIAL")]
        public string UsaSerial { get; set; }

        [DisplayName("ORIGEM")]
        public string Origem { get; set; }

        [DisplayName("CODTRIBUTACAOIPI")]
        public string CodTributacaoIPI { get; set; }

        [DisplayName("TRIBUTACAOIPI")]
        public string TributacaoIPI { get; set; }

        [DisplayName("CODTRIBUTACAOPIS")]
        public string CodTributacaoPIS { get; set; }

        [DisplayName("CODTRIBUTACAOCOFINS")]
        public string CodTributacaoCOFINS { get; set; }

        [DisplayName("TRIBUTACAOPIS")]
        public string TributacaoPIS { get; set; }

        [DisplayName("TRIBUTACAOCOFINS")]
        public string TributacaoCOFINS { get; set; }

        [DisplayName("TIPOTRIBUTACAO")]
        public string TipoTributacao { get; set; }

        [DisplayName("PERCICMSSTINTERNA")]
        public string PercentualICMSSTInterna { get; set; }

        [DisplayName("PERCMVAORIGINAL")]
        public string PercMVAOriginal { get; set; }

        [DisplayName("POSSUIICMSST")]
        public string PossuiICMSST { get; set; }

        [DisplayName("ISENTO")]
        public string Isento { get; set; }

        [DisplayName("PERCICMSPROPRIOST")]
        public string PercentualICMSProprioST { get; set; }

        [DisplayName("IAT")]
        public string IAT { get; set; }

        [DisplayName("IPPT")]
        public string IPPT { get; set; }

        [DisplayName("TRIBUTADO")]
        public string Tributado { get; set; }

        [DisplayName("CSOSN")]
        public string CSOSN { get; set; }

        [DisplayName("DESCRICAOCSOSN")]
        public string DescricaoCSOSN { get; set; }

        [DisplayName("PESADO")]
        public string Pesado { get; set; }

        [DisplayName("BASECALCULOICMSSTRETIDO")]
        public string BaseCalculoICMSSTRetido { get; set; }

        [DisplayName("VALORICMSSTRETIDO")]
        public string ValorICMSSTRetido { get; set; }

        [DisplayName("ALIQUOTAICMSECF")]
        public string AliquotaICMSECF { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("MENSAGEMNFE")]
        public string MensagemNFE { get; set; }

        [DisplayName("CODMENSAGEMNFE")]
        public string CodMensagemNFE { get; set; }

        [DisplayName("CODUNIDADEMEDIDA")]
        public string CodUnidadeMedida { get; set; }

        [DisplayName("CODAPLICACAOPRODUTO")]
        public string CodAplicacaoProduto { get; set; }

        [DisplayName("APLICACAOPRODUTO")]
        public string AplicacaoProduto { get; set; }

        [DisplayName("MD5E2")]
        public string MD5E2 { get; set; }

        [DisplayName("QTDEINICIAL")]
        public string QtdeInicial { get; set; }

        [DisplayName("ALIQUOTAISS")]
        public string AliquotaISS { get; set; }

        [DisplayName("CODIMPOSTOMEDIO")]
        public string CodImpostoMedio { get; set; }

        [DisplayName("PERCIMPOSTOMEDIO")]
        public string PercImpostoMedio { get; set; }

        [DisplayName("CODCSTORIGEM")]
        public string CodCSTOrigem { get; set; }

        [DisplayName("CODIGOCSTORIGEM")]
        public string CodigoCSTOrigem { get; set; }

        [DisplayName("CODEMITENTE")]
        public string CodEmitente { get; set; }

        [DisplayName("DIASVALIDADEPRODUTO")]
        public string DiasValidadeProduto { get; set; }

        [DisplayName("FATORCONVERSAO")]
        public string FatorConversao { get; set; }

        [DisplayName("TRIBUTACAOSERVICO")]
        public string TributacaoServico { get; set; }

        [DisplayName("REDUCAOBASECALCULOSERVICO")]
        public string ReducaoBaseCalculoServico { get; set; }

        [DisplayName("STATUS")]
        public string Status { get; set; }

        [DisplayName("DESCRICAOCOMPLEMENTAR")]
        public string DescricaoComplementar { get; set; }

        [DisplayName("REFERENCIA")]
        public string Referencia { get; set; }

        [DisplayName("PRECOVENDAUSS")]
        public string PrecoVendaUSS { get; set; }

        [DisplayName("PERCMAXIMODESCONTO")]
        public string PercentualMaximoDesconto { get; set; }

        [DisplayName("VALORCOMISSAOFIXO")]
        public string ValorComissaoFixo { get; set; }

        [DisplayName("PERCCOMISSAO")]
        public string PercentualComissao { get; set; }

        [DisplayName("PRECOMINIMOUSS")]
        public string PrecoMinimoUSS { get; set; }

        [DisplayName("PRECOMINIMO")]
        public string PrecoMinimo { get; set; }

        [DisplayName("CODCOMPRA")]
        public string CodCompra { get; set; }

        [DisplayName("VALORCONVERSAO")]
        public string ValorConversao { get; set; }

        [DisplayName("VALORFRETE")]
        public string ValorFrete { get; set; }

        [DisplayName("VALOROUTROS")]
        public string ValorOutros { get; set; }

        [DisplayName("VALORICMSST")]
        public string ValorICMSST { get; set; }

        [DisplayName("VALORIPI")]
        public string ValorIPI { get; set; }

        [DisplayName("VALORUNITARIOCOMPRA")]
        public string ValorUnitarioCompra { get; set; }

        [DisplayName("PERCPIS")]
        public string PercentualPIS { get; set; }

        [DisplayName("PERCCOFINS")]
        public string PercentualCOFINS { get; set; }

        [DisplayName("CAMPO1")]
        public string Campo1 { get; set; }

        [DisplayName("CAMPO2")]
        public string Campo2 { get; set; }

        [DisplayName("CAMPO3")]
        public string Campo3 { get; set; }

        [DisplayName("CAMPO4")]
        public string Campo4 { get; set; }

        [DisplayName("CAMPO5")]
        public string Campo5 { get; set; }

        [DisplayName("CAMPO6")]
        public string Campo6 { get; set; }

        [DisplayName("CAMPO7")]
        public string Campo7 { get; set; }

        [DisplayName("CAMPO8")]
        public string Campo8 { get; set; }

        [DisplayName("CAMPO9")]
        public string Campo9 { get; set; }

        [DisplayName("CAMPO10")]
        public string Campo10 { get; set; }

        [DisplayName("MARCA")]
        public string Marca { get; set; }

        [DisplayName("PERCREDUCAOBC")]
        public string PercentualReducaoBC { get; set; }

        [DisplayName("PERCREDUCAOBCST")]
        public string PercentualReducaoBCST { get; set; }

        [DisplayName("CODSUBGRUPO")]
        public string CodSubgrupo { get; set; }

        [DisplayName("SUBGRUPO")]
        public string Subgrupo { get; set; }

        [DisplayName("CONTROLARVALIDADE")]
        public string ControlarValidade { get; set; }

        [DisplayName("CODMARCA")]
        public string CodMarca { get; set; }

        [DisplayName("PRECOREVENDA")]
        public string PrecoRevenda { get; set; }

        [DisplayName("PERCIPI")]
        public string PercIPI { get; set; }

        [DisplayName("CFOP")]
        public string CFOP { get; set; }

        [DisplayName("UNIDADECONVERSAOVENDA")]
        public string UnidadeConversaoVenda { get; set; }

        [DisplayName("VALORCONVERSAOVENDA")]
        public string ValorConversaoVenda { get; set; }

        [DisplayName("CODTABELAPRECO")]
        public string CodTabelaPreco { get; set; }

        [DisplayName("NOMETABELAPRECO")]
        public string NomeTabelaPreco { get; set; }

        [DisplayName("PERCIMPOSTOMEDIOESTADUAL")]
        public string PercImpostoMedioEstadual { get; set; }

        [DisplayName("PERCIMPOSTOMEDIOMUNICIPAL")]
        public string PercImpostoMedioMunicipal { get; set; }

        [DisplayName("CODIGOENQUADRAMENTOIPI")]
        public string CodigoEnquadramentoIPI { get; set; }

        [DisplayName("CEST")]
        public string CEST { get; set; }

        [DisplayName("QTDEEMPRODUCAO")]
        public string QtdeEmProducao { get; set; }

        [DisplayName("QTDEPEDIDOVENDA")]
        public string QtdePedidoVenda { get; set; }

        [DisplayName("QTDEPEDIDOCOMPRA")]
        public string QtdePedidoCompra { get; set; }

        [DisplayName("QTDERESERVADA")]
        public string QtdeReservada { get; set; }

        [DisplayName("QTDEREAL")]
        public string QtdeReal { get; set; }

        [DisplayName("QTDEEMPRODUCAOMP")]
        public string QtdeEmProducaoMP { get; set; }

        [DisplayName("UNIDADEMEDIDAETIQUETA")]
        public string UnidadeMedidaEtiqueta { get; set; }

        [DisplayName("FATORCONVERSAOETIQUETA")]
        public string FatorConversaoEtiqueta { get; set; }

        [DisplayName("CODIGOANP")]
        public string CodigoANP { get; set; }

        [DisplayName("DESCRICAOANP")]
        public string DescricaoANP { get; set; }

        [DisplayName("PERCGLPCOMB")]
        public string PercGLPComb { get; set; }

        [DisplayName("PERCGNNCOMB")]
        public string PercGNNComb { get; set; }

        [DisplayName("PERCGNICOMB")]
        public string PercGNiComb { get; set; }

        [DisplayName("VALORPARTIDACOMB")]
        public string ValorPartidaComb { get; set; }

        [DisplayName("CNPJFABRICANTE")]
        public string CNPJFabricante { get; set; }

        [DisplayName("CODBENEFICIOFISCAL")]
        public string CodBeneficioFiscal { get; set; }

        [DisplayName("CODIGOANVISA")]
        public string CodigoANVISA { get; set; }

        [DisplayName("SELOIPI")]
        public string SeloIPI { get; set; }

        [DisplayName("ALIQUOTAFCP")]
        public string AliquotaFCP { get; set; }

        [DisplayName("PERCFCPST")]
        public string PercFCPST { get; set; }

        [DisplayName("CODUNIDADETRIBUTAVEL")]
        public string CodUnidadeTributavel { get; set; }

        [DisplayName("UNIDADETRIBUTAVEL")]
        public string UnidadeTributavel { get; set; }

        [DisplayName("QTDETRIBUTAVEL")]
        public string QtdeTributavel { get; set; }

        [DisplayName("DESMONTARNAVENDA")]
        public string DesmontarNaVenda { get; set; }

        [DisplayName("ALIQUOTAICMSSTRET")]
        public string AliquotaICMSSTRet { get; set; }

        [DisplayName("VALORBCICMSSTRET")]
        public string ValorBCICMSSTRet { get; set; }

        [DisplayName("VALORICMSSTRET")]
        public string ValorICMSSTRet { get; set; }

        [DisplayName("ALIQUOTAICMSEFET")]
        public string AliquotaICMSEfet { get; set; }

        [DisplayName("PERCREDUCAOICMSEFET")]
        public string PercentualReducaoICMSEfet { get; set; }

        [DisplayName("VALORBCICMSEFET")]
        public string ValorBCICMSEfet { get; set; }

        [DisplayName("VALORICMSEFET")]
        public string ValorICMSEfet { get; set; }

        [DisplayName("VALORICMSSUBSTITUTO")]
        public string ValorICMSSubstituto { get; set; }

        [DisplayName("CODBARRASCAIXA")]
        public string CodigoBarrasCaixa { get; set; }

        [DisplayName("ENVIARDADOS")]
        public string EnviarDados { get; set; }

        [DisplayName("VALORPMC")]
        public string ValorPMC { get; set; }

        [DisplayName("MD5O")]
        public string MD5O { get; set; }

        [DisplayName("MD5S")]
        public string MD5S { get; set; }

        [DisplayName("VALORFCPST")]
        public string ValorFCPST { get; set; }

        [DisplayName("LOCALIZACAO")]
        public string Localizacao { get; set; }

        [DisplayName("VOLUME")]
        public string Volume { get; set; }

        [DisplayName("MOSTRARCOZINHA")]
        public string MostrarCozinha { get; set; }

        [DisplayName("CODBARRASINTERNO")]
        public string CodigoBarrasInterno { get; set; }

        [DisplayName("CODBARRASTRIB")]
        public string CodigoBarrasTrib { get; set; }

        [DisplayName("VACINA")]
        public string Vacina { get; set; }

        [DisplayName("PERCDESCONTOCAIXA")]
        public string PercentualDescontoCaixa { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string Sincronizado { get; set; }

        [DisplayName("PERCCASHBACK")]
        public string PercentualCashback { get; set; }
    }
    public class EstoqueEntityTypeConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {

            builder.ToTable("TESTOQUE");
            builder.HasKey(e => e.Controle);
            builder.Property(e => e.Controle).HasColumnName("CONTROLE");
            builder.Property(e => e.Produto).HasColumnName("PRODUTO");
            builder.Property(e => e.TipoBarra).HasColumnName("TIPOBARRA");
            builder.Property(e => e.CodigoBarras).HasColumnName("CODBARRAS");
            builder.Property(e => e.Unidade).HasColumnName("UNIDADE");
            builder.Property(e => e.PrecoCusto).HasColumnName("PRECOCUSTO");
            builder.Property(e => e.PercentualLucro).HasColumnName("PERCLUCRO");
            builder.Property(e => e.PrecoVenda).HasColumnName("PRECOVENDA");
            builder.Property(e => e.CodGrupo).HasColumnName("CODGRUPO");
            builder.Property(e => e.Grupo).HasColumnName("GRUPO");
            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");
            builder.Property(e => e.Fornecedor).HasColumnName("FORNECEDOR");
            builder.Property(e => e.Tamanho).HasColumnName("TAMANHO");
            builder.Property(e => e.Peso).HasColumnName("PESO");
            builder.Property(e => e.CustoUltimaCompra).HasColumnName("CUSTOULTIMACOMPRA");
            builder.Property(e => e.CustoMedio).HasColumnName("CUSTOMEDIO");
            builder.Property(e => e.QtdeTotalComprada).HasColumnName("QTDETOTALCOMPRADA");
            builder.Property(e => e.QtdeTotalVendida).HasColumnName("QTDETOTALVENDIDA");
            builder.Property(e => e.DataUltimaCompra).HasColumnName("DATAULTIMACOMPRA");
            builder.Property(e => e.DataUltimaVenda).HasColumnName("DATAULTIMAVENDA");
            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");
            builder.Property(e => e.QtdeMinima).HasColumnName("QTDEMINIMA");
            builder.Property(e => e.QtdeMaxima).HasColumnName("QTDEMAXIMA");
            builder.Property(e => e.Qtde).HasColumnName("QTDE");
            builder.Property(e => e.Ativo).HasColumnName("ATIVO");
            builder.Property(e => e.NCM).HasColumnName("NCM");
            builder.Property(e => e.PercentualCreditoICMS).HasColumnName("PERCREDITOCICMS");
            builder.Property(e => e.UsaGrade).HasColumnName("USAGRADE");
            builder.Property(e => e.UsaSerial).HasColumnName("USASERIAL");
            builder.Property(e => e.Origem).HasColumnName("ORIGEM");
            builder.Property(e => e.CodTributacaoIPI).HasColumnName("CODTRIBUTACAOIPI");
            builder.Property(e => e.TributacaoIPI).HasColumnName("TRIBUTACAOIPI");
            builder.Property(e => e.CodTributacaoPIS).HasColumnName("CODTRIBUTACAOPIS");
            builder.Property(e => e.CodTributacaoCOFINS).HasColumnName("CODTRIBUTACAOCOFINS");
            builder.Property(e => e.TributacaoPIS).HasColumnName("TRIBUTACAOPIS");
            builder.Property(e => e.TributacaoCOFINS).HasColumnName("TRIBUTACAOCOFINS");
            builder.Property(e => e.TipoTributacao).HasColumnName("TIPOTRIBUTACAO");
            builder.Property(e => e.PercentualICMSSTInterna).HasColumnName("PERCICMSSTINTERNA");
            builder.Property(e => e.PercMVAOriginal).HasColumnName("PERCMVAORIGINAL");
            builder.Property(e => e.PossuiICMSST).HasColumnName("POSSUIICMSST");
            builder.Property(e => e.Isento).HasColumnName("ISENTO");
            builder.Property(e => e.PercentualICMSProprioST).HasColumnName("PERCICMSPROPRIOST");
            builder.Property(e => e.IAT).HasColumnName("IAT");
            builder.Property(e => e.IPPT).HasColumnName("IPPT");
            builder.Property(e => e.Tributado).HasColumnName("TRIBUTADO");
            builder.Property(e => e.CSOSN).HasColumnName("CSOSN");
            builder.Property(e => e.DescricaoCSOSN).HasColumnName("DESCRICAOCSOSN");
            builder.Property(e => e.Pesado).HasColumnName("PESADO");
            builder.Property(e => e.BaseCalculoICMSSTRetido).HasColumnName("BASECALCULOICMSSTRETIDO");
            builder.Property(e => e.ValorICMSSTRetido).HasColumnName("VALORICMSSTRETIDO");
            builder.Property(e => e.AliquotaICMSECF).HasColumnName("ALIQUOTAICMSECF");
            builder.Property(e => e.MD5).HasColumnName("MD5");
            builder.Property(e => e.MensagemNFE).HasColumnName("MENSAGEMNFE");
            builder.Property(e => e.CodMensagemNFE).HasColumnName("CODMENSAGEMNFE");
            builder.Property(e => e.CodUnidadeMedida).HasColumnName("CODUNIDADEMEDIDA");
            builder.Property(e => e.CodAplicacaoProduto).HasColumnName("CODAPLICACAOPRODUTO");
            builder.Property(e => e.AplicacaoProduto).HasColumnName("APLICACAOPRODUTO");
            builder.Property(e => e.MD5E2).HasColumnName("MD5E2");
            builder.Property(e => e.QtdeInicial).HasColumnName("QTDEINICIAL");
            builder.Property(e => e.AliquotaISS).HasColumnName("ALIQUOTAISS");
            builder.Property(e => e.CodImpostoMedio).HasColumnName("CODIMPOSTOMEDIO");
            builder.Property(e => e.PercImpostoMedio).HasColumnName("PERCIMPOSTOMEDIO");
            builder.Property(e => e.CodCSTOrigem).HasColumnName("CODCSTORIGEM");
            builder.Property(e => e.CodigoCSTOrigem).HasColumnName("CODIGOCSTORIGEM");
            builder.Property(e => e.CodEmitente).HasColumnName("CODEMITENTE");
            builder.Property(e => e.DiasValidadeProduto).HasColumnName("DIASVALIDADEPRODUTO");
            builder.Property(e => e.FatorConversao).HasColumnName("FATORCONVERSAO");
            builder.Property(e => e.TributacaoServico).HasColumnName("TRIBUTACAOSERVICO");
            builder.Property(e => e.ReducaoBaseCalculoServico).HasColumnName("REDUCAOBASECALCULOSERVICO");
            builder.Property(e => e.Status).HasColumnName("STATUS");
            builder.Property(e => e.DescricaoComplementar).HasColumnName("DESCRICAOCOMPLEMENTAR");
            builder.Property(e => e.Referencia).HasColumnName("REFERENCIA");
            builder.Property(e => e.PrecoVendaUSS).HasColumnName("PRECOVENDAUSS");
            builder.Property(e => e.PercentualMaximoDesconto).HasColumnName("PERCMAXIMODESCONTO");
            builder.Property(e => e.ValorComissaoFixo).HasColumnName("VALORCOMISSAOFIXO");
            builder.Property(e => e.PercentualComissao).HasColumnName("PERCCOMISSAO");
            builder.Property(e => e.PrecoMinimoUSS).HasColumnName("PRECOMINIMOUSS");
            builder.Property(e => e.PrecoMinimo).HasColumnName("PRECOMINIMO");
            builder.Property(e => e.CodCompra).HasColumnName("CODCOMPRA");
            builder.Property(e => e.ValorConversao).HasColumnName("VALORCONVERSAO");
            builder.Property(e => e.ValorFrete).HasColumnName("VALORFRETE");
            builder.Property(e => e.ValorOutros).HasColumnName("VALOROUTROS");
            builder.Property(e => e.ValorICMSST).HasColumnName("VALORICMSST");
            builder.Property(e => e.ValorIPI).HasColumnName("VALORIPI");
            builder.Property(e => e.ValorUnitarioCompra).HasColumnName("VALORUNITARIOCOMPRA");
            builder.Property(e => e.PercentualPIS).HasColumnName("PERCPIS");
            builder.Property(e => e.PercentualCOFINS).HasColumnName("PERCCOFINS");
            builder.Property(e => e.Campo1).HasColumnName("CAMPO1");
            builder.Property(e => e.Campo2).HasColumnName("CAMPO2");
            builder.Property(e => e.Campo3).HasColumnName("CAMPO3");
            builder.Property(e => e.Campo4).HasColumnName("CAMPO4");
            builder.Property(e => e.Campo5).HasColumnName("CAMPO5");
            builder.Property(e => e.Campo6).HasColumnName("CAMPO6");
            builder.Property(e => e.Campo7).HasColumnName("CAMPO7");
            builder.Property(e => e.Campo8).HasColumnName("CAMPO8");
            builder.Property(e => e.Campo9).HasColumnName("CAMPO9");
            builder.Property(e => e.Campo10).HasColumnName("CAMPO10");
            builder.Property(e => e.Marca).HasColumnName("MARCA");
            builder.Property(e => e.PercentualReducaoBC).HasColumnName("PERCREDUCAOBC");
            builder.Property(e => e.PercentualReducaoBCST).HasColumnName("PERCREDUCAOBCST");
            builder.Property(e => e.CodSubgrupo).HasColumnName("CODSUBGRUPO");
            builder.Property(e => e.Subgrupo).HasColumnName("SUBGRUPO");
            builder.Property(e => e.ControlarValidade).HasColumnName("CONTROLARVALIDADE");
            builder.Property(e => e.CodMarca).HasColumnName("CODMARCA");
            builder.Property(e => e.PrecoRevenda).HasColumnName("PRECOREVENDA");
            builder.Property(e => e.PercIPI).HasColumnName("PERCIPI");
            builder.Property(e => e.CFOP).HasColumnName("CFOP");
            builder.Property(e => e.UnidadeConversaoVenda).HasColumnName("UNIDADECONVERSAOVENDA");
            builder.Property(e => e.ValorConversaoVenda).HasColumnName("VALORCONVERSAOVENDA");
            builder.Property(e => e.CodTabelaPreco).HasColumnName("CODTABELAPRECO");
            builder.Property(e => e.NomeTabelaPreco).HasColumnName("NOMETABELAPRECO");
            builder.Property(e => e.PercImpostoMedioEstadual).HasColumnName("PERCIMPOSTOMEDIOESTADUAL");
            builder.Property(e => e.PercImpostoMedioMunicipal).HasColumnName("PERCIMPOSTOMEDIOMUNICIPAL");
            builder.Property(e => e.CodigoEnquadramentoIPI).HasColumnName("CODIGOENQUADRAMENTOIPI");
            builder.Property(e => e.CEST).HasColumnName("CEST");
            builder.Property(e => e.QtdeEmProducao).HasColumnName("QTDEEMPRODUCAO");
            builder.Property(e => e.QtdePedidoVenda).HasColumnName("QTDEPEDIDOVENDA");
            builder.Property(e => e.QtdePedidoCompra).HasColumnName("QTDEPEDIDOCOMPRA");
            builder.Property(e => e.QtdeReservada).HasColumnName("QTDERESERVADA");
            builder.Property(e => e.QtdeReal).HasColumnName("QTDEREAL");
            builder.Property(e => e.QtdeEmProducaoMP).HasColumnName("QTDEEMPRODUCAOMP");
            builder.Property(e => e.UnidadeMedidaEtiqueta).HasColumnName("UNIDADEMEDIDAETIQUETA");
            builder.Property(e => e.FatorConversaoEtiqueta).HasColumnName("FATORCONVERSAOETIQUETA");
            builder.Property(e => e.CodigoANP).HasColumnName("CODIGOANP");
            builder.Property(e => e.DescricaoANP).HasColumnName("DESCRICAOANP");
            builder.Property(e => e.PercGLPComb).HasColumnName("PERCGLPCOMB");
            builder.Property(e => e.PercGNNComb).HasColumnName("PERCGNNCOMB");
            builder.Property(e => e.PercGNiComb).HasColumnName("PERCGNICOMB");
            builder.Property(e => e.ValorPartidaComb).HasColumnName("VALORPARTIDACOMB");
            builder.Property(e => e.CNPJFabricante).HasColumnName("CNPJFABRICANTE");
            builder.Property(e => e.CodBeneficioFiscal).HasColumnName("CODBENEFICIOFISCAL");
            builder.Property(e => e.CodigoANVISA).HasColumnName("CODIGOANVISA");
            builder.Property(e => e.SeloIPI).HasColumnName("SELOIPI");
            builder.Property(e => e.AliquotaFCP).HasColumnName("ALIQUOTAFCP");
            builder.Property(e => e.PercFCPST).HasColumnName("PERCFCPST");
            builder.Property(e => e.CodUnidadeTributavel).HasColumnName("CODUNIDADETRIBUTAVEL");
            builder.Property(e => e.UnidadeTributavel).HasColumnName("UNIDADETRIBUTAVEL");
            builder.Property(e => e.QtdeTributavel).HasColumnName("QTDETRIBUTAVEL");
            builder.Property(e => e.DesmontarNaVenda).HasColumnName("DESMONTARNAVENDA");
            builder.Property(e => e.AliquotaICMSSTRet).HasColumnName("ALIQUOTAICMSSTRET");
            builder.Property(e => e.ValorBCICMSSTRet).HasColumnName("VALORBCICMSSTRET");
            builder.Property(e => e.ValorICMSSTRet).HasColumnName("VALORICMSSTRET");
            builder.Property(e => e.AliquotaICMSEfet).HasColumnName("ALIQUOTAICMSEFET");
            builder.Property(e => e.PercentualReducaoICMSEfet).HasColumnName("PERCREDUCAOICMSEFET");
            builder.Property(e => e.ValorBCICMSEfet).HasColumnName("VALORBCICMSEFET");
            builder.Property(e => e.ValorICMSEfet).HasColumnName("VALORICMSEFET");
            builder.Property(e => e.ValorICMSSubstituto).HasColumnName("VALORICMSSUBSTITUTO");
            builder.Property(e => e.CodigoBarrasCaixa).HasColumnName("CODBARRASCAIXA");
            builder.Property(e => e.EnviarDados).HasColumnName("ENVIARDADOS");
            builder.Property(e => e.ValorPMC).HasColumnName("VALORPMC");
            builder.Property(e => e.MD5O).HasColumnName("MD5O");
            builder.Property(e => e.MD5S).HasColumnName("MD5S");
            builder.Property(e => e.ValorFCPST).HasColumnName("VALORFCPST");
            builder.Property(e => e.Localizacao).HasColumnName("LOCALIZACAO");
            builder.Property(e => e.Volume).HasColumnName("VOLUME");
            builder.Property(e => e.MostrarCozinha).HasColumnName("MOSTRARCOZINHA");
            builder.Property(e => e.CodigoBarrasInterno).HasColumnName("CODBARRASINTERNO");
            builder.Property(e => e.CodigoBarrasTrib).HasColumnName("CODBARRASTRIB");
            builder.Property(e => e.Vacina).HasColumnName("VACINA");
            builder.Property(e => e.PercentualDescontoCaixa).HasColumnName("PERCDESCONTOCAIXA");
            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");
            builder.Property(e => e.PercentualCashback).HasColumnName("PERCCASHBACK");
        }
    }
}