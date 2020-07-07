using Accounting.Model.EntityLibrary.Entityes.Computers;
using FluentValidation;

namespace Accounting.WebApi.Validators
{
    public class LaptopValidator : AbstractValidator<Laptop>
    {
        public LaptopValidator()
        {
            RuleFor(Laptop => Laptop.Id).NotNull().NotEmpty();
            RuleFor(Laptop => Laptop.DisplayName).NotNull().NotEmpty();
        }
    }
}