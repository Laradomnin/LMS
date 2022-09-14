using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
#nullable disable
    public class Activity
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int ModuleId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ActivityType ActivityType { get; set; }
        public int ActivityTypeId { get; set; }
        public Module Module { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
