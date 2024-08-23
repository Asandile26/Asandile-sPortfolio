using Backend.Data;
using Backend.Interface;
using Backend.Models;

namespace Backend.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private DataContext _context;
        public ResumeRepository(DataContext context)
        {
            _context = context;

        }

        ICollection<Resume> IResumeRepository.GetResume()
        {
            return _context.Resume.OrderBy(s => s.Id).ToList();
        }
    }
}
