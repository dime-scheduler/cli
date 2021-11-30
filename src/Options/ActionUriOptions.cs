using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("actionuri", HelpText = "Add or remove an action URI.")]
    public class ActionUriOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public int UriType { get; set; }

        [Option]
        public string Link { get; set; }

        [Option]
        public string Description { get; set; }

        [Option]
        public bool Default { get; set; }

        public IImportRequestable ToImport() => (ActionUri)this;

        public static implicit operator ActionUri(ActionUriOptions options)
           => new()
           {
               Default = options.Default,
               Description = options.Description,
               SourceApp = options.SourceApp,
               SourceType = options.SourceType,
               Uri = options.Link,
               UriType = options.UriType
           };
    }
}