using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddFilterValueCommand : ICommand<AddFilterValueOptions>
    {
        public async Task ProcessAsync(AddFilterValueOptions options)
        {
            try
            {
                Console.WriteLine($"Adding filter value for group {options.Group} and value {options.Value}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                FilterValue filterValue = new()
                {
                    Group = options.Group,
                    Value = options.Value
                };

                ImportSet result = await importEndpoint.ProcessAsync(filterValue, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}