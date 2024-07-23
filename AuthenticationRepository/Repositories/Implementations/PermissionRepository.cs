﻿using AuthenticationDomain;
using AuthenticationRepository.Context;
using AuthenticationRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationRepository.Repositories.Implementations
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(IdentityDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Permission>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Permission> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<Permission>> GetByIdsAsync(List<string> permissionIds)
        {
            return await _dbSet.Where(x=>permissionIds.Contains(x.Id.ToString())).ToListAsync();
        }

        public async Task AddAsync(Permission permission)
        {
            await _dbSet.AddAsync(permission);
        }

        public void Delete(Permission permission)
        {
            _dbSet.Remove(permission);
        }
    }
}
