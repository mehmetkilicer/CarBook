﻿using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.StaticQueries
{
	public class GetAvgRentPriceForDailyQuery : IRequest<GetAvgRentPriceForDailyQueryResult>
	{
	}
}
