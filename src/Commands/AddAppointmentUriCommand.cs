using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentUriCommand : ICommand<AddAppointmentUriOptions>
    {
        public async Task ProcessAsync(AddAppointmentUriOptions options)
        {
            try
            {
                Console.WriteLine($"Locking or unlocking appointment.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                AppointmentUri appointmentUri = new()
                {
                    AppointmentGuid = options.AppointmentGuid,
                    AppointmentId = options.AppointmentId,
                    Uri = options.Uri,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    Description = options.Description
                };

                ImportSet result = await importEndpoint.ProcessAsync(appointmentUri, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}