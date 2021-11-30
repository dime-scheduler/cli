using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addFilterGroup", HelpText = "Adds a filter group.")]
    public class AddFilterGroupOptions : BaseOptions, IImportConvertable
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

        public static implicit operator FilterGroup(AddFilterGroupOptions options)
          => new()
          {
              ColumnNo = options.ColumnNo,
              DataFilter = options.DataFilter,
              Id = options.Id,
              Name = options.Name
          };
    }
}