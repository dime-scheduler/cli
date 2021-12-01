using Dime.Scheduler.CLI.Options;

namespace Dime.Scheduler.CLI.Utils
{
    internal static class OperationHelper
    {
        internal static string GetOperationType(this BaseOptions opts)
            => opts.Append ? "Appending" : "Deleting";
    }
}