using Backend.Controllers;
using Backend.Interface;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Backend.Tests.Controllers
{
    public class ResumeControllerTests
    {
        private readonly Mock<IResumeRepository> _mockResumeRepository;
        private readonly ResumeController _controller;

        public ResumeControllerTests()
        {
            _mockResumeRepository = new Mock<IResumeRepository>();
            _controller = new ResumeController(_mockResumeRepository.Object);
        }

        [Fact]
        public void GetResume_ReturnsOkResult_WithListOfResumes()
        {
            // Arrange
            var resumes = new List<Resume>
            {
                new Resume {Year = 2023,
                        NameOfInstitution = "Payment24",
                        Description = "Internship (Software developer)",
                        StartDate = new DateTime(2023, 06, 1),
                        EndDate = new DateTime(2023, 08, 31) },
                new Resume { Year = 2024,
                        NameOfInstitution = "1Nebula",
                        Description = "Internship (Software developer)",
                        StartDate = new DateTime(2024, 01, 09),
                        EndDate = new DateTime(2024, 08, 30), }
            };

            _mockResumeRepository.Setup(repo => repo.GetResume()).Returns(resumes);

            // Act
            var result = _controller.GetResume();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Resume>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public void GetResume_ReturnsBadRequest_WhenModelStateIsInvalid()
        {
            // Arrange
            _controller.ModelState.AddModelError("Error", "Model error");

            // Act
            var result = _controller.GetResume();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }
}
