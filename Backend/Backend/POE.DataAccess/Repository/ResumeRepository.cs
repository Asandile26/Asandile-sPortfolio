using POE.Core.Interface;
using POE.Core.Models;
using POE.DataAccess.Data;
namespace POE.DataAccess.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly DataContext _context;
        public ResumeRepository(DataContext context)
        {
            _context = context;

        }

        public ICollection<Resume> GetResume()
        {
            return _context.Resume.OrderBy(s => s.Id).ToList();
        }
    }
}
