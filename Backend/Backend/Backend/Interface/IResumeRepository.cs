using Backend.Models;

namespace Backend.Interface
{
    public interface IResumeRepository
    {
        ICollection<Resume> GetResume();
    }
}
