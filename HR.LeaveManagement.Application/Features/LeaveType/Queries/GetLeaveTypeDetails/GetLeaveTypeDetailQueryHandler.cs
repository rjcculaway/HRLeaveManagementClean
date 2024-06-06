using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails {
    public class GetLeaveTypeDetailQueryHandler : IRequestHandler<GetLeaveTypeDetailQuery, LeaveTypeDetailDto> {
        private readonly Mapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailQueryHandler(Mapper mapper, ILeaveTypeRepository leaveTypeRepository) {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetailQuery request, CancellationToken cancellationToken) {
            // Query from database
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);
            // Map to DTO
            var data = _mapper.Map<LeaveTypeDetailDto>(leaveType);
            // Return DTO
            return data;
        }
    }
}
