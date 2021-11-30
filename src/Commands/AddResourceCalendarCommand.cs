using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCalendarCommand :
        ImportCommand<AddResourceCalendarOptions, ResourceCalendar>,
        ICommand<AddResourceCalendarOptions>
    {
        protected override string WriteIntro(AddResourceCalendarOptions options)
          => $"Assigns a calendar to the requested resource.";
    }
}