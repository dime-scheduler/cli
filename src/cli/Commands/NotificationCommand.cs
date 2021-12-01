using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class NotificationCommand :
        ImportCommand<NotificationOptions, Notification>,
      ICommand<NotificationOptions>
    {
        protected override string WriteIntro(NotificationOptions options)
            => "Adding notification";
    }
}