using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Application.Core.Entity
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public ICollection<Contato> Contatos { get; set; }
	}
}
