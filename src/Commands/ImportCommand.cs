using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public abstract class ImportCommand<TOptions, TImportable>
        where TOptions : BaseOptions, IImportConvertable
        where TImportable : class, IImportRequestable
    {
        protected abstract string WriteIntro(TOptions options);

        public async Task ProcessAsync(TOptions options)
        {
            try
            {
                Console.WriteLine(WriteIntro(options));

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);
                IImportEndpoint importEndpoint = await client.Import.Request();
                ImportSet result = await importEndpoint.ProcessAsync(options.ToImport(), TransactionType.Append);

                Console.WriteLine(result.Success ? "Completed successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}