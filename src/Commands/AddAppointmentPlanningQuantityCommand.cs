using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentPlanningQuantityCommand : ICommand<AddAppointmentPlanningQuantityOptions>
    {
        public async Task ProcessAsync(AddAppointmentPlanningQuantityOptions options)
        {
            try
            {
                Console.WriteLine($"Locking or unlocking appointment.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                AppointmentPlanningQuantity appointmentPlanningQuantity = new()
                {
                };

                ImportSet result = await importEndpoint.ProcessAsync(appointmentPlanningQuantity, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}