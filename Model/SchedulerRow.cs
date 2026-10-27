namespace MudBlazorSimpleScheduler.Model
{
    /// <summary>
    /// Uma linha do scheduler: um horário e os eventos daquele horário em cada dia exibido.
    /// </summary>
    public class SchedulerRow
    {
        public SchedulerRow(TimeOnly time, int days)
        {
            Time = time;
            Days = new List<SchedulerEvents>[days];

            for (int i = 0; i < days; i++)
                Days[i] = new List<SchedulerEvents>();
        }

        public TimeOnly Time { get; }

        /// <summary>Índice 0 = primeiro dia exibido.</summary>
        public List<SchedulerEvents>[] Days { get; }
    }
}
