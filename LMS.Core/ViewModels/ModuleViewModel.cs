using System.ComponentModel;

namespace LMS.Web.ViewModels
{
    public class ModuleViewModel
    {
        [DisplayName("Course number")]
        public int CourseId { get; set; }

        [DisplayName("Module Title")]
        public string? Title { get; set; }
        

    }
}
