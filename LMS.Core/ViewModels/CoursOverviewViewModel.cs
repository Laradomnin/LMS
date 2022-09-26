using LMS.Core.Entities;
using System.ComponentModel;

namespace LMS.Web.ViewModels
{
    public class CoursOverviewViewModel
    {

        // course
        [DisplayName("Course Title")]
        public string? Title { get; set; }

        [DisplayName("Course number")]
        public int Id { get; set; }

        [DisplayName("Course description")]
        public string? Description { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }


        public ICollection<Module> Modules { get; set; } = new List<Module>();
    }


}

