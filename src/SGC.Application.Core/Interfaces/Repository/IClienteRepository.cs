using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Application.Core.Interfaces.Repository
{
	public interface IClienteRepository : IRepository<Cliente>
	{
		Cliente ObterPorProfissao(int ClienteId);
	}
}
