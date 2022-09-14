namespace LMS.Core.Entities
{
# nullable disable

    public class Document
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseId { get; set; }
        public string UserId { get; set; }
        public int? ModuleId { get; set; }
        public int? ActivityId { get; set; }
        public DateTime TimeStamp { get; set; }
        //NP
        public User User { get; set; }  
        public Activity Activity { get; set; }
        public Module Module { get; set; }
        public Course Course { get; set; }
    }
}