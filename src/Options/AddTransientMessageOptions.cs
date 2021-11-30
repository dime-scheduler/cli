using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addTransientMessage", HelpText = "Adds a fly-in message to the online users.")]
    public class AddTransientMessageOptions : BaseOptions
    {
        [Option('t', "text", Required = true)]
        public string Text { get; set; }

        [Option('s', "severity", Required = true)]
        public int Severity { get; set; }

        [Option('a', "to")]
        public string To { get; set; }
    }
}