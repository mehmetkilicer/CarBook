﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.interfaces;
using Carbook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
	public class RemovePricingCommandHandler : IRequestHandler<RemoveBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

		public RemovePricingCommandHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}
		public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}
}