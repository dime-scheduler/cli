using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceFilterValue", HelpText = "Updates a part of the resource.")]
    public class AddResourceFilterValueOptions : BaseOptions, IImportConvertable
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

        public static implicit operator ResourceFilterValue(AddResourceFilterValueOptions options)
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