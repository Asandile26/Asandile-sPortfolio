using Backend.Controllers;
using Backend.Interface;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Backend.Tests.Controllers
{
    public class ProjectControllerTests
    {
        private readonly Mock<IProjectRepository> _mockProjectRepository;
        private readonly ProjectController _controller;

        public ProjectControllerTests()
        {
            _mockProjectRepository = new Mock<IProjectRepository>();
            _controller = new ProjectController(_mockProjectRepository.Object);
        }

        [Fact]
        public void GetProjects_ReturnsOkResult_WithListOfProjects()
        {
            // Arrange
            var projects = new List<Project>
            {
                new Project {
                     Name = "Vue-Portfolio",
                     GitHub = "https://github.com/Asandile26/Vue-Portfolio.git",
                     Netlify = "https://portfolio-asandilelangeni.netlify.app",
                     Image = "https://i.postimg.cc/SQwnPRYP/Vue-portfolio.png",
                    },
                new Project {  Name = "Calculator",
                     GitHub = "https://github.com/Asandile26/calculator.git",
                     Netlify = "https://asandilelangenicalculator.netlify.app",
                     Image = "https://i.postimg.cc/9QyFKBHR/Calculator.png", }
            };

            _mockProjectRepository.Setup(repo => repo.GetProjects()).Returns(projects);

            // Act
            var result = _controller.GetProjects();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Project>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public void GetProjects_ReturnsBadRequest_WhenModelStateIsInvalid()
        {
            // Arrange
            _controller.ModelState.AddModelError("Error", "Model error");

            // Act
            var result = _controller.GetProjects();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<SerializableError>(badRequestResult.Value);
        }
    }
}
