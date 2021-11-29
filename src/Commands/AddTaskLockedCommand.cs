using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskLockedCommand : ICommand<AddTaskLockedOptions>
    {
        public async t.Task ProcessAsync(AddTaskLockedOptions options)
        {
            try
            {
                Console.WriteLine($"Locking or unlocking task with job {options.JobNo} with number {options.TaskNo}.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                TaskLocked taskLocked = new()
                {
                    JobNo = options.JobNo,
                    Locked = options.Locked,
                    SentFromBackOffice = options.SentFromBackOffice,
                    SourceApp = options.SourceApp,
                    SourceType =options.SourceType,
                    TaskNo = options.TaskNo
                };

                ImportSet result = await importEndpoint.ProcessAsync(taskLocked, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}