using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestUserCRUD.Model;


namespace TestUserCRUD.Controllers
{
    [Produces("application/json")]
    [Route("api/TestUsers")]
    public class TestUsersController : Controller
    {
        private readonly TestUserContext _context;

        public TestUsersController(TestUserContext context)
        {
            _context = context;
        }

        // GET: api/TestUsers
        [HttpGet]
        public IEnumerable<TestUser> GetTestUsers()
        {
            return _context.TestUsers;
        }

        // GET: api/TestUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var testUser = await _context.TestUsers.SingleOrDefaultAsync(m => m.Id == id);

            if (testUser == null)
            {
                return NotFound();
            }

            return Ok(testUser);
        }

        // PUT: api/TestUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestUser([FromRoute] int id, [FromBody] TestUser testUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != testUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(testUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestUserExists(id))
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

        // POST: api/TestUsers
        [HttpPost]
        public async Task<IActionResult> PostTestUser([FromBody] TestUser testUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TestUsers.Add(testUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestUser", new { id = testUser.Id }, testUser);
        }

        // DELETE: api/TestUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var testUser = await _context.TestUsers.SingleOrDefaultAsync(m => m.Id == id);
            if (testUser == null)
            {
                return NotFound();
            }

            _context.TestUsers.Remove(testUser);
            await _context.SaveChangesAsync();

            return Ok(testUser);
        }

        private bool TestUserExists(int id)
        {
            return _context.TestUsers.Any(e => e.Id == id);
        }
    }
}