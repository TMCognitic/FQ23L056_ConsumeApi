using FQ23L056_ConsumeApi.Bll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQ23L056_ConsumeApi.Bll.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<UserTask> Get();
        UserTask? Get(int id);
        bool Insert(UserTask entity);
        bool Update(int id, UserTask entity);
        bool Delete(int id);
    }
}
