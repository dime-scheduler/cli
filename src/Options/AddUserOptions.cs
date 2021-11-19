using CommandLine;
using Dime.Scheduler.Sdk;

namespace Dime.Scheduler.CLI
{
    [Verb("addUser", HelpText = "Adds a user.")]
    public class AddUserOptions : BaseOptions
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public LoginType Type { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
    }
}