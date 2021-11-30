using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("caption", HelpText = "Add or remove a caption.")]
    public class CaptionOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The caption context.")]
        public int Context { get; set; } = 6;

        [Option(HelpText = "The source table.")]
        public string SourceTable { get; set; }

        [Option(HelpText = "The field's name.")]
        public string FieldName { get; set; }

        [Option(HelpText = "The language.")]
        public string Language { get; set; }

        [Option(HelpText = "The text.")]
        public string Text { get; set; }

        public IImportRequestable ToImport() => (Caption)this;

        public static implicit operator Caption(CaptionOptions options)
          => new()
          {
              Context = options.Context,
              FieldName = options.FieldName,
              Language = options.Language,
              SourceTable = options.SourceTable,
              Text = options.Text
          };
    }
}