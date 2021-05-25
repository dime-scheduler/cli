using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.DotNetTool.Commands
{
    public class AddAppointmentContainerCommand : ICommand<AddAppointmentContainerOptions>
    {
        public async Task ProcessAsync(AddAppointmentContainerOptions options)
        {
            try
            {
                Console.WriteLine("Adding appointment container");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint endpoint = await client.Import.Request();

                AppointmentContainer container = new()
                {
                    Appointment = options.Appointment,
                    Container = options.Container
                };

                await endpoint.ProcessAsync(container, TransactionType.Append);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}