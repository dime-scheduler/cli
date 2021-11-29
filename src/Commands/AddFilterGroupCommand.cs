using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddFilterGroupCommand : ICommand<AddFilterGroupOptions>
    {
        public async Task ProcessAsync(AddFilterGroupOptions options)
        {
            try
            {
                Console.WriteLine($"Adding filter group with name {options.Name}.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                FilterGroup filterGroup = new()
                {
                    ColumnNo = options.ColumnNo,
                    DataFilter = options.DataFilter,
                    Id = options.Id,
                    Name = options.Name
                };

                ImportSet result = await importEndpoint.ProcessAsync(filterGroup, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}