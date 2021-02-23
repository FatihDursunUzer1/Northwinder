using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductID).GreaterThan(0);
            RuleFor(p => (int)p.UnitsInStock).GreaterThan(0);
            RuleFor(p => p.ProductName.Length).GreaterThan(2);
            RuleFor(p => (int)p.UnitsInStock).GreaterThan(10).When(p => p.CategoryID == 1);
        }
    }
}
