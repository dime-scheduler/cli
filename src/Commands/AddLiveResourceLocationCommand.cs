using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddLiveResourceLocationCommand :
        ImportCommand<AddResourceLiveLocationOptions, ResourceGpsTracking>,
        ICommand<AddResourceLiveLocationOptions>
    {
        protected override string WriteIntro(AddResourceLiveLocationOptions options)
        => $"Adding live location for resource number {options.ResourceNo} " +
                                  $"with coordinates {options.Latitude} {options.Longitude}";
    }
}