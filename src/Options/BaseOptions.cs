using CommandLine;

namespace Dime.Scheduler.CLI
{
    public abstract class BaseOptions
    {
        [Option('u', "URI", Required = true)]
        public string Uri { get; set; }

        [Option('c', "user", Required = true)]
        public string User { get; set; }

        [Option('p', "password", Required = true)]
        public string Password { get; set; }
    }
}