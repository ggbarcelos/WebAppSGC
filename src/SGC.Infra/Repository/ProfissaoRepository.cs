using SGC.Application.Core.Entity;
using SGC.Application.Core.Interfaces.Repository;
using SGC.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infra.Repository
{
	public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
	{
		public ProfissaoRepository(DataContext dbcontext) 
			: base(dbcontext)
		{

		}
	}
}
