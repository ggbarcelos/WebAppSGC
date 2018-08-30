using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.Application.Core.Entity;

namespace SGC.Infra.EntityConfig
{
	public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
	{
		public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
		{
			builder
				.HasKey(pc => pc.Id);
			builder
				.HasOne(pc => pc.Cliente)
				.WithMany(pc => pc.ProfissoesClientes)
				.HasForeignKey(pc => pc.ClienteId)
				.OnDelete(DeleteBehavior.Restrict);
			builder
				.HasOne(pc => pc.Profissao)
				.WithMany(pc => pc.ProfissoesClientes)
				.HasForeignKey(pc => pc.ProfissaoId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
