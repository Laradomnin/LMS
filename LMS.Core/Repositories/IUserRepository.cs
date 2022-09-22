using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repositories
{
    public interface IUserRepository
    {
        void Add(User courseBooking);

        [return: MaybeNull]
        Task<User?> FindAsync(string userId, int courseId);
        void Remove(User attending);
    }
}
