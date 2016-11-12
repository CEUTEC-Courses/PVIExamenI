using System.Data.Entity;

namespace ExamenPIV.Data
{
    public class ProyectoPivContext: DbContext
    {
        public ProyectoPivContext() { }
        public ProyectoPivContext(string connectionName):base(connectionName)
        {

        }
    }
}
