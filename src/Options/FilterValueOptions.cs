using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("filtervalue", HelpText = "Add or remove a filter value.")]
    public class FilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string Group { get; set; }

        [Option]
        public string Value { get; set; }

        public IImportRequestable ToImport() => (FilterValue)this;

        public static implicit operator FilterValue(FilterValueOptions options)
          => new()
          {
              Group = options.Group,
              Value = options.Value
          };
    }
}