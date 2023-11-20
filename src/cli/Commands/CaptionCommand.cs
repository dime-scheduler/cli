using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class CaptionCommand :
        Command<CaptionOptions, Caption>,
        ICommand<CaptionOptions>
    {
        protected override string WriteIntro(CaptionOptions options)
            => $"Adding caption in context {options.Context} " +
            $"with field {options.FieldName} " +
            $"and value {options.Text} " +
            $"in language {options.Language}";
    }
}