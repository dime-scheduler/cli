using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class TransientMessageCommand : ICommand<TransientMessageOptions>
    {
        public async Task ProcessAsync(TransientMessageOptions options)
        {
            try
            {
                Console.WriteLine("Adding transient message");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IMessageEndpoint endpoint = await client.Messages.Request();

                MessageRequest message = new()
                {
                    Severity = options.Severity,
                    Text = options.Text,
                    User = options.To
                };

                await endpoint.PostAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}