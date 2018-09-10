using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Application.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Application.Core.Services
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _repository;

		public ClienteService(IClienteRepository repository)
		{
			_repository = repository;
		}

		public Cliente Adicionar(Cliente entity)
		{
			//TODO: Adicionar regra de necocio
			return _repository.Adicionar(entity);
		}

		public void Atualizar(Cliente entity)
		{
			_repository.Atualizar(entity);
		}

		public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
		{
			return _repository.Buscar(predicado);
		}

		public Cliente ObterPorId(int id)
		{
			return _repository.ObterPorId(id);
		}

		public IEnumerable<Cliente> ObterTodos()
		{
			return _repository.ObterTodos();
		}

		public void Remover(Cliente entity)
		{
			_repository.Remover(entity);
		}
	}
}
