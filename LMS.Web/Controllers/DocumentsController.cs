using LMS.Core.ViewModels;
using LMS.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS.Core.Entities;

    namespace LMS.Web.Controllers
{
    public class DocumentsController : Controller
    {
        private readonly ApplicationDbContext db;

        public DocumentsController(ApplicationDbContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()//(int? docId, int? courseId)
        {
            var viewModel = new DocumentIndexViewModel();
            viewModel.Documents = await db.Documents
                  .Include(i => i.User)
                    .ThenInclude(i => i.Course)
                  .Include(i => i.Module)
                    .ThenInclude(i => i.Activities)
                     .ThenInclude(i => i.ActivityType)   

                  .OrderBy(i => i.CourseId)
                  .ToListAsync();

            //if (docId != null)
            //{
            //    ViewData["DocumentId"] = docId.Value;
            //    Document document = viewModel.Documents.Where(
            //        i => i.Id == docId.Value).Single();
            //    viewModel.Documents = document.Activities.Select;
            //}

            //if (courseId != null)
            //{
            //    ViewData["CourseI"] = courseId.Value;
            //    viewModel. = viewModel.Courses.Where(
            //        x => x.CourseID == courseID).Single().Enrollments;
            //}

            return View(viewModel);
        }
    }
}
