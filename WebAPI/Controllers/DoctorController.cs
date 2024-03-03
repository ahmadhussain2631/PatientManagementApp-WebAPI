using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Doctor doctor)
        {
            return Ok("");
        }
    }
}
