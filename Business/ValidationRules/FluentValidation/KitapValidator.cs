using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class KitapValidator : AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(k => k.KitapAd).NotEmpty();
            RuleFor(k => k.KitapAd).MinimumLength(2).WithMessage("Adınız En Az İki Harf Olmalıdır");
            RuleFor(k => k.SayfaSayisi).NotEmpty();
            RuleFor(k => k.TurId).NotEmpty();
            RuleFor(k => k.YazarId).NotEmpty();
        }
    }
}
