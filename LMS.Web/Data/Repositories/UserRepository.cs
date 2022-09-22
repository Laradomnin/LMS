using LMS.Core.Entities;
using LMS.Core.Repositories;
using System.Diagnostics.CodeAnalysis;

namespace LMS.Web.Data.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext db = null!;

        public UserRepository(ApplicationDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        [return: MaybeNull]
        public async Task<User?> FindAsync(string userId, int courseId)
        {
            return await db.Users.FindAsync(userId, courseId);
        }

        public void Add(User courseBooking)
        {
            db.Users.Add(courseBooking);
        }

        public void Remove(User attending)
        {
            db.Remove(attending);
        }


    }
}
