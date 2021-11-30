using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addTimeMarker", HelpText = "Adds a time marker.")]
    public class AddTimeMarkerOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (TimeMarker)this;

        public static implicit operator TimeMarker(AddTimeMarkerOptions options)
           => new()
           {
               Color = options.Color,
               Name = options.Name
           };
    }
}