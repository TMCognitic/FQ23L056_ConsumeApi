using FQ23L056_ConsumeApi.Models.Forms;
using System.Net;

namespace FQ23L056_ConsumeApi.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        // GET: TaskController
        public ActionResult Index()
        {            
            return View(_taskRepository.Get().ToList());
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return View(_taskRepository.Get(id)!);
            }
            catch (HttpRequestException ex)
            {
                if(ex.StatusCode == HttpStatusCode.NotFound)
                    return RedirectToAction("index");

                throw ex;
            }
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTaskForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            _taskRepository.Insert(new UserTask(form.Title));
            return RedirectToAction("index");
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                UserTask task = _taskRepository.Get(id)!;
                return View(new UpdateTaskForm() { Id = task.Id, Title = task.Title, Done = task.Done });
            }
            catch (HttpRequestException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                    return RedirectToAction("index");

                throw ex;
            }
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UpdateTaskForm form)
        {
            if(!ModelState.IsValid)
            {
                return View(form);
            }

            _taskRepository.Update(id, new UserTask(form.Title) { Done = form.Done });
            return RedirectToAction("index");
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return View(_taskRepository.Get(id)!);
            }
            catch (HttpRequestException ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                    return RedirectToAction("index");

                throw ex;
            }
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _taskRepository.Delete(id);
            return RedirectToAction("index");
        }
    }
}
