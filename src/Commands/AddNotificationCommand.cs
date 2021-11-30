using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddNotificationCommand :
        ImportCommand<AddNotificationOptions, Notification>,
      ICommand<AddNotificationOptions>
    {
        protected override string WriteIntro(AddNotificationOptions options)
            => "Adding notification";
    }
}