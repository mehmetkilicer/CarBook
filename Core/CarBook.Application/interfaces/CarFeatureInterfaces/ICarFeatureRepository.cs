using Carbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.interfaces.CarFeatureInterfaces
{
	public interface ICarFeatureRepository
	{
		List<CarFeature> GetCarFeaturesByCarID(int carID);
		void ChangeCarFeatureAvailableToFalse(int id);
		void ChangeCarFeatureAvailableToTrue(int id);
		void CreateCarFeatureByCar(CarFeature carFeature);
	}
}
