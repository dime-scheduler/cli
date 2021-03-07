using System;
using System.Threading.Tasks;
using CommandLine;
using Dime.Scheduler.DotNetTool.Commands;

namespace Dime.Scheduler.DotNetTool
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ShowDimeScheduler();

            await Parser
                .Default
                .ParseArguments<AddCategoryOptions, AddResourceLiveLocationOptions>(args)
                .MapResult(
                    async (AddCategoryOptions opts) => await RunAddCategory(opts),
                    async (AddResourceLiveLocationOptions opts) => await RunAddResourceLiveLocationAndReturnExitCode(opts),
                    _ => Task.FromResult(-1));
        }

        private static async Task RunAddResourceLiveLocationAndReturnExitCode(AddResourceLiveLocationOptions opts)
        {
            AddLiveResourceLocationCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddCategory(AddCategoryOptions opts)
        {
            AddCategoryCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static void ShowDimeScheduler()
        {
            const string txt = @"
██████╗ ██╗███╗   ███╗███████╗   ███████╗ ██████╗██╗  ██╗███████╗██████╗ ██╗   ██╗██╗     ███████╗██████╗ 
██╔══██╗██║████╗ ████║██╔════╝   ██╔════╝██╔════╝██║  ██║██╔════╝██╔══██╗██║   ██║██║     ██╔════╝██╔══██╗
██║  ██║██║██╔████╔██║█████╗     ███████╗██║     ███████║█████╗  ██║  ██║██║   ██║██║     █████╗  ██████╔╝
██║  ██║██║██║╚██╔╝██║██╔══╝     ╚════██║██║     ██╔══██║██╔══╝  ██║  ██║██║   ██║██║     ██╔══╝  ██╔══██╗
██████╔╝██║██║ ╚═╝ ██║███████╗██╗███████║╚██████╗██║  ██║███████╗██████╔╝╚██████╔╝███████╗███████╗██║  ██║
╚═════╝ ╚═╝╚═╝     ╚═╝╚══════╝╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝  ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═╝                                                                                                       
";
            Console.WriteLine(txt);
        }
    }
}