using CommandLine;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("user", HelpText = "Add or remove a user.")]
    public class UserOptions : BaseOptions
    {
        [Option(Required = true, HelpText = "The user's e-mail address.")]
        public string Email { get; set; }

        [Option(HelpText = "The user type.", Default = LoginType.Forms)]
        public LoginType Type { get; set; } = LoginType.Forms;

        [Option(HelpText = "The user's language.")]
        public string Language { get; set; }

        [Option(HelpText = "The user's time zone.")]
        public string TimeZone { get; set; }

        [Option(Required = true, HelpText = "The user's password.")]
        public string Password { get; set; }
    }
}