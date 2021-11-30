using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System.Globalization;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcelivelocation", HelpText = "Add or remove a live location for the resource.")]
    public class ResourceLiveLocationOptions : BaseOptions, IImportConvertable
    {
        [Option('r', "resourceno", Required = true)]
        public string ResourceNo { get; set; }

        [Option('x', "latitude", Required = true)]
        public string Latitude { get; set; }

        [Option('y', "longitude", Required = true)]
        public string Longitude { get; set; }

        public IImportRequestable ToImport() => (ResourceGpsTracking)this;

        public static implicit operator ResourceGpsTracking(ResourceLiveLocationOptions options)
          => new()
          {
              ResourceNo = options.ResourceNo,
              Latitude = decimal.Parse(options.Latitude, CultureInfo.InvariantCulture),
              Longitude = decimal.Parse(options.Longitude, CultureInfo.InvariantCulture)
          };
    }
}