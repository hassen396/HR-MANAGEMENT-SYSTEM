using HRSystem.Domain.Entities;
using HRSystem.Domain.Repositories;
using HRSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRSystem.Persistence.Repositories
{
    public class JobPositionRepository : IJobPositionRepository
    {
        private readonly AppDbContext _context;

        public JobPositionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobPosition>> GetAllJobPositionsAsync()
        {
            return await _context.JobPositions.ToListAsync();
        }

        public async Task<JobPosition> GetJobPositionByIdAsync(int id)
        {
            return await _context.JobPositions.FindAsync(id);
        }

        public async Task AddJobPositionAsync(JobPosition jobPosition)
        {
            await _context.JobPositions.AddAsync(jobPosition);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateJobPositionAsync(JobPosition jobPosition)
        {
            _context.JobPositions.Update(jobPosition);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobPositionAsync(int id)
        {
            var jobPosition = await _context.JobPositions.FindAsync(id);
            if (jobPosition != null)
            {
                _context.JobPositions.Remove(jobPosition);
                await _context.SaveChangesAsync();
            }
        }
    }
}
