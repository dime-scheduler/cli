using System.ComponentModel;

namespace Dime.Scheduler.CLI.Options
{
    public enum Environment
    {
        [Description("https://api.dimescheduler.com")]
        Production,

        [Description("https://api-d.dimescheduler.com")]
        Dev,

        [Description("https://api-t.dimescheduler.com")]
        Test,

        [Description("https://api-u.dimescheduler.com")]
        Staging
    }
}