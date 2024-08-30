using Microsoft.EntityFrameworkCore;
using POE.Core.Models;
using POE.DataAccess.Data;
using POE.DataAccess.Repository;

namespace Backend.Tests.Repository
{
    public class ProjectRepositoryTests
    {
        private readonly ProjectRepository _projectRepository;
        private readonly DataContext _context;

        public ProjectRepositoryTests()
        {
            // Set up in-memory database
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
               ;

            _context = new DataContext(options.Options);
            _context.Database.EnsureCreated();
            _projectRepository = new ProjectRepository(_context);

            // Seed data
            SeedData();
        }

        private void SeedData()
        {
            _context.Projects.AddRange(
                new Project
                {
                    Name = "Name of a project A",
                    GitHub = "git hub link",
                    Netlify = "netlify link",
                    Image = "link to image",
                },
                new Project
                {
                    Name = "Name of a project B",
                    GitHub = "git hub link",
                    Netlify = "netlify link",
                    Image = "link to image"
                }
            );
            _context.SaveChanges();
        }

        [Fact]
        public void GetProjects_ReturnsAllProjects()
        {
            // Act
            var result = _projectRepository.GetProjects();

            // Assert

            Assert.Equal("Name of a project A", result.First().Name);
            Assert.Equal("Name of a project B", result.Last().Name);
        }

        private class projectRepository
        {
            private DataContext context;

            public projectRepository(DataContext context)
            {
                this.context = context;
            }
        }
    }
}
