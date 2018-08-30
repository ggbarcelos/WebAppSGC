using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.Application.Core.Entity;

namespace SGC.Infra.EntityConfig
{
	public class MenuMap : IEntityTypeConfiguration<Menu>
	{
		public void Configure(EntityTypeBuilder<Menu> builder)
		{
			builder
				.HasMany(m => m.SubMenu)
				.WithOne()
				.HasForeignKey(m => m.MenuId);
		}
	}
}
