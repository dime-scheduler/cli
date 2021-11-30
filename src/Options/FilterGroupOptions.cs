using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("filtergroup", HelpText = "Add or remove a filter group.")]
    public class FilterGroupOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public int Id { get; set; }

        [Option]
        public string Name { get; set; }

        [Option]
        public int ColumnNo { get; set; }

        [Option]
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