using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    public interface IImportConvertable
    {
        IImportRequestable ToImport();
    }
}