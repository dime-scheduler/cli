using CommandLine;
using Dime.Scheduler.Sdk;

namespace Dime.Scheduler.CLI.Options
{
    public abstract class BaseOptions : ImportBaseOptions
    {
        [Option('u', "URI", Required = true, HelpText = "The base URI of Dime.Scheduler.")]
        public string Uri { get; set; }

        [Option('k', "key", Required = true, HelpText = "Your API key")]
        public string Key { get; set; }

        public static implicit operator AuthenticationOptions(BaseOptions opts) => new(opts.Uri, opts.Key);
    }
}