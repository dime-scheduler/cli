using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class TimeMarkerCommand :
        Command<TimeMarkerOptions, TimeMarker>,
        ICommand<TimeMarkerOptions>
    {
        protected override string WriteIntro(TimeMarkerOptions options)
            => $"Adding time marker with name {options.Name} and color {options.Color}";
    }
}