namespace LMS.Core.Entities
{
# nullable disable

    public class Document
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public int ModuleId { get; set; }
        public int ActivityId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}