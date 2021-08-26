using Daren.Baker.Bjss.Assignment.Application.Constants;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daren.Baker.Bjss.Assignment.Application.Validators
{
    public class ParameterValidator : AbstractValidator<string[]>
    {
        public ParameterValidator()
        {
            RuleForEach(p => p).NotEmpty().WithMessage(MessageValues.EmptyArgument);
            RuleForEach(p => p).Must(BeAValidProduct).WithMessage("Please specify a valid product.");
        }

        private bool BeAValidProduct(string product)
        {
            return true;
        }
    }
}
