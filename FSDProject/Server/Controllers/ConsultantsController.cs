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
    public class ConsultantsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ConsultantsController(ApplicationDbContextcontext)
        public ConsultantsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Consultants
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Consultant>>>GetConsultants()
        public async Task<IActionResult> GetConsultants()
        {
            //Refactored
            //return await _context.Consultants.ToListAsync();
            var consultants = await _unitOfWork.Consultants.GetAll();
            return Ok(consultants);
        }

        // GET: api/Consultants/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Consultant>>GetConsultant(int id)
        public async Task<IActionResult> GetConsultant(int id)
        {
            //Refactored
            //var consultant = await _context.Consultants.FindAsync(id);
            var Consultants = await _unitOfWork.Consultants.Get(q => q.Id == id);

            if (Consultants == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(Consultants);
        }

        // PUT: api/Consultants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultant(int id, Consultant consultant)
        {
            if (id != consultant.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(consultant).State = EntityState.Modified;
            _unitOfWork.Consultants.Update(consultant);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ConsultantExists(id))
                if (!await ConsultantExists(id))
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

        // POST: api/Consultants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultant>> PostConsultant(Consultant consultant)
        {
            //Refactored
            //if (_context.Consultants == null)
            if (_unitOfWork.Consultants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Consultants'  is null.");
            }
            //_context.Consultants.Add(consultant);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultants.Insert(consultant);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultant", new { id = consultant.Id }, consultant);
        }

        // DELETE: api/Consultants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultant(int id)
        {
            //Refactored
            //if (_context.Consultants == null)
            if (_unitOfWork.Consultants == null)
            {
                return NotFound();
            }

            //Refactored
            //var consultant = await _context.Consultants.FindAsync(id);
            var consultant = await _unitOfWork.Consultants.Get(q => q.Id == id);
            if (consultant == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Consultants.Remove(consultant);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultants.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ConsultantExists(int id)
        private async Task<bool> ConsultantExists(int id)
        {
            //Refactored
            //return _context.Consultants.Any(e => e.Id == id);
            var consultant = await _unitOfWork.Consultants.Get(q => q.Id == id);
            return consultant != null;
        }
    }
}