using FluentValidation;
using School.Core.Features.Students.Commands.Models;

namespace School.Core.Features.Students.Commands.Validatiors;

public class AddStudentValidator : AbstractValidator<AddStudentCommand>
{
    #region Fields
    #endregion

    #region Ctor
    public AddStudentValidator()
    {
        ApplyValidationsRules();
        ApplyCustomValidationsRules();

    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Name)
            .MaximumLength(15).WithMessage("Max Length For Name is 15")
            .NotEmpty().WithMessage("Name Must be Decliared")
            .NotNull().WithMessage("Name Cannot Null");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("Address Must be Decliared")
            .NotNull().WithMessage("Address Cannot Null");
    }

    public void ApplyCustomValidationsRules()
    {

    }
    #endregion

}
