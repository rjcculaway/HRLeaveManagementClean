using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType {
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int> {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository) {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken) {
            // Validate incoming data

            // Convert to domain entity object
            var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

            // Add to database
            await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);

            // Return record ID
            return leaveTypeToCreate.Id;
        }
    }
}
