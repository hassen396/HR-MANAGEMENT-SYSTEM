using HRSystem.Domain.Entities;

namespace HRSystem.Domain.Repositories
{
    public interface IJobPositionRepository
    {
        Task<IEnumerable<JobPosition>> GetAllJobPositionsAsync();
        Task<JobPosition> GetJobPositionByIdAsync(int id);
        Task AddJobPositionAsync(JobPosition jobPosition);
        Task UpdateJobPositionAsync(JobPosition jobPosition);
        Task DeleteJobPositionAsync(int id);
    }
}
