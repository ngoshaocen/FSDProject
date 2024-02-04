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
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public JobSeekersController(ApplicationDbContextcontext)
        public JobSeekersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/JobSeekers
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<JobSeeker>>>GetJobSeekers()
        public async Task<IActionResult> GetJobSeekers()
        {
            //Refactored
            //return await _context.JobSeekers.ToListAsync();
            var jobSeekers = await _unitOfWork.JobSeekers.GetAll();
            return Ok(jobSeekers);
        }

        // GET: api/JobSeekers/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<JobSeeker>>GetJobSeeker(int id)
        public async Task<IActionResult> GetJobSeeker(int id)
        {
            //Refactored
            //var jobSeeker = await _context.JobSeekers.FindAsync(id);
            var JobSeekers = await _unitOfWork.JobSeekers.Get(q => q.Id == id);

            if (JobSeekers == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(JobSeekers);
        }

        // PUT: api/JobSeekers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobSeeker(int id, JobSeeker jobSeeker)
        {
            if (id != jobSeeker.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(jobSeeker).State = EntityState.Modified;
            _unitOfWork.JobSeekers.Update(jobSeeker);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!JobSeekerExists(id))
                if (!await JobSeekerExists(id))
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

        // POST: api/JobSeekers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobSeeker>> PostJobSeeker(JobSeeker jobSeeker)
        {
            //Refactored
            //if (_context.JobSeekers == null)
            if (_unitOfWork.JobSeekers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.JobSeekers'  is null.");
            }
            //_context.JobSeekers.Add(jobSeeker);
            //await _context.SaveChangesAsync();
            await _unitOfWork.JobSeekers.Insert(jobSeeker);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJobSeeker", new { id = jobSeeker.Id }, jobSeeker);
        }

        // DELETE: api/JobSeekers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobSeeker(int id)
        {
            //Refactored
            //if (_context.JobSeekers == null)
            if (_unitOfWork.JobSeekers == null)
            {
                return NotFound();
            }

            //Refactored
            //var jobSeeker = await _context.JobSeekers.FindAsync(id);
            var jobSeeker = await _unitOfWork.JobSeekers.Get(q => q.Id == id);
            if (jobSeeker == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.JobSeekers.Remove(jobSeeker);
            //await _context.SaveChangesAsync();
            await _unitOfWork.JobSeekers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool JobSeekerExists(int id)
        private async Task<bool> JobSeekerExists(int id)
        {
            //Refactored
            //return _context.JobSeekers.Any(e => e.Id == id);
            var jobSeeker = await _unitOfWork.JobSeekers.Get(q => q.Id == id);
            return jobSeeker != null;
        }
    }
}