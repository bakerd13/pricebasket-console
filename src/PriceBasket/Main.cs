using Daren.Baker.Bjss.Assignment.Application.Validators;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceBasket
{
    internal class Main : IMain
    {
        private readonly IValidator<string[]> _parameterValidator;

        public Main(IValidator<string[]> parameterValidator)
        {
            _parameterValidator = parameterValidator;
        }

        public void Startup(string[] args)
        {
            if (!Validate(args)) return;


        }

        private bool Validate(string[] args)
        {
            ValidationResult results = _parameterValidator.Validate(args);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine(failure.ErrorMessage);
                }
            }

            return results.IsValid;
        }
    }
}
