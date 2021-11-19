using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentContainer", HelpText = "Adds an appointment container.")]
    public class AddAppointmentContainerOptions : BaseOptions
    {
        [Option('a', "appointment", Required = true)]
        public string Appointment { get; set; }

        [Option('o', "container", Required = true)]
        public string Container { get; set; }
    }
}