using LMS.Core.Entities;
using LMS.Core.Repositories;
using System.Diagnostics.CodeAnalysis;
namespace LMS.Web.Data.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly ApplicationDbContext db = null!;


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

        public Task<IEnumerable<Module>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Module?> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Module>> GetHistoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Module>> GetWithAttendinAsync()
        {
            throw new NotImplementedException();
        }
    }
}
