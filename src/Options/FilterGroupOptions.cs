using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("filtergroup", HelpText = "Add or remove a filter group.")]
    public class FilterGroupOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The ID.")]
        public int Id { get; set; }

        [Option(HelpText = "The filter group name.")]
        public string Name { get; set; }

        [Option(HelpText = "N/A")]
        public int ColumnNo { get; set; }

        [Option(HelpText = "N/A")]
        public bool DataFilter { get; set; }

        public IImportRequestable ToImport() => (FilterGroup)this;

        public static implicit operator FilterGroup(FilterGroupOptions options)
          => new()
          {
              ColumnNo = options.ColumnNo,
              DataFilter = options.DataFilter,
              Id = options.Id,
              Name = options.Name
          };
    }
}