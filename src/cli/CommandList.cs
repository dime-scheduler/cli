using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dime.Scheduler.CLI.Commands;
using Dime.Scheduler.CLI.Options;

namespace Dime.Scheduler.CLI
{
    public class CommandList : Dictionary<Type, Func<object, Task>>
    {
        public CommandList()
        {
            AddCommand<ActionUriCommand, ActionUriOptions>();
            AddCommand<AppointmentCategoryCommand, AppointmentCategoryOptions>();
            AddCommand<AppointmentCommand, AppointmentOptions>();
            AddCommand<AppointmentContainerCommand, AppointmentContainerOptions>();
            AddCommand<AppointmentContentCommand, AppointmentContentOptions>();
            AddCommand<AppointmentImportanceCommand, AppointmentImportanceOptions>();
            AddCommand<AppointmentLockedCommand, AppointmentLockedOptions>();
            AddCommand<AppointmentPlanningQuantityCommand, AppointmentPlanningQuantityOptions>();
            AddCommand<AppointmentTimeMarkerCommand, AppointmentTimeMarkerOptions>();
            AddCommand<AppointmentUriCommand, AppointmentUriOptions>();
            AddCommand<AssignmentCommand, AssignmentOptions>();
            AddCommand<CaptionCommand, CaptionOptions>();
            AddCommand<CategoryCommand, CategoryOptions>();
            AddCommand<ContainerCommand, ContainerOptions>();
            AddCommand<FilterGroupCommand, FilterGroupOptions>();
            AddCommand<FilterValueCommand, FilterValueOptions>();
            AddCommand<JobCommand, JobOptions>();
            AddCommand<LiveResourceLocationCommand, ResourceLiveLocationOptions>();
            AddCommand<NotificationCommand, NotificationOptions>();
            AddCommand<PinCommand, PinOptions>();
            AddCommand<ResourceCalendarCommand, ResourceCalendarOptions>();
            AddCommand<ResourceCapacityCommand, ResourceCapacityOptions>();
            AddCommand<ResourceCommand, ResourceOptions>();
            AddCommand<ResourceFilterValueCommand, ResourceFilterValueOptions>();
            AddCommand<ResourceUriCommand, ResourceUriOptions>();
            AddCommand<TaskCommand, TaskOptions>();
            AddCommand<TaskContainerCommand, TaskContainerOptions>();
            AddCommand<TaskFilterValueCommand, TaskFilterValueOptions>();
            AddCommand<TaskLockedCommand, TaskLockedOptions>();
            AddCommand<TaskUriCommand, TaskUriOptions>();
            AddCommand<TimeMarkerCommand, TimeMarkerOptions>();
            AddCommand<TransientMessageCommand, TransientMessageOptions>();
            AddCommand<UserCommand, UserOptions>();
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