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

    public class Fornecedor
    {
        [DisplayName("CONTROLE")]
        public string Controle { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("RAZAOSOCIAL")]
        public string RazaoSocial { get; set; }

        [DisplayName("NOMEFANTASIA")]
        public string NomeFantasia { get; set; }

        [DisplayName("ENDERECO")]
        public string Endereco { get; set; }

        [DisplayName("BAIRRO")]
        public string Bairro { get; set; }

        [DisplayName("CODCIDADE")]
        public string CodCidade { get; set; }

        [DisplayName("CODIGOCIDADEIBGE")]
        public string CodigoCidadeIBGE { get; set; }

        [DisplayName("CIDADE")]
        public string Cidade { get; set; }

        [DisplayName("CODIGOPAIS")]
        public string CodigoPais { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string Complemento { get; set; }

        [DisplayName("TELEFONE")]
        public string Telefone { get; set; }

        [DisplayName("CELULAR")]
        public string Celular { get; set; }

        [DisplayName("SAC")]
        public string SAC { get; set; }

        [DisplayName("EMAIL")]
        public string Email { get; set; }

        [DisplayName("SITE")]
        public string Site { get; set; }

        [DisplayName("FORMAPAGAMENTO")]
        public string FormaPagamento { get; set; }

        [DisplayName("PAIS")]
        public string Pais { get; set; }

        [DisplayName("NUMERO")]
        public string Numero { get; set; }

        [DisplayName("NOMECONTATOJURIDICA")]
        public string NomeContatoJuridica { get; set; }

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

        [DisplayName("MARCADO")]
        public string Marcado { get; set; }

        [DisplayName("ATIVO")]
        public string Ativo { get; set; }

        [DisplayName("CODEMITENTE")]
        public string CodEmitente { get; set; }

        [DisplayName("CONTRIBUINTEIPI")]
        public string ContribuinteIPI { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }
    }
    public class FornecedorEntityTypeConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)

        {

            builder.ToTable("TFORNECEDOR");
            builder.HasKey(e => e.Controle);
            builder.Property(e => e.Controle).HasColumnName("CONTROLE");
            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");
            builder.Property(e => e.RazaoSocial).HasColumnName("RAZAOSOCIAL");
            builder.Property(e => e.NomeFantasia).HasColumnName("NOMEFANTASIA");
            builder.Property(e => e.Endereco).HasColumnName("ENDERECO");
            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");
            builder.Property(e => e.CodCidade).HasColumnName("CODCIDADE");
            builder.Property(e => e.CodigoCidadeIBGE).HasColumnName("CODIGOCIDADEIBGE");
            builder.Property(e => e.Cidade).HasColumnName("CIDADE");
            builder.Property(e => e.CodigoPais).HasColumnName("CODIGOPAIS");
            builder.Property(e => e.UF).HasColumnName("UF");
            builder.Property(e => e.CEP).HasColumnName("CEP");
            builder.Property(e => e.RG).HasColumnName("RG");
            builder.Property(e => e.CPF).HasColumnName("CPF");
            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");
            builder.Property(e => e.IE).HasColumnName("IE");
            builder.Property(e => e.IM).HasColumnName("IM");
            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO");
            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");
            builder.Property(e => e.Celular).HasColumnName("CELULAR");
            builder.Property(e => e.SAC).HasColumnName("SAC");
            builder.Property(e => e.Email).HasColumnName("EMAIL");
            builder.Property(e => e.Site).HasColumnName("SITE");
            builder.Property(e => e.FormaPagamento).HasColumnName("FORMAPAGAMENTO");
            builder.Property(e => e.Pais).HasColumnName("PAIS");
            builder.Property(e => e.Numero).HasColumnName("NUMERO");
            builder.Property(e => e.NomeContatoJuridica).HasColumnName("NOMECONTATOJURIDICA");
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
            builder.Property(e => e.Marcado).HasColumnName("MARCADO");
            builder.Property(e => e.Ativo).HasColumnName("ATIVO");
            builder.Property(e => e.CodEmitente).HasColumnName("CODEMITENTE");
            builder.Property(e => e.ContribuinteIPI).HasColumnName("CONTRIBUINTEIPI");
            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");
        }
    }
}
