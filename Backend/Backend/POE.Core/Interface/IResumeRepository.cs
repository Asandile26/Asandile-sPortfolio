using POE.Core.Models;

namespace POE.Core.Interface
{
    public interface IResumeRepository
    {
        ICollection<Resume> GetResume();
    }
}
