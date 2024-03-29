﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
	public interface IContatoRepository : IBaseRepository<Contato>
	{
		IEnumerable<Contato> BuscarContatosComInclude();
		Contato BuscarContatoComInclude(Guid id);
	}
}
