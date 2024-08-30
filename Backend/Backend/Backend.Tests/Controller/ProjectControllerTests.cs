using Backend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using POE.Core.Interface;
using POE.Core.Models;

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
                     Name = "Name of a project",
                     GitHub = "git hub link",
                     Netlify = "netlify link",
                     Image = "link to image",
                    },
                new Project {  Name = "Name of a project",
                     GitHub = "git hub link",
                     Netlify = "netlify linkk",
                     Image = "link to image", }
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
