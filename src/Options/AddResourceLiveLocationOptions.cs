using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addLiveResourceLocation", HelpText = "Adds a live location for the resource.")]
    public class AddResourceLiveLocationOptions : BaseOptions
    {
        [Option('r', "resourceno", Required = true)]
        public string ResourceNo { get; set; }

        [Option('x', "latitude", Required = true)]
        public string Latitude { get; set; }

        [Option('y', "longitude", Required = true)]
        public string Longitude { get; set; }
    }
}