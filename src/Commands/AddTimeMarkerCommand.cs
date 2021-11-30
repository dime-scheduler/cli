using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTimeMarkerCommand : 
        ImportCommand<AddTimeMarkerOptions, TimeMarker>,
        ICommand<AddTimeMarkerOptions>
    {        
        protected override string WriteIntro(AddTimeMarkerOptions options)
            => $"Adding time marker with name {options.Name} and color {options.Color}";
    }
}