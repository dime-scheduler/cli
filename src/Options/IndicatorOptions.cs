using CommandLine;

namespace Dime.Scheduler.CLI
{
    public abstract class IndicatorOptions : BaseOptions
    {
        [Option('n', "name", Required = true, HelpText = "The name.")]
        public string Name { get; set; }

        [Option('h', "hex", Required = true, HelpText = "The color.")]
        public string Color { get; set; }
    }
}