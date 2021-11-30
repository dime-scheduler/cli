using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcefiltervalue", HelpText = "Add or remove a filter value to the resource.")]
    public class ResourceFilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The unique identifier to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option(HelpText = "The filter group.")]
        public string FilterGroup { get; set; }

        [Option(HelpText = "The filter value.")]
        public string FilterValue { get; set; }

        [Option(HelpText = "N/A")]
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