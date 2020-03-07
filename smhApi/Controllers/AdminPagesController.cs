using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using smhApi.Models;

namespace smhApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminPagesController : ControllerBase
    {
        private readonly x2centerContext _context;

        public AdminPagesController(x2centerContext context)
        {
            _context = context;
        }

        // GET: api/AdminPages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminPages>>> GetAdminPages()
        {
            return await _context.AdminPages.ToListAsync();
        }

        // GET: api/AdminPages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminPages>> GetAdminPages(int id)
        {
            var adminPages = await _context.AdminPages.FindAsync(id);

            if (adminPages == null)
            {
                return NotFound();
            }

            return adminPages;
        }

        // PUT: api/AdminPages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminPages(int id, AdminPages adminPages)
        {
            if (id != adminPages.PageId)
            {
                return BadRequest();
            }

            _context.Entry(adminPages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminPagesExists(id))
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

        // POST: api/AdminPages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AdminPages>> PostAdminPages(AdminPages adminPages)
        {
            _context.AdminPages.Add(adminPages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminPages", new { id = adminPages.PageId }, adminPages);
        }

        // DELETE: api/AdminPages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdminPages>> DeleteAdminPages(int id)
        {
            var adminPages = await _context.AdminPages.FindAsync(id);
            if (adminPages == null)
            {
                return NotFound();
            }

            _context.AdminPages.Remove(adminPages);
            await _context.SaveChangesAsync();

            return adminPages;
        }

        private bool AdminPagesExists(int id)
        {
            return _context.AdminPages.Any(e => e.PageId == id);
        }
    }
}
