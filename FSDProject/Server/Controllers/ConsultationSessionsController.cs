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
    public class ConsultationSessionsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ConsultationSessionsController(ApplicationDbContextcontext)
        public ConsultationSessionsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/ConsultationSessions
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<ConsultationSession>>>GetConsultationSessions()
        public async Task<IActionResult> GetConsultationSessions()
        {
            //Refactored
            //return await _context.ConsultationSessions.ToListAsync();
            var consultationSessions = await _unitOfWork.ConsultationSessions.GetAll(includes: q => q.Include(x => x.Consultant).Include(x => x.JobSeeker));
            return Ok(consultationSessions);
        }

        // GET: api/ConsultationSessions/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<ConsultationSession>>GetConsultationSession(int id)
        public async Task<IActionResult> GetConsultationSession(int id)
        {
            //Refactored
            //var consultationSession = await _context.ConsultationSessions.FindAsync(id);
            var ConsultationSessions = await _unitOfWork.ConsultationSessions.Get(q => q.Id == id);

            if (ConsultationSessions == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(ConsultationSessions);
        }

        // PUT: api/ConsultationSessions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultationSession(int id, ConsultationSession consultationSession)
        {
            if (id != consultationSession.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(consultationSession).State = EntityState.Modified;
            _unitOfWork.ConsultationSessions.Update(consultationSession);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ConsultationSessionExists(id))
                if (!await ConsultationSessionExists(id))
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

        // POST: api/ConsultationSessions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsultationSession>> PostConsultationSession(ConsultationSession consultationSession)
        {
            //Refactored
            //if (_context.ConsultationSessions == null)
            if (_unitOfWork.ConsultationSessions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ConsultationSessions'  is null.");
            }
            //_context.ConsultationSessions.Add(consultationSession);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ConsultationSessions.Insert(consultationSession);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultationSession", new { id = consultationSession.Id }, consultationSession);
        }

        // DELETE: api/ConsultationSessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultationSession(int id)
        {
            //Refactored
            //if (_context.ConsultationSessions == null)
            if (_unitOfWork.ConsultationSessions == null)
            {
                return NotFound();
            }

            //Refactored
            //var consultationSession = await _context.ConsultationSessions.FindAsync(id);
            var consultationSession = await _unitOfWork.ConsultationSessions.Get(q => q.Id == id);
            if (consultationSession == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.ConsultationSessions.Remove(consultationSession);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ConsultationSessions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ConsultationSessionExists(int id)
        private async Task<bool> ConsultationSessionExists(int id)
        {
            //Refactored
            //return _context.ConsultationSessions.Any(e => e.Id == id);
            var consultationSession = await _unitOfWork.ConsultationSessions.Get(q => q.Id == id);
            return consultationSession != null;
        }
    }
}