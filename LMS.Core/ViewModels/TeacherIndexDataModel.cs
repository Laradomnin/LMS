using LMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.ViewModels
{
    
        public class TeacherIndexDataModel
        {
            public IEnumerable<User> Teachers { get; set; }
            public IEnumerable<Course>? Courses { get; set; }
            public IEnumerable<Document>? Documents { get; set; }
        public IEnumerable<Module>? Modules { get; set; }
        public string? Role { get; set; }
        }
    }
}
