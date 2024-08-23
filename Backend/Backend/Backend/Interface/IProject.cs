using Backend.Models;

namespace Backend.Interface
{
    public interface IProjectRepository
    {
        ICollection<Project> GetProjects();
    }
}
