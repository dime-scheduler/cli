using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddCaptionCommand :
        ImportCommand<AddCaptionOptions, Caption>,
        ICommand<AddCaptionOptions>
    {
        protected override string WriteIntro(AddCaptionOptions options)
            => $"Adding caption in context {options.Context} " +
            $"with field {options.FieldName} " +
            $"and value {options.Text} " +
            $"in language {options.Language}";
    }
}