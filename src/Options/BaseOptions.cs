using CommandLine;

namespace Dime.Scheduler.CLI
{
    public abstract class BaseOptions : ImportBaseOptions
    {
        [Option('u', "URI", Required = true, HelpText = "The base URI of Dime.Scheduler.")]
        public string Uri { get; set; }

        [Option('c', "user", Required = true, HelpText = "The Dime.Scheduler user's email address.")]
        public string User { get; set; }

        [Option('p', "password", Required = true, HelpText = "The Dime.Scheduler user's password.")]
        public string Password { get; set; }
    }
}