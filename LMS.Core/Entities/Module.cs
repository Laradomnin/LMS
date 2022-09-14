namespace LMS.Core.Entities
{
    public class Module
    {
       

        public Module (string title)
        {
            Title = title;
        }
        public int Id { get; set; } 
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;

        //NP
        public Course Course { get; set; } = default!;
        public ICollection<Activity> Activities { get; set; }=new List<Activity>();
        public ICollection<Document> Documents { get; set; }= new List<Document>(); 

        
    }
}