﻿using FluentValidation;
using FluentValidation.Results;
using MediatR;
using QuickSalesApp.Application.Messaging;

namespace QuickSalesApp.Application.Behavior
{
    public sealed class ValidationBehavior<TRequest, TResponse> :
         IPipelineBehavior<TRequest, TResponse>
         where TRequest : class, ICommand<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            if (!_validators.Any())
            {
                return await next();
            }


            var context = new ValidationContext<TRequest>(request);

            var errorDictinary = _validators
                .Select(x => x.Validate(context))
                .SelectMany(x => x.Errors)
                .Where(x => x != null)
                .GroupBy(
                x => x.PropertyName,
                x => x.ErrorMessage, (propertyName, errorMessage) => new
                {
                    Key = propertyName,
                    Values = errorMessage.Distinct().ToArray()
                })
                .ToDictionary(x => x.Key, x => x.Values[0]);


            if (errorDictinary.Any())
            {
                var errors = errorDictinary.Select(s => new ValidationFailure
                {
                    PropertyName = s.Value,
                    ErrorCode = s.Key
                });
                throw new ValidationException(errors);
            }
            return await next();

        }
    }
}
