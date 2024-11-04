﻿using CarBook.Application.Features.Mediator.Commands.AuthorCommands;
using CarBook.Application.interfaces;
using Carbook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class CreatePricingCommandHandler : IRequestHandler<CreateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;
		public CreatePricingCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}
		public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Author
			{
				Name = request.Name,
				Description = request.Description,
				ImageUrl = request.ImageUrl
			});
		}
	}
}