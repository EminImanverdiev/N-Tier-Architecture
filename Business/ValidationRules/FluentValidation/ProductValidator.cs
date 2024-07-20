using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
                .MinimumLength(2)
                .NotEmpty()
                .Must(StartWithA);
            RuleFor(p => p.UnitPrice)
                .NotEmpty()
                .GreaterThan(0)
                .GreaterThanOrEqualTo(10)
                .When(p=>p.CategoryId==1);
            RuleFor(p=>p.UnitsInStock)
                .NotEmpty()
                .GreaterThan(0);

            
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
