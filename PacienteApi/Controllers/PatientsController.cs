using Microsoft.AspNetCore.Mvc;
using PatientApi.Models;
using PatientApi.Services;

namespace PatientApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;

        public PatientsController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        // POST /api/patients
        [HttpPost]
        public IActionResult RegisterPatient([FromBody] Patient patient)
        {
            patient.Id = Guid.NewGuid();
            _patientRepository.AddPatient(patient);
            return CreatedAtAction(nameof(GetPatients), new { id = patient.Id }, patient);
        }

        // GET /api/patients
        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            return Ok(_patientRepository.GetAllPatients());
        }
    }
}