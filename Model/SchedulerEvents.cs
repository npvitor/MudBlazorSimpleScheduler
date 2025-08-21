namespace MudBlazorSimpleScheduler.Model
{
    public class SchedulerEvents
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Description { get; set; }
    }
}
