﻿using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Patient patient)
        {
            return Ok("");
        }
    }
}
