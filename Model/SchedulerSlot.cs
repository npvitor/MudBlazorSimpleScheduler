namespace MudBlazorSimpleScheduler.Model
{
    /// <summary>
    /// Horário livre clicado no scheduler.
    /// </summary>
    public record SchedulerSlot(DateOnly Date, TimeOnly Time);
}
