using System;
using System.Threading.Tasks;
using CommandLine;
using Dime.Scheduler.CLI.Commands;

namespace Dime.Scheduler.CLI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ShowDimeScheduler();

            await Parser
                .Default
                .ParseArguments<AddTimeMarkerOptions, AddPinOptions, AddCategoryOptions, AddAppointmentOptions, AddTransientMessageOptions, AddResourceLiveLocationOptions, AddContainerOptions, AddAppointmentContainerOptions, AddUserOptions>(args)
                .MapResult(
                    async (AddCategoryOptions opts) => await RunAddCategory(opts),
                    async (AddPinOptions opts) => await RunAddPin(opts),
                    async (AddTimeMarkerOptions opts) => await RunAddTimeMarker(opts),
                    async (AddAppointmentOptions opts) => await RunAddAppointment(opts),
                    async (AddTransientMessageOptions opts) => await RunAddMessage(opts),
                    async (AddResourceLiveLocationOptions opts) => await RunAddResourceLiveLocationAndReturnExitCode(opts),
                    async (AddContainerOptions opts) => await RunAddContainer(opts),
                    async (AddAppointmentContainerOptions opts) => await RunAddAppointmentContainer(opts),
                    async (AddUserOptions opts) => await RunAddUser(opts),
                    _ => Task.FromResult(-1)); ;
        }

        private static async Task RunAddUser(AddUserOptions opts)
        {
            AddUserCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddContainer(AddContainerOptions opts)
        {
            AddContainerCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddAppointmentContainer(AddAppointmentContainerOptions opts)
        {
            AddAppointmentContainerCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddMessage(AddTransientMessageOptions opts)
        {
            AddTransientMessageCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddAppointment(AddAppointmentOptions opts)
        {
            AddAppointmentCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddResourceLiveLocationAndReturnExitCode(AddResourceLiveLocationOptions opts)
        {
            AddLiveResourceLocationCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddPin(AddPinOptions opts)
        {
            AddPinCommand cmd = new();
            await cmd.ProcessAsync(opts);
        }

        private static async Task RunAddTimeMarker(AddTimeMarkerOptions opts)
        {
            AddTimeMarkerCommand cmd = new();
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