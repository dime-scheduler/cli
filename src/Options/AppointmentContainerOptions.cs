using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentcontainer", HelpText = "Add or remove an appointment container.")]
    public class AppointmentContainerOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The appointment's identifier.")]
        public string Appointment { get; set; }

        [Option(Required = true, HelpText = "The container's identifier.")]
        public string Container { get; set; }

        public IImportRequestable ToImport() => (AppointmentContainer)this;

        public static implicit operator AppointmentContainer(AppointmentContainerOptions options)
            => new()
            {
                Appointment = options.Appointment,
                Container = options.Container
            };
    }
}