using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class CategoryCommand :
        Command<CategoryOptions, Category>,
        ICommand<CategoryOptions>
    {
        protected override string WriteIntro(CategoryOptions options)
            => $"Adding category with name {options.Name} and color {options.Color}";
    }
}