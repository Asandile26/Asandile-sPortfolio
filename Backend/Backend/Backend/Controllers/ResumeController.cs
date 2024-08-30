using Microsoft.AspNetCore.Mvc;
using POE.Core.Interface;
using POE.Core.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : Controller
    {
        private IResumeRepository _resumeRepository;

        public ResumeController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        [HttpGet("GetResume")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Resume>))]

        public IActionResult GetResume()
        {
            var education = _resumeRepository.GetResume();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(education);
        }

    }
}
