using HRSystem.Application.Interfaces;
using HRSystem.Domain.Entities;
using HRSystem.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRSystem.Application.Services
{
    public class JobPositionService : IJobPositionService
    {
        private readonly IJobPositionRepository _jobPositionRepository;

        public JobPositionService(IJobPositionRepository jobPositionRepository)
        {
            _jobPositionRepository = jobPositionRepository;
        }

        public async Task<IEnumerable<JobPosition>> GetAllJobPositionsAsync()
        {
            return await _jobPositionRepository.GetAllJobPositionsAsync();
        }

        public async Task<JobPosition> GetJobPositionByIdAsync(int id)
        {
            return await _jobPositionRepository.GetJobPositionByIdAsync(id);
        }

        public async Task AddJobPositionAsync(JobPosition jobPosition)
        {
            await _jobPositionRepository.AddJobPositionAsync(jobPosition);
        }

        public async Task UpdateJobPositionAsync(JobPosition jobPosition)
        {
            await _jobPositionRepository.UpdateJobPositionAsync(jobPosition);
        }

        public async Task DeleteJobPositionAsync(int id)
        {
            await _jobPositionRepository.DeleteJobPositionAsync(id);
        }
    }
}
