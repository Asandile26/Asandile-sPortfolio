using POE.Core.Interface;
using POE.Core.Models;
using POE.DataAccess.Data;

namespace POE.DataAccess.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataContext _context;

        public ProjectRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Project> GetProjects()
        {
            return _context.Projects.OrderBy(p => p.Id).ToList();
        }
    }
}
