using CarBook.Application.Features.Mediator.Queries.StaticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResult>
	{
		private readonly IStatisticsRepository _repository;

		public GetAvgRentPriceForDailyQueryHandler(IStatisticsRepository repository)
		{
			_repository = repository;
		}

		public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
		{
			var value = _repository.GetAvgRentPriceForDaily();
			return new GetAvgRentPriceForDailyQueryResult
			{
				AvgPriceForDaily = value
			};
		}
	}
}
