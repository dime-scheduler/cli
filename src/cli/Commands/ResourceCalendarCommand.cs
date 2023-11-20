using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

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