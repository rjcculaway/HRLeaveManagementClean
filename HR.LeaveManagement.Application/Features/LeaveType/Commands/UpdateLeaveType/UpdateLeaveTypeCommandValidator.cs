﻿using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType; 
public class UpdateLeaveTypeCommandValidator : AbstractValidator<UpdateLeaveTypeCommand> {
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public UpdateLeaveTypeCommandValidator(ILeaveTypeRepository leaveTypeRepository) {
        _leaveTypeRepository = leaveTypeRepository;

        RuleFor(p => p)
            .NotNull()
            .MustAsync(LeaveTypeMustExist)
            .WithMessage("Leave type must exist.");

        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(70).WithMessage("{PropertyName} must not exceed 70 characters.");

        RuleFor(p => p.DefaultDays)
            .LessThan(100).WithMessage("{PropertyName} must not exceed 100 days.")
            .GreaterThan(1).WithMessage("{PropertyName} cannot be less than 1.");

        RuleFor(q => q)
            .MustAsync(LeaveTypeNameUnique)
            .WithMessage("Leave type already exists.");
    }

    private async Task<bool> LeaveTypeMustExist(UpdateLeaveTypeCommand command, CancellationToken token) {
        return await _leaveTypeRepository.GetByIdAsync(command.Id) != null;
    }

    private async Task<bool> LeaveTypeNameUnique(UpdateLeaveTypeCommand command, CancellationToken token) {
        return await _leaveTypeRepository.IsLeaveTypeUnique(command.Name);
    }
}
