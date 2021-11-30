using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addCategory", HelpText = "Adds a category.")]
    public class AddCategoryOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (Category)this;

        public static implicit operator Category(AddCategoryOptions options)
          => new()
          {
              Color = options.Color,
              DisplayName = options.Name,
              Name = options.Name
          };
    }
}