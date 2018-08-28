using Microsoft.EntityFrameworkCore;
using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infra.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			:base(options)
		{

		}

		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Contato> Contatos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>().ToTable("Cliente");
			modelBuilder.Entity<Contato>().ToTable("Contato");
			modelBuilder.Entity<Endereco>().ToTable("Endereco");
			modelBuilder.Entity<Profissao>().ToTable("Profissao");
			modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

			#region Configuração de Clientes
			modelBuilder.Entity<Cliente>()
				.HasKey(c => c.ClienteId);

			modelBuilder.Entity<Cliente>()
				.HasMany(c => c.Contatos)
				.WithOne(c => c.Cliente)
				.HasForeignKey(c => c.ClienteId)
				.HasPrincipalKey(c => c.ClienteId);

			modelBuilder.Entity<Cliente>().Property(e => e.CPF)
				.HasColumnType("varchar(11)")
				.IsRequired();

			modelBuilder.Entity<Cliente>().Property(e => e.Nome)
				.HasColumnType("varchar(200)")
				.IsRequired();
			#endregion

			#region Configurações de Contato
			modelBuilder.Entity<Contato>()
				.HasOne(x => x.Cliente)
				.WithMany(x => x.Contatos)
				.HasForeignKey(x => x.ClienteId)
				.HasPrincipalKey(x => x.ClienteId);

			modelBuilder.Entity<Contato>().Property(e => e.Nome)
				.HasColumnType("varchar(200)")
				.IsRequired();

			modelBuilder.Entity<Contato>().Property(e => e.Email)
				.HasColumnType("varchar(100)")
				.IsRequired();

			modelBuilder.Entity<Contato>().Property(e => e.Telefone)
				.HasColumnType("varchar(15)");
			#endregion

			#region Configuração de Profissao
			modelBuilder.Entity<Profissao>().Property(p => p.Nome)
				.HasColumnType("varchar(400)")
				.IsRequired();
			modelBuilder.Entity<Profissao>().Property(p => p.CBO)
				.HasColumnType("varchar(10)")
				.IsRequired();
			modelBuilder.Entity<Profissao>().Property(p => p.Descricao)
				.HasColumnType("varchar(1000)")
				.IsRequired();
			#endregion

			#region Configuração Endereco
			modelBuilder.Entity<Endereco>().Property(end => end.Bairro)
				.HasColumnType("varchar(200)")
				.IsRequired();
			modelBuilder.Entity<Endereco>().Property(end => end.CEP)
				.HasColumnType("varchar(15)")
				.IsRequired();
			modelBuilder.Entity<Endereco>().Property(end => end.Logradouro)
				.HasColumnType("varchar(200)")
				.IsRequired();
			modelBuilder.Entity<Endereco>().Property(end => end.Referencia)
				.HasColumnType("varchar(400)");
			#endregion

			#region Configuração ProfissãoCliente
			modelBuilder.Entity<ProfissaoCliente>()
				.HasKey(pc => pc.Id);
			modelBuilder.Entity<ProfissaoCliente>()				
				.HasOne(pc => pc.Cliente)
				.WithMany(pc => pc.ProfissoesClientes)
				.HasForeignKey(pc => pc.ClienteId);
			modelBuilder.Entity<ProfissaoCliente>()
				.HasOne(pc => pc.Profissao)
				.WithMany(pc => pc.ProfissoesClientes)
				.HasForeignKey(pc => pc.ProfissaoId
);
			#endregion

			#region Configuração Menu
			modelBuilder.Entity<Menu>().HasMany(m => m.SubMenu)
				.WithOne()
				.HasForeignKey(m => m.MenuId);
			#endregion
		}
	}
}
