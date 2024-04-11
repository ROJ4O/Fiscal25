
using Fiscal.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class DataContext
    {
        public class ConnectionParams
        {
            public string ConnectionString()
            {
                return $"DataSource=localhost;Database=C:\\Users\\Roger\\source\\repos\\Fiscal\\BD\\BASES.FDB;Port=3050;User=SYSDBA;Password=masterkey" +
                $";Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
                // Conexão BD
            }
        }
        public class ConnectBd : DbContext
        {
            public DbSet<Contabilista> Contabilista { get; set; }
            public DbSet<Clientes> Clientes { get; set; }
            public DbSet<Compras> Compras { get; set; }
            public DbSet<Fornecedor> Fornecedor { get; set; }
            public DbSet<Emitente> Emitente { get; set; }
            public DbSet<NFCE> NFCE { get; set; }
            public DbSet<NFE> NFE { get; set; }
            public DbSet<Estoque> Estoque { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                new ContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<Contabilista>());
                new ClienteEntityTypeConfiguration().Configure(modelBuilder.Entity<Clientes>());
                new ComprasEntityTypeConfiguration().Configure(modelBuilder.Entity<Compras>());
                new FornecedorEntityTypeConfiguration().Configure(modelBuilder.Entity<Fornecedor>());
                new EmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<Emitente>());
                new NFCEEntityTypeConfiguration().Configure(modelBuilder.Entity<NFCE>());
                new NFEEntityTypeConfiguration().Configure(modelBuilder.Entity<NFE>());
                new EstoqueEntityTypeConfiguration().Configure(modelBuilder.Entity<Estoque>());
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\Users\\Roger\\source\\repos\\Fiscal\\BD\\BASES.FDB;Port=3050;User=SYSDBA;Password=masterkey" +
                $";Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");
        }
    }
}
