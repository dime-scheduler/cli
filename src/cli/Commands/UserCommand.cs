using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class UserCommand : ICommand<UserOptions>
    {
        public async Task ProcessAsync(UserOptions options)
        {
            try
            {
                Console.WriteLine($"Adding user with e-mail {options.Email}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                ICrudEndpoint<UserRequest> usersEndpoint = await client.Users.Request();
                UserRequest user = new()
                {
                    Email = options.Email,
                    Password = options.Password,
                    Language = options.Language,
                    TimeZone = options.TimeZone,
                    Type = options.Type
                };

                await usersEndpoint.Create(user);
                Console.WriteLine("Finished successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}