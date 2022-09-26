using LMS.Core.Entities;
using LMS.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace LMS.Web.Data.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly ApplicationDbContext db = null!;
        public ModuleRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Task<IEnumerable<Module>> GetWithDocsAsync()
        {
            throw new NotImplementedException();
        }

        public void Add(User booking)
        {
            db.Users.Add(booking);
        }

        public void Remove(User attending)
        {
            db.Remove(attending);
        }
        public void Add(Module module)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Module>> GetModulesAsync()
        {
            return await db.Modules.ToListAsync();
        }

        public Task<Module?> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Module>> GetHistoryAsync()
        {
            throw new NotImplementedException();
        }

        
    }
}
