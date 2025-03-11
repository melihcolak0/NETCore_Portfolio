using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş geçilemez!");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel alanı 2 boş geçilemez!");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje URL alanı 2 boş geçilemez!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel 1 boş geçilemez!");
            RuleFor(x => x.Image2).NotEmpty().WithMessage("Görsel 2 boş geçilemez!");
            RuleFor(x => x.Image3).NotEmpty().WithMessage("Görsel 3 boş geçilemez!");
            RuleFor(x => x.Image4).NotEmpty().WithMessage("Görsel 4 boş geçilemez!");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform URL boş geçilemez!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ücret boş geçilemez!");
            RuleFor(x => x.Rate).NotEmpty().WithMessage("Proje Durmumu boş geçilemez!");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Durum boş geçilemez!");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakter olmalıdır!");
            RuleFor(x => x.Name).MaximumLength(300).WithMessage("Proje adı en fazla 300 karakter olamlıdır!");
        }
    }
}
