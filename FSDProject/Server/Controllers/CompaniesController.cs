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
    [Route("api/companys")]
    [ApiController]
    public class CompanysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Companys
        [HttpGet]
        public async Task<IActionResult> GetCompanys()
        {
            var companys = await _unitOfWork.Companys.GetAll();
            return Ok(companys);
        }

        // GET: api/Companys/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Company>> GetCompany(int id)
        public async Task<IActionResult> GetCompany(int id)
        {
            var company = await _unitOfWork.Companys.Get(q => q.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/Companys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if (id != company.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Companys.Update(company);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CompanyExists(id))
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

        // POST: api/Companys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            //_context.Companys.Add(company);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Companys.Insert(company);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany", new { id = company.Id }, company);
        }

        // DELETE: api/Companys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _unitOfWork.Companys.Get(q => q.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            await _unitOfWork.Companys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CompanyExists(int id)
        private async Task<bool> CompanyExists(int id)
        {
            //return (_context.Companys?.Any(e => e.Id == id)).GetValueOrDefault();
            var company = await _unitOfWork.Companys.Get(q => q.Id == id);
            return company != null;
        }
    }
}
