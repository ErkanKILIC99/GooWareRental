using FluentValidation;
using FluentValidation.Results;
using GooWareRental.Entities.Concretes;

namespace GooWareRental.BusinessLogicLayer.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(color => color.ColorName).NotEmpty();
        }
    }
}
