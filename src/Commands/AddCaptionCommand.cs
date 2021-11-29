using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddCaptionCommand : ICommand<AddCaptionOptions>
    {
        public async Task ProcessAsync(AddCaptionOptions options)
        {
            try
            {
                Console.WriteLine($"Adding caption in context {options.Context} with field {options.FieldName} and value {options.Text} in language {options.Language}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Caption caption = new()
                {
                    Context = options.Context,
                    FieldName = options.FieldName,
                    Language = options.Language,
                    SourceTable = options.SourceTable,
                    Text = options.Text
                };

                ImportSet result = await importEndpoint.ProcessAsync(caption, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}