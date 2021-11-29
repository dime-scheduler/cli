using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addFilterValue", HelpText = "Adds a filter value.")]
    public class AddFilterValueOptions : BaseOptions
    {
        [Option]
        public string Group { get; set; }

        [Option]
        public string Value { get; set; }
    }
}