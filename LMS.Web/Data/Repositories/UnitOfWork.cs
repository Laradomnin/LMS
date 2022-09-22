using LMS.Core.Repositories;

namespace LMS.Web.Data.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext db;
        public ModuleRepository ModuleRepository { get; }
        public IUserRepository UserRepository { get; }

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            ModuleRepository = new ModuleRepository(db);
            UserRepository = new UserRepository(db);
        }

        public async Task CompleteAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}
