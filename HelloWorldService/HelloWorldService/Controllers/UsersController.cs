using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HelloWorldService.Models;

namespace HelloWorldService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static int currentId = 1;
        public static List<User> users = new List<User>();

        // GET: api/Contacts
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/Contacts/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            var contact = users.FirstOrDefault(t => t.UserId == id);
            return contact;
        }

        // POST: api/Contacts
        [HttpPost]
        public IActionResult Post([FromBody] User value)
        {
            if (value == null)
            {
                return new BadRequestResult();
            }

            if (value.UserEmail == null)
            {
                return BadRequest(new ErrorResponse { Message= "Name field is null", DBCode = 120 });
            }
            value.UserId = currentId++;
            value.DateAdded = DateTime.Now;
            users.Add(value);

            return CreatedAtAction(nameof(Get), new { id = value.UserId } );
        }

        // PUT: api/Contacts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            var user = users.FirstOrDefault(t => t.UserId == id);

            user.UserEmail = value.UserEmail;

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contactsDeleted = users.RemoveAll(t => t.UserId == id);

            if (contactsDeleted == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }
    }
}