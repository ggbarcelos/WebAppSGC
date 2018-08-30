using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infra.Repository
{
	public class EnderecoRepository : EFRepository<Endereco>, IEnderecoRepository
	{
		public EnderecoRepository(DataContext dbcontext) 
			: base(dbcontext)
		{

		}
	}
}
