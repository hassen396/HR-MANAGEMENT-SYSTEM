using HRSystem.Domain.Entities;

namespace HRSystem.Application.Interfaces
{
    public interface IJobPositionService
    {
        Task<IEnumerable<JobPosition>> GetAllJobPositionsAsync();
        Task<JobPosition> GetJobPositionByIdAsync(int id);
        Task AddJobPositionAsync(JobPosition jobPosition);
        Task UpdateJobPositionAsync(JobPosition jobPosition);
        Task DeleteJobPositionAsync(int id);
    }
}
