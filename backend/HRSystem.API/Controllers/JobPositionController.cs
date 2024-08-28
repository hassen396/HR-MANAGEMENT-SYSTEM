using HRSystem.Application.Interfaces;
using HRSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HRSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobPositionController : ControllerBase
    {
        private readonly IJobPositionService _jobPositionService;

        public JobPositionController(IJobPositionService jobPositionService)
        {
            _jobPositionService = jobPositionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobPosition>>> GetJobPositions()
        {
            return Ok(await _jobPositionService.GetAllJobPositionsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JobPosition>> GetJobPosition(int id)
        {
            var jobPosition = await _jobPositionService.GetJobPositionByIdAsync(id);

            if (jobPosition == null)
            {
                return NotFound();
            }

            return Ok(jobPosition);
        }

        [HttpPost]
        public async Task<ActionResult<JobPosition>> PostJobPosition(JobPosition jobPosition)
        {
            await _jobPositionService.AddJobPositionAsync(jobPosition);
            return CreatedAtAction(nameof(GetJobPosition), new { id = jobPosition.Id }, jobPosition);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobPosition(int id, JobPosition jobPosition)
        {
            if (id != jobPosition.Id)
            {
                return BadRequest();
            }

            await _jobPositionService.UpdateJobPositionAsync(jobPosition);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobPosition(int id)
        {
            await _jobPositionService.DeleteJobPositionAsync(id);
            return NoContent();
        }
    }
}
