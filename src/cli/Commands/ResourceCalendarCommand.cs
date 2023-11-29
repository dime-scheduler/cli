using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCalendarCommand :
        Command<ResourceCalendarOptions, ResourceCalendar>,
        ICommand<ResourceCalendarOptions>
    {
        protected override string WriteIntro(ResourceCalendarOptions options)
          => $"Assigns a calendar to the requested resource.";
    }
}