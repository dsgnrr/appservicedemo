using appservicedemo.Data;
using appservicedemo.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appservicedemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IActionResult> Get()
        {
            var users = await _dataContext.Users.ToListAsync();
            return Ok(users);
        }
    }
}
