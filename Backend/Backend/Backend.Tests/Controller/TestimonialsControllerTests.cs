using Backend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using POE.Core.Interface;
using POE.Core.Models;

namespace Backend.Tests.Controllers
{
    public class TestimonialsControllerTests
    {
        private readonly Mock<ITestimonialsRepository> _mockTestimonialsRepository;
        private readonly TestimonialsController _controller;

        public TestimonialsControllerTests()
        {
            _mockTestimonialsRepository = new Mock<ITestimonialsRepository>();
            _controller = new TestimonialsController(_mockTestimonialsRepository.Object);
        }

        [Fact]
        public void GetTestimonials_ReturnsOkResult_WithListOfTestimonials()
        {
            // Arrange
            var testimonials = new List<Testimonials>
            {
                new Testimonials {  Name = "Name of the person",
                        Testimonial = "Their testimonial about mw",
                        Image = "link to their image" },
                new Testimonials {  Name = "Name of the person",
                        Testimonial = "Their testimonial about mw",
                        Image = "link to their image" },
            };

            _mockTestimonialsRepository.Setup(repo => repo.GetTestimonials()).Returns(testimonials);

            // Act
            var result = _controller.GetTestimonials();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Testimonials>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public void GetTestimonials_ReturnsBadRequest_WhenModelStateIsInvalid()
        {
            // Arrange
            _controller.ModelState.AddModelError("Error", "Model error");

            // Act
            var result = _controller.GetTestimonials();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }
}
