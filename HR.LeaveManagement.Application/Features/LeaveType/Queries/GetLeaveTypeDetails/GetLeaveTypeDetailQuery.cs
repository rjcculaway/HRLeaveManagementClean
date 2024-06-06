﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails {
    public record GetLeaveTypeDetailQuery : IRequest<LeaveTypeDetailDto> {
        public int Id { get; set; }
    }
}
