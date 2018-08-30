using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infra.Repository
{
	public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
	{
		public ClienteRepository(DataContext dbcontext) 
			: base(dbcontext)
		{

		}

		public Cliente ObterPorProfissao(int clienteId)
		{
			return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteId))
				.FirstOrDefault();
		}
	}

}
