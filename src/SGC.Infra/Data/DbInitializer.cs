using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infra.Data
{
	public static class DbInitializer
	{
		public static void Initialize(DataContext context)
		{
			if (context.Clientes.Any())
			{
				return; 
			}

			var clientes = new Cliente[]
			{
				new Cliente
				{
					Nome = "Fulando da Silva",
					CPF = "02311182013"
				},
				new Cliente
				{
					Nome = "Beltrano da Silva",
					CPF = "04305100045"
				}
			};
			context.AddRange(clientes);

			var contatos = new Contato[]
			{
				new Contato
				{
					Nome = "Contato 1",
					Telefone = "99999999",
					Email = "meuemail@hotmail.com",
					Cliente = clientes[0]
				},
				new Contato
				{
					Nome = "Contato 2",
					Telefone = "888888888",
					Email = "meuemail@hotmail.com",
					Cliente = clientes[1]
				}
			};
			context.AddRange(contatos);
			context.SaveChanges();
		}
	}
}
