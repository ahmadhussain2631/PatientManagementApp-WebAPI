using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Patient patient)
        {
            return Ok(await _patientService.Add(patient));
        }

        [Route("{patientId:int}")]
        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] int patientId)
        {
            return Ok(await _patientService.Get(patientId));
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _patientService.GetAll());
        }

        [Route("Delete/{id:int}")]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _patientService.Delete(id);
            return Ok("Record deleted successfully");
        }
    }
}
