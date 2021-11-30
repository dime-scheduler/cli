using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addFilterValue", HelpText = "Adds a filter value.")]
    public class AddFilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string Group { get; set; }

        [Option]
        public string Value { get; set; }

        public IImportRequestable ToImport() => (FilterValue)this;

        public static implicit operator FilterValue(AddFilterValueOptions options)
          => new()
          {
              Group = options.Group,
              Value = options.Value
          };
    }
}