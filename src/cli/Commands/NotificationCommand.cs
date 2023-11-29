using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class NotificationCommand :
        Command<NotificationOptions, Notification>,
      ICommand<NotificationOptions>
    {
        protected override string WriteIntro(NotificationOptions options)
            => "Adding notification";
    }
}