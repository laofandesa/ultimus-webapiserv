using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC_CoreApi.Model;
using TCC_CoreApi.Common.Tool;
using TCC_CoreApi.Model.entity;
using Microsoft.EntityFrameworkCore;

namespace TCC_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataOperController : ControllerBase
    {
        private readonly ApiDBContent _dbContext;
        public DataOperController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<DataOperController>
        [HttpGet]
        public IEnumerable<UserInfo> GetAll ()
        {
            return _dbContext.Users.ToList();
        }
        
        [HttpGet("{id}")]
        public async Task<UserInfo> Get(int id)
        {
            var item = await _dbContext.Users.FirstOrDefaultAsync(t => t.Id == id);
            return item;
            //return JsonSerializationExtension.ToJson(_dbContext.Users.Take(2).ToList());
        }

        // POST api/<DataOperController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserInfo item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            else
            {
                _dbContext.Users.Add(item);
                await _dbContext.SaveChangesAsync();
                return Ok(item);
            }
        }

        // PUT api/<DataOperController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Updadte(int id, [FromBody] UserInfo item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            else
            {
                var todo = _dbContext.Users.SingleOrDefault(t => t.Id == id);
                if (todo == null)
                {
                    return NotFound();
                }
                else
                {
                    todo.Phone = item.Phone;
                    todo.UserName = item.UserName;

                    _dbContext.Users.Update(todo);
                    await _dbContext.SaveChangesAsync();

                    return Ok(todo);
                }
            }
        }

        // DELETE api/<DataOperController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var todo = _dbContext.Users.SingleOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            else
            {
                _dbContext.Users.Remove(todo);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
        }
    }
}
