using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("category", HelpText = "Add or remove a category.")]
    public class CategoryOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (Category)this;

        public static implicit operator Category(CategoryOptions options)
          => new()
          {
              Color = options.Color,
              DisplayName = options.Name,
              Name = options.Name
          };
    }
}