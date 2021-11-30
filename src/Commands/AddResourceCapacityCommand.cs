using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCapacityCommand : ICommand<AddResourceCapacityOptions>
    {
        public async Task ProcessAsync(AddResourceCapacityOptions options)
        {
            try
            {
                Console.WriteLine($"Adds a capacity entry for the requested resource.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ResourceCapacity resourceCapacity = new()
                {
                    CapacityInSeconds = options.CapacityInSeconds,
                    Date = options.Date,
                    Quantity = options.Quantity,
                    ResourceNo = options.ResourceNo,
                    UnitOfMeasure = options.UnitOfMeasure,
                    UnitOfMeasureConversion = options.UnitOfMeasureConversion
                };

                ImportSet result = await importEndpoint.ProcessAsync(resourceCapacity, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}