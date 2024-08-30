using Backend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using POE.Core.Interface;
using POE.Core.Models;

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
                        NameOfInstitution = "Company A",
                        Description = "Internship",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now },
                new Resume { Year = 2024,
                        NameOfInstitution = "Company B",
                        Description = "Junior Developer",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now, }
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
