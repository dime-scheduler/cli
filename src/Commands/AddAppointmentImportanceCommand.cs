using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentImportanceCommand : ICommand<AddAppointmentImportanceOptions>
    {
        public async Task ProcessAsync(AddAppointmentImportanceOptions options)
        {
            try
            {
                Console.WriteLine($"Locking or unlocking appointment.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                AppointmentImportance appointmentImportance = new()
                {
                    AppointmentGuid = options.AppointmentGuid,
                    AppointmentId = options.AppointmentId,
                    Importance = options.Importance,
                    SentFromBackOffice = options.SentFromBackOffice,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType
                };

                ImportSet result = await importEndpoint.ProcessAsync(appointmentImportance, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}