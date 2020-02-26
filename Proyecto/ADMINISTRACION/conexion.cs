using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADMINISTRACION
{
    class conexion
    {
        
        String cadena = "data source = femm.database.windows.net,1433; initial catalog = SistemaNotas; user id = Marvin; password = Fundamentos28";
        public SqlConnection conectar = new SqlConnection();
        public conexion()
        {
            conectar.ConnectionString=cadena;
        }
        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("conexion exitosa");
            }catch (Exception ex)
            {
                Console.WriteLine("Error conexion"+ex.Message);
            }
        }
        public void cerrar()
        {
            conectar.Close();
        }
    }
}
