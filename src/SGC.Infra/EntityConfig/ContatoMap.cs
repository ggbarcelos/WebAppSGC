using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infra.EntityConfig
{
	public class ContatoMap : IEntityTypeConfiguration<Contato>
	{
		public void Configure(EntityTypeBuilder<Contato> builder)
		{
			builder
				.HasOne(x => x.Cliente)
				.WithMany(x => x.Contatos)
				.HasForeignKey(x => x.ClienteId)
				.HasPrincipalKey(x => x.ClienteId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Property(e => e.Nome)
				.HasColumnType("varchar(200)")
				.IsRequired();

			builder
				.Property(e => e.Email)
				.HasColumnType("varchar(100)")
				.IsRequired();

			builder
				.Property(e => e.Telefone)
				.HasColumnType("varchar(15)");
		}
	}
}
