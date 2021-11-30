using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddCategoryCommand :
        ImportCommand<AddCategoryOptions, Category>,
        ICommand<AddCategoryOptions>
    {
        protected override string WriteIntro(AddCategoryOptions options)
            => $"Adding category with name {options.Name} and color {options.Color}";
    }
}