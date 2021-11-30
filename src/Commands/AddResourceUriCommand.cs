using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceUriCommand : ICommand<AddResourceUriOptions>
    {
        public async Task ProcessAsync(AddResourceUriOptions options)
        {
            try
            {
                Console.WriteLine($"Creates a resource URI.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ResourceUri resourceUri = new()
                {
                    Description = options.Description,
                    ResourceNo = options.ResourceNo,
                    Uri = options.Link
                };

                ImportSet result = await importEndpoint.ProcessAsync(resourceUri, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}