using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FSDProject.Server.Data;
using FSDProject.Shared.Domain;
using FSDProject.Server.IRepository;

namespace FSDProject.Server.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Jobs
        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await _unitOfWork.Jobs.GetAll();
            return Ok(jobs);
        }

        // GET: api/Jobs/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Job>> GetJob(int id)
        public async Task<IActionResult> GetJob(int id)
        {
            var job = await _unitOfWork.Jobs.Get(q => q.Id == id);

            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        // PUT: api/Jobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob(int id, Job job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Jobs.Update(job);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Jobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Job>> PostJob(Job job)
        {
            //_context.Jobs.Add(job);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Jobs.Insert(job);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var job = await _unitOfWork.Jobs.Get(q => q.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            await _unitOfWork.Jobs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool JobExists(int id)
        private async Task<bool> JobExists(int id)
        {
            //return (_context.Jobs?.Any(e => e.Id == id)).GetValueOrDefault();
            var job = await _unitOfWork.Jobs.Get(q => q.Id == id);
            return job != null;
        }
    }
}
