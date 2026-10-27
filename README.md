# MudBlazor Simple Scheduler

Exemplo de um Scheduler simples feito com MudBlazor para servir de base para projetos mais detalhados.

Exibe uma grade de horários × dias, com navegação por período, seleção de data e criação, edição e exclusão de eventos.

## Requisitos

- .NET 8
- MudBlazor 7

## Executando o exemplo

```bash
dotnet run --launch-profile http
```

Abra `http://localhost:5252`. Os eventos de exemplo ficam em memória, em [Components/Pages/Home.razor](Components/Pages/Home.razor).

## Usando no seu projeto

Copie para o seu projeto:

- `Components/Scheduler/SimpleScheduler.razor` e `SimpleScheduler.razor.css`
- `Model/SchedulerEvents.cs`, `Model/SchedulerRow.cs` e `Model/SchedulerSlot.cs`
- opcionalmente `Components/Dialogs/EventDialog.razor` e `Model/EventDialogResult.cs`

Garanta que o `App.razor` referencia o CSS isolado do projeto (`<link href="SeuProjeto.styles.css" rel="stylesheet" />`) e que o componente roda em modo interativo.

```razor
<SimpleScheduler Events="_events"
                 @bind-StartDate="_startDate"
                 OpeningTime="new TimeOnly(8, 0)"
                 ClosingTime="new TimeOnly(20, 0)"
                 SlotDurationMinutes="30"
                 OnSlotClick="CreateEventAsync"
                 OnEventClick="EditEventAsync" />
```

O componente só exibe; quem salva, edita e exclui é a página, nos callbacks. Assim ele funciona com qualquer fonte de dados (EF Core, API, etc.). Veja `Home.razor` para um exemplo completo com diálogo.

### Parâmetros

| Parâmetro | Tipo | Padrão | Descrição |
|---|---|---|---|
| `Events` | `IEnumerable<SchedulerEvents>` | vazio | Eventos a exibir. Um evento entra no horário que o contém (ex.: 13:15 aparece no horário das 13:00). |
| `StartDate` / `@bind-StartDate` | `DateOnly?` | hoje | Primeiro dia exibido. |
| `DaysToShow` | `int` | `7` | Quantidade de dias (colunas). |
| `OpeningTime` | `TimeOnly` | `09:00` | Início do expediente. |
| `ClosingTime` | `TimeOnly` | `18:00` | Fim do expediente. Horários que terminariam depois dele não são criados. |
| `SlotDurationMinutes` | `int` | `60` | Duração de cada horário. |
| `SlotHeight` | `int` | `69` | Altura de cada horário, em pixels. |
| `AllowPastSlots` | `bool` | `true` | Se `false`, horários que já passaram ficam desabilitados. |
| `Loading` | `bool` | `false` | Mostra o indicador de carregamento da grade. |
| `Culture` | `CultureInfo?` | cultura atual | Formato de datas, horas e nomes dos dias. |
| `EventTemplate` | `RenderFragment<SchedulerEvents>?` | descrição | Conteúdo customizado de cada evento. |
| `EventStyle` | `Func<SchedulerEvents, string?>?` | — | CSS inline por evento, ex.: `e => "background-color: orange"`. |
| `OnSlotClick` | `EventCallback<SchedulerSlot>` | — | Clique em horário livre (data e hora). |
| `OnEventClick` | `EventCallback<SchedulerEvents>` | — | Clique em evento existente. |

### Idioma

O exemplo força `pt-BR` em `Program.cs` (`UseRequestLocalization`). Para outro idioma, troque a cultura ali ou passe `Culture` ao componente. Os textos fixos ("Hora", "Hoje", "Data inicial") estão em `SimpleScheduler.razor`.
