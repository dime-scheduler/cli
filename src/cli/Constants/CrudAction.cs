using System.ComponentModel;

namespace Dime.Scheduler.CLI.Options
{
    public enum CrudAction
    {
        [Description("add")]
        Create,

        [Description("update")]
        Update,

        [Description("delete")]
        Delete
    }
}