using CommandLine;

namespace Dime.Scheduler.CLI.Options
{
    public abstract class BaseOptions
    {
        [Value(0)]
        public string Action { get; set; }

        [Option('k', "key", Required = true, HelpText = "Your API key")]
        public string Key { get; set; }

        [Option("env")]
        public Environment Environment { get; set; } = Environment.Production;

        public static implicit operator EndpointOptions(BaseOptions opts) => new(opts.Environment.GetDescription(), opts.Key);
    }
}