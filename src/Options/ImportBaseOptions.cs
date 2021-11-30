using CommandLine;

namespace Dime.Scheduler.CLI
{
    public abstract class ImportBaseOptions
    {
        [Option('a', "append", Group = "action", HelpText = "Append the record to Dime.Scheduler.")]
        public bool Append { get; set; }

        [Option('d', "delete", Group = "action", HelpText = "Remove the record from Dime.Scheduler.")]
        public bool Delete { get; set; }
    }
}