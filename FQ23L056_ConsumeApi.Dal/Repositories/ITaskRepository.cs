using FQ23L056_ConsumeApi.Dal.Entities;

namespace FQ23L056_ConsumeApi.Dal.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<UserTask> Get();
        UserTask? Get(int id);
        bool Insert(UserTask task);
        bool Update(UserTask task);
        bool Delete(int id);
    }
}
