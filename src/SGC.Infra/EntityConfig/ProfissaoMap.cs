using SGC.Application.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SGC.Infra.EntityConfig
{
	public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
	{
		public void Configure(EntityTypeBuilder<Profissao> builder)
		{
			builder
				.Property(p => p.Nome)
				.HasColumnType("varchar(400)")
				.IsRequired();
			builder
				.Property(p => p.CBO)
				.HasColumnType("varchar(10)")
				.IsRequired();
			builder
				.Property(p => p.Descricao)
				.HasColumnType("varchar(1000)")
				.IsRequired();
		}
	}
}
