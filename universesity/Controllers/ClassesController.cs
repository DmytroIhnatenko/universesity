using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using universesity.Models;
using universesity.Repositories;
namespace universesity.Controllers
{
    public class ClassesController : Controller
    {
        // GET: ClassesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClassesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //ADmin

        private readonly ClassScheduleDBContext _dbContext;
        public ClassesController(ClassScheduleDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var classes = _dbContext.Classes.Include(c => c.Room).Include(c => c.Subject).Include(c => c.StudentGroup).ToList();
            return View(classes);
        }

        public IActionResult Create()
        {
            ViewBag.Rooms = new SelectList(_dbContext.Rooms, "RoomId", "RoomName");
            ViewBag.Subjects = new SelectList(_dbContext.Subjects, "SubjectId", "SubjectName");
            ViewBag.StudentGroups = new SelectList(_dbContext.StudentGroups, "StudentGroupId", "GroupName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Class newClass)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Classes.Add(newClass);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Rooms = new SelectList(_dbContext.Rooms, "RoomId", "RoomName", newClass.RoomId);
            ViewBag.Subjects = new SelectList(_dbContext.Subjects, "SubjectId", "SubjectName", newClass.SubjectId);
            ViewBag.StudentGroups = new SelectList(_dbContext.StudentGroups, "StudentGroupId", "GroupName", newClass.StudentGroupId);

            return View(newClass);
        }

        public IActionResult Edit(int id)
        {
            var classToEdit = _dbContext.Classes.Find(id);

            if (classToEdit == null)
            {
                return NotFound();
            }

            ViewBag.Rooms = new SelectList(_dbContext.Rooms, "RoomId", "RoomName", classToEdit.RoomId);
            ViewBag.Subjects = new SelectList(_dbContext.Subjects, "SubjectId", "SubjectName", classToEdit.SubjectId);
            ViewBag.StudentGroups = new SelectList(_dbContext.StudentGroups, "StudentGroupId", "GroupName", classToEdit.StudentGroupId);

            return View(classToEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Class editedClass)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(editedClass).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Rooms = new SelectList(_dbContext.Rooms, "RoomId", "RoomName", editedClass.RoomId);
            ViewBag.Subjects = new SelectList(_dbContext.Subjects, "SubjectId", "SubjectName", editedClass.SubjectId);
            ViewBag.StudentGroups = new SelectList(_dbContext.StudentGroups, "StudentGroupId", "GroupName", editedClass.StudentGroupId);

            return View(editedClass);
        }

        public IActionResult Delete(int id)
        {
            var classToDelete = _dbContext.Classes.Find(id);

            if (classToDelete == null)
            {
                return NotFound();
            }

            return View(classToDelete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var classToDelete = _dbContext.Classes.Find(id);

            if (classToDelete != null)
            {
                _dbContext.Classes.Remove(classToDelete);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
