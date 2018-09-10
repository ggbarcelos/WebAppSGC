using SGC.Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Application.Core.Interfaces.Services
{
	public interface IEnderecoService
	{
		Endereco Adicionar(Endereco entity);
		void Atualizar(Endereco entity);
		IEnumerable<Endereco> ObterTodos();
		Endereco ObterPorId(int id);
		IEnumerable<Endereco> Buscar(Expression<Func<Endereco, bool>> predicado);
		void Remover(Endereco entity);
	}
}
