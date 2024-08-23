using Backend.Models;

namespace Backend.Interface
{
    public interface ITestimonialsRepository
    {
        ICollection<Testimonials> GetTestimonials();
    }
}
