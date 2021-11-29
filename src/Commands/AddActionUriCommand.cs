using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddActionUriCommand : ICommand<AddActionUriOptions>
    {
        public async Task ProcessAsync(AddActionUriOptions options)
        {
            try
            {
                Console.WriteLine($"Adding action URI.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ActionUri actionUri = new()
                {
                    Default = options.Default,
                    Description = options.Description,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    Uri = options.Uri,
                    UriType = options.UriType
                };

                ImportSet result = await importEndpoint.ProcessAsync(actionUri, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}