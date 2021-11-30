using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentContainer", HelpText = "Adds an appointment container.")]
    public class AddAppointmentContainerOptions : BaseOptions, IImportConvertable
    {
        [Option('a', "appointment", Required = true)]
        public string Appointment { get; set; }

        [Option('o', "container", Required = true)]
        public string Container { get; set; }

        public IImportRequestable ToImport() => (AppointmentContainer)this;

        public static implicit operator AppointmentContainer(AddAppointmentContainerOptions options)
            => new()
            {
                Appointment = options.Appointment,
                Container = options.Container
            };
    }
}