using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.Name).Must(StartWithA).WithMessage("Car A harfi ile başlamalı");
            RuleFor(c => c.PlakaNo).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(200);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
