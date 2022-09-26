using LMS.Core.ViewModels;
using LMS.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext db;

        public UsersController (ApplicationDbContext context)
        {
            db = context;
        }
        public ActionResult Index(int? id, int? courseID)
        {
            var viewModel = new TeacherIndexDataModel();
            viewModel.Teachers = db.Users   //.Where(u => u.role == "teacher")

                .Include(t => t.Course)
                .Include(t => t.Documents.Select(m => m.User))
                .OrderBy(t => t.Email);


            if (id != null)
            {
                ViewBag.TeacherId = id.Value;
                viewModel.Documents = viewModel.Teachers
                    .Where(t => t.Id == id.Value).Single().Documents;
                   
            }

            if (courseID != null)
            {
                ViewBag.CourseID = courseID.Value;
                viewModel.Teachers = viewModel.Courses.Where(
                    c => c.CourseID == courseID).Single().Documents;
            }

            return View(viewModel);
        }
    }
}
