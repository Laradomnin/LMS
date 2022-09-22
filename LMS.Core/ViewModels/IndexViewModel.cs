using LMS.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.ViewModels
{
    internal class IndexViewModel
    {
        public IEnumerable<ModuleViewModel> Modules { get; set; } = new List<ModuleViewModel>();
        public bool ShowDocuments { get; set; }
    }
}
