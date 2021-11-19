using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addTimeMarker", HelpText = "Adds a time marker.")]
    public class AddTimeMarkerOptions : IndicatorOptions
    {
    }
}