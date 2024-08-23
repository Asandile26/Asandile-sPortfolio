using Backend.Data;
using Backend.Interface;
using Backend.Models;

namespace Backend.Repository
{
    public class TestimonialsRepository : ITestimonialsRepository
    {
        private readonly DataContext _context;
        public TestimonialsRepository(DataContext context)
        {

            _context = context;
        }

        public ICollection<Testimonials> GetTestimonials()
        {
            return _context.Testimonials.OrderBy(t => t.Id).ToList();
        }
    }
}
