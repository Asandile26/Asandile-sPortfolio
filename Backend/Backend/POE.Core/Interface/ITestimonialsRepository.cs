using POE.Core.Models;

namespace POE.Core.Interface
{
    public interface ITestimonialsRepository
    {
        ICollection<Testimonials> GetTestimonials();
    }
}
