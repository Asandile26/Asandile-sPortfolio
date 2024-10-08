﻿using Backend.Interface;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : Controller
    {
        private readonly ITestimonialsRepository _testimonialsRepository;
        public TestimonialsController(ITestimonialsRepository testimonialsRepository)
        {
            this._testimonialsRepository = testimonialsRepository;
        }

        [HttpGet("GetTestimonials")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Testimonials>))]
        public IActionResult GetTestimonials()
        {
            var testimonial = _testimonialsRepository.GetTestimonials();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(testimonial);
        }
    }
}
