using System.Data.Entity;

namespace ExamenPIV.Data
{
    public class ExamenIPivContext: DbContext
    {
        public ExamenIPivContext() { }
        public ExamenIPivContext(string connectionName):base(connectionName)
        {

        }
    }
}
