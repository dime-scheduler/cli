using CommandLine;

namespace Dime.Scheduler.DotNetTool
{
    [Verb("addCategory", HelpText = "Adds a category.")]
    public class AddCategoryOptions : BaseOptions
    {
        [Option('n', "name", Required = true)]
        public string Name { get; set; }

        [Option('h', "hex", Required = true)]
        public string Color { get; set; }
    }
}