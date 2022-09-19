using FluentValidation;
using HR.LeaveManagement.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public UpdateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;

            RuleFor(l => l.StartDate)
                .LessThan(l => l.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(l => l.EndDate)
                .GreaterThan(l => l.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(l => l.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveTypeExists = await _leaveRequestRepository.Exists(id);
                    return leaveTypeExists;
                })
                .WithMessage("{PropertyName} does not exist.");
        }
    }
}
