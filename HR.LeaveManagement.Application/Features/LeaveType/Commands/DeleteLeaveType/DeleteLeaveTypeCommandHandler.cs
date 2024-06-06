using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType {
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit> {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository) {
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken) {
            // Validate incoming data

            // Retrieve domain entity object from database
            var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

            // Verify that record exists

            // Remove from database
            await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

            return Unit.Value;
        }
    }
}
