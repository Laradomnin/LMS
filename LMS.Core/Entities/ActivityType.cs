namespace LMS.Core.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Activity>? Activitys { get; set; }
    }
}