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
    public class CSRequestsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public CSRequestsController(ApplicationDbContextcontext)
        public CSRequestsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/CSRequests
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<CSRequest>>>GetCSRequests()
        public async Task<IActionResult> GetCSRequests()
        {
            //Refactored
            //return await _context.CSRequests.ToListAsync();
            var csRequests = await _unitOfWork.CSRequests.GetAll(includes: q => q.Include(x => x.Consultant).Include(x => x.JobSeeker));
            return Ok(csRequests);
        }

        // GET: api/CSRequests/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<CSRequest>>GetCSRequest(int id)
        public async Task<IActionResult> GetCSRequest(int id)
        {
            //Refactored
            //var csRequest = await _context.CSRequests.FindAsync(id);
            var CSRequests = await _unitOfWork.CSRequests.Get(q => q.Id == id);

            if (CSRequests == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(CSRequests);
        }

        // PUT: api/CSRequests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCSRequest(int id, CSRequest csRequest)
        {
            if (id != csRequest.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(csRequest).State = EntityState.Modified;
            _unitOfWork.CSRequests.Update(csRequest);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!CSRequestExists(id))
                if (!await CSRequestExists(id))
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

        // POST: api/CSRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CSRequest>> PostCSRequest(CSRequest csRequest)
        {
            //Refactored
            //if (_context.CSRequests == null)
            if (_unitOfWork.CSRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CSRequests'  is null.");
            }
            //_context.CSRequests.Add(csRequest);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CSRequests.Insert(csRequest);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCSRequest", new { id = csRequest.Id }, csRequest);
        }

        // DELETE: api/CSRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCSRequest(int id)
        {
            //Refactored
            //if (_context.CSRequests == null)
            if (_unitOfWork.CSRequests == null)
            {
                return NotFound();
            }

            //Refactored
            //var csRequest = await _context.CSRequests.FindAsync(id);
            var csRequest = await _unitOfWork.CSRequests.Get(q => q.Id == id);
            if (csRequest == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.CSRequests.Remove(csRequest);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CSRequests.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool CSRequestExists(int id)
        private async Task<bool> CSRequestExists(int id)
        {
            //Refactored
            //return _context.CSRequests.Any(e => e.Id == id);
            var csRequest = await _unitOfWork.CSRequests.Get(q => q.Id == id);
            return csRequest != null;
        }
    }
}