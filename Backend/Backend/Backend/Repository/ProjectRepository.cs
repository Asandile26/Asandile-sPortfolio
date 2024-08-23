using Backend.Data;
using Backend.Interface;
using Backend.Models;

namespace Backend.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private DataContext _context;
        public ProjectRepository(DataContext context)
        {
            _context = context;

        }

        ICollection<Project> IProjectRepository.GetProjects()
        {
            return _context.Projects.OrderBy(p => p.Id).ToList();
        }
    }
}
