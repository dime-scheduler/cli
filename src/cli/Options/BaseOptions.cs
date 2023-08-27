using CommandLine;
using Dime.Scheduler.Sdk;

namespace Dime.Scheduler.CLI.Options
{
    public abstract class BaseOptions : ImportBaseOptions
    {     
        [Option('k', "key", Required = true, HelpText = "Your API key")]
        public string Key { get; set; }

        [Option('a', "append", Group = "action", HelpText = "Append the record to Dime.Scheduler.")]
        public bool Append { get; set; }

        [Option('d', "delete", Group = "action", HelpText = "Remove the record from Dime.Scheduler.")]
        public bool Delete { get; set; }

        [Option("env")]
        public Environment Environment { get; set; } = Environment.Production;

        public static implicit operator AuthenticationOptions(BaseOptions opts) => new(opts.Environment.GetDescription(), opts.Key);
    }
}