using Resource = Dime.Scheduler.Sdk.Import.Resource;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCommand :
        ImportCommand<AddResourceOptions, Resource>,
        ICommand<AddResourceOptions>
    {  
        protected override string WriteIntro(AddResourceOptions options) => $"Adding resource.";
    }
}