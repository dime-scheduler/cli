using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addFilterGroup", HelpText = "Adds a filter group.")]
    public class AddFilterGroupOptions : BaseOptions
    {
        [Option]
        public int Id { get; set; }

        [Option]
        public string Name { get; set; }

        [Option]
        public int ColumnNo { get; set; }

        [Option]
        public bool DataFilter { get; set; }
    }
}