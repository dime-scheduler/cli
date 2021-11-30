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
            AddCommand<AddTimeMarkerCommand, AddTimeMarkerOptions>();
            AddCommand<AddPinCommand, AddPinOptions>();
            AddCommand<AddCategoryCommand, AddCategoryOptions>();
            AddCommand<AddAppointmentCommand, AddAppointmentOptions>();
            AddCommand<AddTransientMessageCommand, AddTransientMessageOptions>();
            AddCommand<AddLiveResourceLocationCommand, AddResourceLiveLocationOptions>();
            AddCommand<AddContainerCommand, AddContainerOptions>();
            AddCommand<AddAppointmentContainerCommand, AddAppointmentContainerOptions>();
            AddCommand<AddUserCommand, AddUserOptions>();
            AddCommand<AddJobCommand, AddJobOptions>();
            AddCommand<AddTaskCommand, AddTaskOptions>();
            AddCommand<AddNotificationCommand, AddNotificationOptions>();
            AddCommand<AddFilterGroupCommand, AddFilterGroupOptions>();
            AddCommand<AddFilterValueCommand, AddFilterValueOptions>();
            AddCommand<AddCaptionCommand, AddCaptionOptions>();
            AddCommand<AddResourceCommand, AddResourceOptions>();
            AddCommand<AddActionUriCommand, AddActionUriOptions>();
            AddCommand<AddAssignmentCommand, AddAssignmentOptions>();
            AddCommand<AddTaskFilterValueCommand, AddTaskFilterValueOptions>();
            AddCommand<AddTaskLockedCommand, AddTaskLockedOptions>();
            AddCommand<AddTaskUriCommand, AddTaskUriOptions>();
            AddCommand<AddAppointmentCategoryCommand, AddAppointmentCategoryOptions>();
            AddCommand<AddAppointmentContentCommand, AddAppointmentContentOptions>();
            AddCommand<AddAppointmentImportanceCommand, AddAppointmentImportanceOptions>();
            AddCommand<AddAppointmentPlanningQuantityCommand, AddAppointmentPlanningQuantityOptions>();
            AddCommand<AddAppointmentTimeMarkerCommand, AddAppointmentTimeMarkerOptions>();
            AddCommand<AddAppointmentUriCommand, AddAppointmentUriOptions>();
            AddCommand<AddAppointmentLockedCommand, AddAppointmentLockedOptions>();
        }

        private void AddCommand<TCommand, TOptions>()
            where TCommand : ICommand<TOptions>, new()
            where TOptions : class
            => Add(typeof(TOptions), RunCommand<TCommand, TOptions>);

        private static Task RunCommand<TCommand, TOptions>(object opts)
            where TCommand : ICommand<TOptions>, new()
            where TOptions : class
        {
            ICommand<TOptions> command = new TCommand();
            return command.ProcessAsync(opts as TOptions);
        }
    }
}