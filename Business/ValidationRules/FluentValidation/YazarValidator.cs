using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class YazarValidator : AbstractValidator<Yazar>
    {
        public YazarValidator()
        {
            RuleFor(y => y.YazarAd).NotEmpty();
            RuleFor(y => y.YazarSoyad).NotEmpty();
        }
    }
}
