using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required")
                .MaximumLength(20).WithMessage("User name can not over 20 characters");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(50).WithMessage("First name can not over 50 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
               .MaximumLength(50).WithMessage("Last name can not over 50 characters");
            RuleFor(x => x.Department).NotEmpty().WithMessage("Department is required")
                .MaximumLength(50).WithMessage("Department can not empty");
            RuleFor(x => x.Division).NotEmpty().WithMessage("Division is required")
                .MaximumLength(50).WithMessage("Division can not empty");
            RuleFor(x => x.Section).NotEmpty().WithMessage("Section is required")
                .MaximumLength(50).WithMessage("Section can not empty");
        }
    }
}
