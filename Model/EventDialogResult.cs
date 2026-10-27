namespace MudBlazorSimpleScheduler.Model
{
    /// <summary>
    /// Retorno do <c>EventDialog</c>: a descrição salva ou o pedido de exclusão.
    /// </summary>
    public record EventDialogResult(string? Description, bool Delete = false);
}
