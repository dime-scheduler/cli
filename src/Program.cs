using System;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ShowDimeScheduler();

            await Parser
                .Default
                .ParseArguments(args, new CommandList().Select(x => x.Key).ToArray())
                .MapResult(async (object opt) => await Run(opt), e => Task.FromResult(1));
        }

        private static async Task Run(object obj)
        {
            CommandList commandList = new();
            Type type = obj as Type;
            await commandList[obj.GetType()](obj);
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