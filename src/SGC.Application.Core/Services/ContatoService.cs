using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Application.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Application.Core.Services
{
	public class ContatoService : IContatoService
	{
		private readonly IContatoRepository _repository;

		public ContatoService(IContatoRepository repository)
		{
			_repository = repository;
		}

		public Contato Adicionar(Contato entity)
		{
			//TODO: Adicionar regra de necocio
			return _repository.Adicionar(entity);
		}

		public void Atualizar(Contato entity)
		{
			_repository.Atualizar(entity);
		}

		public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
		{
			return _repository.Buscar(predicado);
		}

		public Contato ObterPorId(int id)
		{
			return _repository.ObterPorId(id);
		}

		public IEnumerable<Contato> ObterTodos()
		{
			return _repository.ObterTodos();
		}

		public void Remover(Contato entity)
		{
			_repository.Remover(entity);
		}
	}
}
