using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class BaseDao
    {
        /// <summary>
        /// Metodo que permite obtener el string de conexión
        /// </summary>
        /// <returns>Cadena de conexión</returns>
        public string GetConnectionString()
        {
            string cnn = "";
            try
            {
                 cnn = ConfigurationManager.AppSettings["ConnectionString"];
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener cadena de conexión");
            }
            return cnn;
        }
    }
}
