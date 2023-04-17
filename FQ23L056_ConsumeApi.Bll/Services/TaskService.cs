using FQ23L056_ConsumeApi.Bll.Entities;
using FQ23L056_ConsumeApi.Bll.Mappers;
using FQ23L056_ConsumeApi.Bll.Repositories;
using IDalTaskRepository = FQ23L056_ConsumeApi.Dal.Repositories.ITaskRepository;

namespace FQ23L056_ConsumeApi.Bll.Services
{
    public class TaskService : ITaskRepository
    {
        private readonly IDalTaskRepository _taskRepository;

        public TaskService(IDalTaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<UserTask> Get()
        {
            return _taskRepository.Get().Select(t => t.ToBll());
        }

        public UserTask? Get(int id)
        {
            return _taskRepository.Get(id)?.ToBll();
        }

        public bool Insert(UserTask entity)
        {
            return _taskRepository.Insert(entity.ToDal());
        }

        public bool Update(int id, UserTask entity)
        {
            entity.Id = id;
            return _taskRepository.Update(entity.ToDal());
        }
        public bool Delete(int id)
        {
            return _taskRepository.Delete(id);
        }
    }
}
