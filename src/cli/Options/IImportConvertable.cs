using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    public interface IImportConvertable
    {
        IImportRequestable ToImport();
    }
}