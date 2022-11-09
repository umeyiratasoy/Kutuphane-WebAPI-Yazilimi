using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Descriptionn).NotEmpty();
            RuleFor(c => c.Descriptionn).MinimumLength(2).WithMessage("Araba İsmi En Az İki Harf Olmalıdır");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Araba Fiyatı Sıfırdan Küçük Olamaz");
        }

    }
}
