using System.Threading.Tasks;

namespace Dime.Scheduler.CLI.Commands
{
    internal interface ICommand<in TOptions>
    {
        Task ProcessAsync(TOptions options);
    }
}