using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dime.Scheduler.CLI.Commands;

namespace Dime.Scheduler.CLI
{
    public class CommandList : Dictionary<Type, Func<object, Task>>
    {
        public CommandList()
        {
            Add(typeof(AddTimeMarkerOptions), RunCommand<AddTimeMarkerCommand, AddTimeMarkerOptions>);
            Add(typeof(AddPinOptions), RunCommand<AddPinCommand, AddPinOptions>);
            Add(typeof(AddCategoryOptions), RunCommand<AddCategoryCommand, AddCategoryOptions>);
            Add(typeof(AddAppointmentOptions), RunCommand<AddAppointmentCommand, AddAppointmentOptions>);
            Add(typeof(AddTransientMessageOptions), RunCommand<AddTransientMessageCommand, AddTransientMessageOptions>);
            Add(typeof(AddResourceLiveLocationOptions), RunCommand<AddLiveResourceLocationCommand, AddResourceLiveLocationOptions>);
            Add(typeof(AddContainerOptions), RunCommand<AddContainerCommand, AddContainerOptions>);
            Add(typeof(AddAppointmentContainerOptions), RunCommand<AddAppointmentContainerCommand, AddAppointmentContainerOptions>);
            Add(typeof(AddUserOptions), RunCommand<AddUserCommand, AddUserOptions>);
            Add(typeof(AddJobOptions), RunCommand<AddJobCommand, AddJobOptions>);
        }

        private static Task RunCommand<TCommand, TOptions>(object opts)
            where TCommand : ICommand<TOptions>, new()
            where TOptions : class
        {
            ICommand<TOptions> command = new TCommand();
            return command.ProcessAsync(opts as TOptions);
        }
    }
}