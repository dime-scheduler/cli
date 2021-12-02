using CommandLine;
using Dime.Scheduler.Sdk;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("transientmessage", HelpText = "Add or remove a fly-in message to the online users.")]
    public class TransientMessageOptions : BaseOptions
    {
        [Option('m', "message", Required = true, HelpText = "The text to display.")]
        public string Text { get; set; }

        [Option('s', "severity", Required = true, HelpText = "The message's severity. Accepted values include Info, Warning, Error, Fatal.")]
        public Severity Severity { get; set; }

        [Option('t', "to", HelpText = "Optional. The individual to send the message to.")]
        public string To { get; set; }
    }
}