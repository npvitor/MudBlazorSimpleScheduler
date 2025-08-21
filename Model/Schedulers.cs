namespace MudBlazorSimpleScheduler.Model
{
    public class Schedulers
    {
        public TimeOnly Time { get; set; }
        public SchedulerEvents DayOne { get; set; } = new();
        public SchedulerEvents DayTwo { get; set; } = new();
        public SchedulerEvents DayThree { get; set; } = new();
        public SchedulerEvents DayFour { get; set; } = new();
        public SchedulerEvents DayFive { get; set; } = new();
        public SchedulerEvents DaySix { get; set; } = new();
        public SchedulerEvents DaySeven { get; set; } = new();
    }
}
