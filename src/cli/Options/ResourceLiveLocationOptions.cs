using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("resourcelivelocation", HelpText = "Add or remove a live location for the resource.")]
    public class ResourceLiveLocationOptions : BaseOptions, IImportConvertable
    {
        [Option('r', "resourceno", Required = true, HelpText = "The unique number to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option('x', "latitude", Required = true, HelpText = "The latitude.")]
        public decimal Latitude { get; set; }

        [Option('y', "longitude", Required = true, HelpText = "The longitude.")]
        public decimal Longitude { get; set; }

        public IImportRequestable ToImport() => (ResourceGpsTracking)this;

        public static implicit operator ResourceGpsTracking(ResourceLiveLocationOptions options)
          => new()
          {
              ResourceNo = options.ResourceNo,
              Latitude = options.Latitude,
              Longitude = options.Longitude
          };
    }
}