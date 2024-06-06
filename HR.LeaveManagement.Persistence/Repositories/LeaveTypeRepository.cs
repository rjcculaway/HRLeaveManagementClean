using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories {
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository {
        public LeaveTypeRepository(HrDatabaseContext context) : base(context) {
        }

        public async Task<bool> IsLeaveTypeUnique(string name) {
            return await _context.LeaveTypes.AnyAsync(q => q.Name == name);
        }
    }
}
