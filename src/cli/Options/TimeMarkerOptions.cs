using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("timemarker", HelpText = "Add or remove a time marker.")]
    public class TimeMarkerOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (TimeMarker)this;

        public static implicit operator TimeMarker(TimeMarkerOptions options)
           => new()
           {
               Color = options.Color,
               Name = options.Name
           };
    }
}