using Carbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.interfaces.ReviewInterfaces
{
	public interface IReviewRepository
	{
		public List<Review> GetReviewsByCarId(int carId);
	}
}
