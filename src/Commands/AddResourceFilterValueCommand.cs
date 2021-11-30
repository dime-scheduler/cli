using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceFilterValueCommand : ICommand<AddResourceFilterValueOptions>
    {
        public async Task ProcessAsync(AddResourceFilterValueOptions options)
        {
            try
            {
                Console.WriteLine($"Creates a resource filter value.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ResourceFilterValue resourceFilterValue = new()
                {
                    FilterGroup = options.FilterGroup,
                    FilterValue = options.FilterValue,
                    ResourceNo = options.ResourceNo,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TransferToTemp = options.TransferToTemp
                };

                ImportSet result = await importEndpoint.ProcessAsync(resourceFilterValue, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}