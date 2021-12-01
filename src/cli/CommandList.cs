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
            AddCommand<TimeMarkerCommand, TimeMarkerOptions>();
            AddCommand<PinCommand, PinOptions>();
            AddCommand<CategoryCommand, CategoryOptions>();
            AddCommand<AppointmentCommand, AppointmentOptions>();
            AddCommand<TransientMessageCommand, TransientMessageOptions>();
            AddCommand<LiveResourceLocationCommand, ResourceLiveLocationOptions>();
            AddCommand<ContainerCommand, ContainerOptions>();
            AddCommand<AppointmentContainerCommand, AppointmentContainerOptions>();
            AddCommand<UserCommand, UserOptions>();
            AddCommand<JobCommand, JobOptions>();
            AddCommand<TaskCommand, TaskOptions>();
            AddCommand<NotificationCommand, NotificationOptions>();
            AddCommand<FilterGroupCommand, FilterGroupOptions>();
            AddCommand<FilterValueCommand, FilterValueOptions>();
            AddCommand<CaptionCommand, CaptionOptions>();
            AddCommand<ResourceCommand, ResourceOptions>();
            AddCommand<ActionUriCommand, ActionUriOptions>();
            AddCommand<AssignmentCommand, AssignmentOptions>();
            AddCommand<TaskFilterValueCommand, TaskFilterValueOptions>();
            AddCommand<TaskLockedCommand, TaskLockedOptions>();
            AddCommand<TaskUriCommand, TaskUriOptions>();
            AddCommand<AppointmentCategoryCommand, AppointmentCategoryOptions>();
            AddCommand<AppointmentContentCommand, AppointmentContentOptions>();
            AddCommand<AppointmentImportanceCommand, AppointmentImportanceOptions>();
            AddCommand<AppointmentPlanningQuantityCommand, AppointmentPlanningQuantityOptions>();
            AddCommand<AppointmentTimeMarkerCommand, AppointmentTimeMarkerOptions>();
            AddCommand<AppointmentUriCommand, AppointmentUriOptions>();
            AddCommand<AppointmentLockedCommand, AppointmentLockedOptions>();
            AddCommand<ResourceCalendarCommand, ResourceCalendarOptions>();
            AddCommand<ResourceCapacityCommand, ResourceCapacityOptions>();
            AddCommand<ResourceFilterValueCommand, ResourceFilterValueOptions>();
            AddCommand<ResourceUriCommand, ResourceUriOptions>();
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