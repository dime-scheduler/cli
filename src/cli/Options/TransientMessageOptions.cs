using CommandLine;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("transientmessage", HelpText = "Add or remove a fly-in message to the online users.")]
    public class TransientMessageOptions : BaseOptions
    {
        [Option('t', "text", Required = true, HelpText = "The text to display.")]
        public string Text { get; set; }

        [Option('s', "severity", Required = true, HelpText = "The message's severity.")]
        public int Severity { get; set; }

        [Option('a', "to", HelpText = "The individual to send the message to. Optional.")]
        public string To { get; set; }
    }
}