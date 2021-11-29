using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskFilterValueCommand : ICommand<AddTaskFilterValueOptions>
    {
        public async t.Task ProcessAsync(AddTaskFilterValueOptions options)
        {
            try
            {
                Console.WriteLine($"Adding task filter value for job {options.JobNo} with number {options.TaskNo}.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                TaskFilterValue taskFilterValue = new()
                {
                    FilterGroup = options.FilterGroup,
                    FilterValue = options.FilterValue,
                    JobNo = options.JobNo,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TaskNo = options.TaskNo,
                    TransferToTemp = options.TransferToTemp
                };

                ImportSet result = await importEndpoint.ProcessAsync(taskFilterValue, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}