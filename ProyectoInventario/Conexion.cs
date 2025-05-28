using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario
{
    public static class Conexion
    {
        private static string cadena = "Server=tcp:berserkers3.database.windows.net,1433;" +
                                       "Initial Catalog=InventarioDB;" +
                                       "Persist Security Info=False;" +
                                       "User ID=roberto;" +
                                       "Password=Rr123456789;" +
                                       "MultipleActiveResultSets=False;" +
                                       "Encrypt=True;" +
                                       "TrustServerCertificate=False;" +
                                       "Connection Timeout=30;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
