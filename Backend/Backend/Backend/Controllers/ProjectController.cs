using Microsoft.AspNetCore.Mvc;
using POE.Core.Interface;
using POE.Core.Models;

namespace Backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectController(IProjectRepository projectRepository)
        {
            this._projectRepository = projectRepository;
        }

        [HttpGet("GetProjects")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Testimonials>))]
        public IActionResult GetProjects()
        {
            var project = _projectRepository.GetProjects();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(project);
        }
    }
}
