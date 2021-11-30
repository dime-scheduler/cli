using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCalendarCommand : ICommand<AddResourceCalendarOptions>
    {
        public async Task ProcessAsync(AddResourceCalendarOptions options)
        {
            try
            {
                Console.WriteLine($"Assigns a calendar to the requested resource.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ResourceCalendar resourceCalendar = new()
                {
                    CalendarCode = options.CalendarCode,
                    Code = options.Code,
                    EndDate = options.EndDate,
                    ResourceNo = options.ResourceNo,
                    StartDate = options.StartDate
                };

                ImportSet result = await importEndpoint.ProcessAsync(resourceCalendar, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}