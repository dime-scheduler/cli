using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("actionuri", HelpText = "Add or remove an action URI.")]
    public class ActionUriOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The URI type.")]
        public UriType UriType { get; set; }

        [Option(HelpText = "The URI.")]
        public string Link { get; set; }

        [Option(HelpText = "The description of the action URI.")]
        public string Description { get; set; }

        [Option(HelpText = "Flag to indicate whether this is the default action URI.")]
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