using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Application.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Application.Core.Services
{
	public class ProfissaoService : IProfissaoService
	{
		private readonly IProfissaoRepository _repository;

		public ProfissaoService(IProfissaoRepository repository)
		{
			_repository = repository;
		}

		public Profissao Adicionar(Profissao entity)
		{
			//TODO: Adicionar regra de necocio
			return _repository.Adicionar(entity);
		}

		public void Atualizar(Profissao entity)
		{
			_repository.Atualizar(entity);
		}

		public IEnumerable<Profissao> Buscar(Expression<Func<Profissao, bool>> predicado)
		{
			return _repository.Buscar(predicado);
		}

		public Profissao ObterPorId(int id)
		{
			return _repository.ObterPorId(id);
		}

		public IEnumerable<Profissao> ObterTodos()
		{
			return _repository.ObterTodos();
		}

		public void Remover(Profissao entity)
		{
			_repository.Remover(entity);
		}
	}
}
