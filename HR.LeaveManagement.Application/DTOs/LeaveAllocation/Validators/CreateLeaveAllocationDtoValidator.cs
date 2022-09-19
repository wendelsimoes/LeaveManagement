using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationDtoValidator()
        {
            RuleFor(l => l.NumberOfDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
                .LessThan(100).WithMessage("{PropertyName} must be less than 100.");

            RuleFor(l => l.LeaveTypeId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.");

            RuleFor(l => l.Period)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.");
        }
    }
}
