using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskUriCommand : ICommand<AddTaskUriOptions>
    {
        public async t.Task ProcessAsync(AddTaskUriOptions options)
        {
            try
            {
                Console.WriteLine($"Adding task URI for job {options.JobNo} with number {options.TaskNo}.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                TaskUri taskUri = new()
                {
                    Description = options.Description,
                    JobNo = options.JobNo,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TaskNo = options.TaskNo,
                    Uri = options.Uri
                };

                ImportSet result = await importEndpoint.ProcessAsync(taskUri, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}