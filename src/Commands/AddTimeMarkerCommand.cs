using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTimeMarkerCommand : ICommand<AddTimeMarkerOptions>
    {
        public async Task ProcessAsync(AddTimeMarkerOptions options)
        {
            try
            {
                Console.WriteLine($"Adding time marker with name {options.Name} and color {options.Color}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                TimeMarker timeMarker = new()
                {
                    Color = options.Color,
                    Name = options.Name
                };

                ImportSet result = await importEndpoint.ProcessAsync(timeMarker, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}