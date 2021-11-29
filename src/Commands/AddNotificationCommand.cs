using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddNotificationCommand : ICommand<AddNotificationOptions>
    {
        public async Task ProcessAsync(AddNotificationOptions options)
        {
            try
            {
                Console.WriteLine($"Adding notification.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Notification notification = new()
                {
                    AppointmentGuid = options.AppointmentGuid,
                    AppointmentId = options.AppointmentId,
                    Code = options.Code,
                    ConnectorId = options.ConnectorId,
                    Date = options.Date,
                    JobNo = options.JobNo,
                    SentFromBackOffice = options.SentFromBackOffice,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TaskNo = options.TaskNo,
                    Text = options.Text,
                    Type = options.Type
                };

                ImportSet result = await importEndpoint.ProcessAsync(notification, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}