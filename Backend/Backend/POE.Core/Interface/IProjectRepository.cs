using POE.Core.Models;

namespace POE.Core.Interface
{
    public interface IProjectRepository
    {
        ICollection<Project> GetProjects();
    }
}
