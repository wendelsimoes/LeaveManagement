using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class LeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public LeaveTypeDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveTypeDtoValidator(_leaveTypeRepository));

            RuleFor(l => l.Id).NotNull().WithMessage("{PropertyName} must be present.");
        }
    }
}
