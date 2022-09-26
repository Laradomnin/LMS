using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repositories
{
    public interface IModuleRepository
    {

        Task<IEnumerable<Module>> GetModulesAsync();
        Task<IEnumerable<Module>> GetWithDocsAsync();
        Task<IEnumerable<Module>> GetHistoryAsync();
        Task<Module?> GetAsync(int? id);
        void Add(Module module);
    }
}
