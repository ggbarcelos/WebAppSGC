using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Application.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Application.Core.Services
{
	public class EnderecoService : IEnderecoService
	{
		private readonly IEnderecoRepository _repository;

		public EnderecoService(IEnderecoRepository repository)
		{
			_repository = repository;
		}

		public Endereco Adicionar(Endereco entity)
		{
			//TODO: Adicionar regra de necocio
			return _repository.Adicionar(entity);
		}

		public void Atualizar(Endereco entity)
		{
			_repository.Atualizar(entity);
		}

		public IEnumerable<Endereco> Buscar(Expression<Func<Endereco, bool>> predicado)
		{
			return _repository.Buscar(predicado);
		}

		public Endereco ObterPorId(int id)
		{
			return _repository.ObterPorId(id);
		}

		public IEnumerable<Endereco> ObterTodos()
		{
			return _repository.ObterTodos();
		}

		public void Remover(Endereco entity)
		{
			_repository.Remover(entity);
		}
	}
}
