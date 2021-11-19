using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddContainerCommand : ICommand<AddContainerOptions>
    {
        public async Task ProcessAsync(AddContainerOptions options)
        {
            try
            {
                Console.WriteLine("Adding container");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint endpoint = await client.Import.Request();

                Container container = new()
                {
                    HandleDate = options.HandleDate,
                    HandleLocked = options.HandleLocked,
                    Name = options.Name
                };

                await endpoint.ProcessAsync(container, TransactionType.Append);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}