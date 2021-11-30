namespace Dime.Scheduler.CLI.Commands
{
    internal static class OperationHelper
    {
        internal static string GetOperationType(this BaseOptions opts)
            => opts.Append ? "Appending" : "Deleting";
    }
}