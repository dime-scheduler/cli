using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addCaption", HelpText = "Adds a caption.")]
    public class AddCaptionOptions : BaseOptions
    {
        [Option]
        public int Context { get; set; } = 6;

        [Option]
        public string SourceTable { get; set; }

        [Option]
        public string FieldName { get; set; }

        [Option]
        public string Language { get; set; }

        [Option]
        public string Text { get; set; }
    }
}