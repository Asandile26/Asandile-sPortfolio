using Microsoft.EntityFrameworkCore;
using POE.Core.Models;
using POE.DataAccess.Data;
using POE.DataAccess.Repository;

namespace POE.Tests.Repository
{
    public class ResumeRepositoryTests
    {
        private readonly ResumeRepository _resumeRepository;
        private readonly DataContext _context;

        public ResumeRepositoryTests()
        {
            // Set up in-memory database
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                ;

            _context = new DataContext(options.Options);
            _context.Database.EnsureCreated();
            _resumeRepository = new ResumeRepository(_context);

            // Seed data
            SeedData();
        }

        private void SeedData()
        {
            _context.Resume.AddRange(
                new Resume
                {
                    NameOfInstitution = "Institution A",
                    Description = "Description A",
                    StartDate = new DateTime(2020, 1, 1),
                    EndDate = new DateTime(2021, 1, 1)
                },
                new Resume
                {
                    NameOfInstitution = "Institution B",
                    Description = "Description B",
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2022, 1, 1)
                }
            );
            _context.SaveChanges();
        }

        [Fact]
        public void GetResume_ReturnsAllResumes()
        {
            // Act
            var result = _resumeRepository.GetResume();

            // Assert

            Assert.Equal("Institution A", result.First().NameOfInstitution);
            Assert.Equal("Institution B", result.Last().NameOfInstitution);
        }
    }
}
