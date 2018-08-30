using Microsoft.EntityFrameworkCore;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Infra.Repository
{
	public class EFRepository<T> : IRepository<T> where T : class
	{
		protected readonly DataContext _dbcontext;

		public EFRepository(DataContext dbcontext)
		{
			_dbcontext = dbcontext;
		}

		public T Adicionar(T entity)
		{
			_dbcontext.Set<T>().Add(entity);
			_dbcontext.SaveChanges();
			return entity;
		}

		public void Atualizar(T entity)
		{
			_dbcontext.Entry(entity).State = EntityState.Modified;
			_dbcontext.SaveChanges();
		}

		public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
		{
			return _dbcontext.Set<T>().Where(predicado).AsEnumerable();
		}

		public T ObterPorId(int id)
		{
			return _dbcontext.Set<T>().Find(id);
		}

		public IEnumerable<T> ObterTodos()
		{
			return _dbcontext.Set<T>().AsEnumerable();
		}

		public void Remover(T entity)
		{
			_dbcontext.Set<T>().Remove(entity);
			_dbcontext.SaveChanges();
		}
	}
}
