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
        public string Description { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        // meta
        //[DisplayName("")]
        //public int Number { get; set; }
        //[DisplayName("")]
        //public string IsParked { get; set; }

        // module
        [DisplayName("Module Id")]
        public int MId { get; set; }

        [DisplayName("Module Title")]
        public string MTitle { get; set; }
        
    }

}

