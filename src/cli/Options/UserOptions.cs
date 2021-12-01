using CommandLine;
using Dime.Scheduler.Sdk;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("user", HelpText = "Add or remove a user.")]
    public class UserOptions : BaseOptions
    {
        [Option(HelpText = "The user's e-mail address.")]
        public string Email { get; set; }

        [Option(HelpText = "The user's password.")]
        public string Key { get; set; }

        [Option(HelpText = "The user type.")]
        public LoginType Type { get; set; }

        [Option(HelpText = "The user's language.")]
        public string Language { get; set; }

        [Option(HelpText = "The user's time zone.")]
        public string TimeZone { get; set; }
    }
}