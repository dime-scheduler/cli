using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcefiltervalue", HelpText = "Add or remove a filter value to the resource.")]
    public class ResourceFilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public string FilterGroup { get; set; }

        [Option]
        public string FilterValue { get; set; }

        [Option]
        public bool TransferToTemp { get; set; }

        public IImportRequestable ToImport() => (ResourceFilterValue)this;

        public static implicit operator ResourceFilterValue(ResourceFilterValueOptions options)
          => new()
          {
              FilterGroup = options.FilterGroup,
              FilterValue = options.FilterValue,
              ResourceNo = options.ResourceNo,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TransferToTemp = options.TransferToTemp
          };
    }
}