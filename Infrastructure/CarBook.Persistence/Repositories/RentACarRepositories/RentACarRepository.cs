using CarBook.Application.interfaces.RentACarInterfaces;
using Carbook.Domain.Entities;
using CarBook.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.RentACarRepositories
{
	public class RentACarRepository : IRentACarRepository
	{
		private readonly CarBookContext _context;
		public RentACarRepository(CarBookContext context)
		{
			_context = context;
		}
		public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
		{
			var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
			return values;
		}
	}
}
