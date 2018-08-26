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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>().ToTable("Cliente");
		}
	}
}
