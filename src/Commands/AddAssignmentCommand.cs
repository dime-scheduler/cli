using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAssignmentCommand : ICommand<AddAssignmentOptions>
    {
        public async Task ProcessAsync(AddAssignmentOptions options)
        {
            try
            {
                Console.WriteLine($"Adding assignment.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Assignment assignment = new()
                {
                    AppointmentGuid = options.AppointmentGuid,
                    AppointmentId = options.AppointmentId,
                    ResourceNo = options.ResourceNo,
                    SentFromBackOffice = options.SentFromBackOffice,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType
                };

                ImportSet result = await importEndpoint.ProcessAsync(assignment, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}