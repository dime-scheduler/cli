using System;
using System.Globalization;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.DotNetTool.Commands
{
    public class AddLiveResourceLocationCommand : ICommand<AddResourceLiveLocationOptions>
    {
        public async Task ProcessAsync(AddResourceLiveLocationOptions options)
        {
            try
            {
                Console.WriteLine($"Adding live location for resource number {options.ResourceNo} " +
                                  $"with coordinates {options.Latitude} {options.Longitude}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                ResourceGpsTracking resourceGpsTracking = new()
                {
                    ResourceNo = options.ResourceNo,
                    Latitude = decimal.Parse(options.Latitude, CultureInfo.InvariantCulture),
                    Longitude = decimal.Parse(options.Longitude, CultureInfo.InvariantCulture)
                };

                ImportSet result = await importEndpoint.ProcessAsync(resourceGpsTracking, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}