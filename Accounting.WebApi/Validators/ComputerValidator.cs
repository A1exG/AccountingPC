using Accounting.Model.EntityLibrary.Entityes.Computers;
using FluentValidation;

namespace Accounting.WebApi.Validators
{
    public class ComputerValidator : AbstractValidator<Computer>
    {
        public ComputerValidator()
        {
            RuleFor(Computer => Computer.Id).NotNull().NotEmpty();
            RuleFor(Computer => Computer.DisplayName).NotNull().NotEmpty();
        }
    }
}