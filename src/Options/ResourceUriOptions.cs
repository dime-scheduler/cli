using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourceuri", HelpText = "Add or remove a URI to the resource.")]
    public class ResourceUriOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The unique number to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option(HelpText = "The URI.")]
        public string Link { get; set; }

        [Option(HelpText = "The description.")]
        public string Description { get; set; }

        public IImportRequestable ToImport() => (ResourceUri)this;

        public static implicit operator ResourceUri(ResourceUriOptions options)
          => new()
          {
              Description = options.Description,
              ResourceNo = options.ResourceNo,
              Uri = options.Link
          };
    }
}