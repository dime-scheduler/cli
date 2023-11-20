using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class LiveResourceLocationCommand :
        ImportCommand<ResourceLiveLocationOptions, ResourceGpsTracking>,
        ICommand<ResourceLiveLocationOptions>
    {
        protected override string WriteIntro(ResourceLiveLocationOptions options)
        => $"Adding live location for resource number {options.ResourceNo} " +
                                  $"with coordinates {options.Latitude} {options.Longitude}";
    }
}