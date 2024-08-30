using POE.Core.Interface;
using POE.Core.Models;
using POE.DataAccess.Data;

namespace POE.DataAccess.Repository
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
