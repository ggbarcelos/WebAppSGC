using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infra.EntityConfig
{
	public class ClienteMap : IEntityTypeConfiguration<Cliente>
	{
		public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			builder
				.HasKey(c => c.ClienteId);
			builder
				.HasOne(x => x.Endereco)
				.WithOne(x => x.Cliente)
				.HasForeignKey<Endereco>(x => x.ClienteId);
			builder
				.HasMany(c => c.Contatos)
				.WithOne(c => c.Cliente)
				.HasForeignKey(c => c.ClienteId)
				.HasPrincipalKey(c => c.ClienteId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Property(e => e.Nome)
				.HasColumnType("varchar(11)")
				.IsRequired();

			builder
				.Property(e => e.Nome)
				.HasColumnType("varchar(200)")
				.IsRequired();
		}
	}
}
