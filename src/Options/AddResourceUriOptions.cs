using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceUri", HelpText = "Updates a part of the resource.")]
    public class AddResourceUriOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public string Link { get; set; }

        [Option]
        public string Description { get; set; }

        public IImportRequestable ToImport() => (ResourceUri)this;

        public static implicit operator ResourceUri(AddResourceUriOptions options)
          => new()
          {
              Description = options.Description,
              ResourceNo = options.ResourceNo,
              Uri = options.Link
          };
    }
}