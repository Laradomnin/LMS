namespace LMS.Core.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Activity> Activitys { get; set; } = new List<Activity>();
    }
}