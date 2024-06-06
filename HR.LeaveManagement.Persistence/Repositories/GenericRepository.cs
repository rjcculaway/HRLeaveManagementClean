﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories {
    public class GenericRepository<T> : IGenericRepository<T> where T : class {
        protected readonly HrDatabaseContext _context;

        public GenericRepository(HrDatabaseContext context) {
            this._context = context;
        }
        public async Task<IReadOnlyList<T>> GetAsync() {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task CreateAsync(T entity) {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity) {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity) {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}