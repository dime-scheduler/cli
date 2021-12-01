using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    public interface IImportConvertable
    {
        IImportRequestable ToImport();
    }
}