using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addActionUri", HelpText = "Adds an action URI.")]
    public class AddActionUriOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public int UriType { get; set; }

        [Option]
        public string Uri { get; set; }

        [Option]
        public string Description { get; set; }

        [Option]
        public bool Default { get; set; }
    }
}