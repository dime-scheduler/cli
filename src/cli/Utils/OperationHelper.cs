using System;
using Dime.Scheduler.CLI.Options;

namespace Dime.Scheduler.CLI.Utils
{
    internal static class OperationHelper
    {
        internal static string GetOperationType(this BaseOptions opts)
        {
            _ = Enum.TryParse(opts.Action, out CrudAction action);
            return action != CrudAction.Delete ? "Appending" : "Deleting"; ;
        }
    }
}