using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TimeMarkerCommand : 
        ImportCommand<TimeMarkerOptions, TimeMarker>,
        ICommand<TimeMarkerOptions>
    {        
        protected override string WriteIntro(TimeMarkerOptions options)
            => $"Adding time marker with name {options.Name} and color {options.Color}";
    }
}