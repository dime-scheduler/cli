using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCalendarCommand :
        ImportCommand<ResourceCalendarOptions, ResourceCalendar>,
        ICommand<ResourceCalendarOptions>
    {
        protected override string WriteIntro(ResourceCalendarOptions options)
          => $"Assigns a calendar to the requested resource.";
    }
}