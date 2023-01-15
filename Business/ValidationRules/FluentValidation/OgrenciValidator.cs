using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OgrenciValidator : AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(o => o.OgrenciAd).NotEmpty();
            RuleFor(o => o.OgrenciAd).MinimumLength(2).WithMessage("Adınız En Az İki Harf Olmalıdır");
            RuleFor(o => o.OgrenciSoyad).NotEmpty();
            RuleFor(o => o.OgrenciSoyad).MinimumLength(2).WithMessage("SoyAdınız En Az İki Harf Olmalıdır");
            RuleFor(o => o.Cinsiyet).NotEmpty();
            RuleFor(o => o.Cinsiyet).MinimumLength(3).WithMessage("Cinsiyet En Az Üç Harf Olmalıdır");
            RuleFor(o => o.DogumTarihi).NotEmpty();
            RuleFor(o => o.Sinif).NotEmpty();
        }
    }
}
