using Microsoft.EntityFrameworkCore;
using POE.Core.Models;
using POE.DataAccess.Data;
using POE.DataAccess.Repository;

namespace POE.Tests.Repository
{
    public class TestimonialsRepositoryTests
    {
        private readonly TestimonialsRepository _testimonialsRepository;
        private readonly DataContext _context;

        public TestimonialsRepositoryTests()
        {
            // Set up in-memory database
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                ;

            _context = new DataContext(options.Options);
            _context.Database.EnsureCreated();
            _testimonialsRepository = new TestimonialsRepository(_context);

            // Seed data
            SeedData();
        }

        private void SeedData()
        {
            _context.Testimonials.AddRange(
                new Testimonials
                {

                    Name = "Name of the person",
                    Testimonial = "Testimonials",
                    Image = "image of the person"

                },
                new Testimonials
                {
                    Name = "Name of the person",
                    Testimonial = "Testimonials",
                    Image = "image of the person"
                }
            );
            _context.SaveChanges();
        }

        [Fact]
        public void GetTestimonials_ReturnsAllTestimonials()
        {
            // Act
            var result = _testimonialsRepository.GetTestimonials();

            // Assert

            Assert.Equal("Name of the person", result.First().Name);
            Assert.Equal("Name of the person", result.Last().Name);
        }
    }
}
