using Backend.Controllers;
using Backend.Interface;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

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
                new Testimonials {  Name = "Athenkosi Freddie",
                        Testimonial = "Asandile is a super nice person who is open & wise. He is always open to helping others and He is not afraid to express himself. He is a visionary and futurist, He is always open to learning about the people around annd also an amzing conversationalist. I am glad to know him as a person",
                        Image = "https://i.postimg.cc/MGkfjTqR/Athii.png" },
                new Testimonials { Name = "Umayr Nordien",
                        Testimonial = "I know I can count on Asandile to work with me on both large and small projects. He is loyal to his ethical conduct and, based on my professional experience, does not deviate from these values. He is easy-going, and caring, with a strong mentality and always ready to help others",
                        Image = "https://i.postimg.cc/k5MgYkXG/Umayr.jpg" }
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
