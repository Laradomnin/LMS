﻿using Microsoft.EntityFrameworkCore;
using LMS.Core.Entities;
using LMS.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Web.Controllers
{
    public class ModulesController : Controller

    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
    {
        private readonly ApplicationDbContext _context;

        public ModulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{

        //    List<CoursOverviewViewModel> overviewList = new List<CoursOverviewViewModel>();
        //    var courses = _context.Courses.AsNoTracking().Include(m => m.Modules);

        //    foreach (var course in courses)
        //    {
        //        //int usersCount = course.Users.Count;

        //        foreach (var module in course.Modules)
        //        {
        //            var overview = new CoursOverviewViewModel();
        //            overview.Title = course.Title;
        //            overview.Id = course.Id;
        //            overview.Description = course.Description;
        //            //Alla dok. som hör till kursen

        //            overview.Id = module.Id;
        //            overview.MTitle = module.Title;
        //            overview.LastName = module.LastName;
        //            //overview.Role = user.Role;
        //            overview.Email = module.Email;

        //            //overview.NumberOfStudents = usersCount;

        //            //var parking = _context.Parking.Where(p => p.VehicleId == vehicle.Id).FirstOrDefault();
        //            //overview.IsParked = parking == null ? "" : "🅿";

        //            overviewList.Add(overview);
        //        }
        //    }
        //    return View(overviewList);
        //}



        // GET: Modules
        public async Task<IActionResult> Index()
        {
            return _context.Modules != null ?
                        View(await _context.Modules.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Modules'  is null.");
        }

        // GET: Modules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var module = await _context.Modules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (module == null)
            {
                return NotFound();
            }

            return View(module);
        }

        // GET: Module/Create
        [Authorize(Roles = "teacher")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Module/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Module module)
        {
            if (ModelState.IsValid)
            {
                _context.Add(module);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(module);
        }

        // GET: Module/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var module = await _context.Modules.FindAsync(id);
            if (module == null)
            {
                return NotFound();
            }
            return View(module);
        }

        // POST: Module/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,CourseId")] Module module)
        {
            if (id != module.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(module);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuleExists(module.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(module);
        }

        // GET: Module/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modules == null)
            {
                return NotFound();
            }

            var module = await _context.Modules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (module == null)
            {
                return NotFound();
            }

            return View(module);
        }

        // POST: Module/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modules == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Modules'  is null.");
            }
            var module = await _context.Modules.FindAsync(id);
            if (module != null)
            {
                _context.Modules.Remove(module);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuleExists(int id)
        {
            return (_context.Modules?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
