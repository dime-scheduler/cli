using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.DotNetTool.Commands
{
    public class AddCategoryCommand : ICommand<AddCategoryOptions>
    {
        public async Task ProcessAsync(AddCategoryOptions options)
        {
            try
            {
                Console.WriteLine($"Adding category with name {options.Name} and color {options.Color}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Category category = new()
                {
                    Color = options.Color,
                    DisplayName = options.Name,
                    Name = options.Name
                };

                ImportSet result = await importEndpoint.ProcessAsync(category, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}