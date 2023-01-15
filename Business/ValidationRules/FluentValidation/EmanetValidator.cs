using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class EmanetValidator : AbstractValidator<Emanet>
    {
        public EmanetValidator()
        {
            RuleFor(e => e.KitapId).NotEmpty();
            RuleFor(e => e.OgrenciId).NotEmpty();
            RuleFor(e => e.AlinanTarih).NotEmpty();
            RuleFor(e => e.VerilecekTarih).NotEmpty();
        }
    }
}
