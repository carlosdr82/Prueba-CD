using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace Dao
{
    public class ClienteDao : BaseDao
    {
        /// <summary>
        /// Metodo qu epermite obtener todos los clientes
        /// </summary>
        /// <returns>lista de clientes</returns>
        public List<CLIENTE> GetAll()
        {
            List<CLIENTE> listaCliente = new List<CLIENTE>();
            SqlConnection Conn = null;
            SqlCommand SqlCommand = null;

            try
            {
                using (Conn = new SqlConnection(GetConnectionString()))
                {
                    Conn.Open();
                    SqlCommand = new SqlCommand("SELECT * FROM CLIENTE", Conn);
                    using (SqlDataReader SqlDataReader = SqlCommand.ExecuteReader())
                    {
                        while (SqlDataReader.Read())
                        {
                            CLIENTE cliente = new CLIENTE();
                            cliente.ID = Convert.ToInt64(SqlDataReader["ID"]);
                            cliente.ID_TIPO_DOCUMENTO = Convert.ToInt32(SqlDataReader["ID_TIPO_DOCUMENTO"]);
                            cliente.NUMERO_DOCUMENTO = Convert.ToString(SqlDataReader["NUMERO_DOCUMENTO"]);
                            cliente.NOMBRE = Convert.ToString(SqlDataReader["NOMBRE"]);
                            cliente.CORREO = Convert.ToString(SqlDataReader["CORREO"]);
                            listaCliente.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }

            return listaCliente;
        }

        /// <summary>
        /// Obtiene el cliente por su identificador unico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CLIENTE GetById(long id)
        {
            CLIENTE cliente = new CLIENTE();
            SqlConnection Conn = null;
            SqlCommand SqlCommand = null;

            try
            {
                using (Conn = new SqlConnection(GetConnectionString()))
                {
                    Conn.Open();
                    SqlCommand = new SqlCommand("SELECT * FROM CLIENTE WHERE ID=@id", Conn);
                    SqlCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                    using (SqlDataReader SqlDataReader = SqlCommand.ExecuteReader())
                    {
                        if (SqlDataReader.Read())
                        {
                            cliente.ID = Convert.ToInt64(SqlDataReader["ID"]);
                            cliente.ID_TIPO_DOCUMENTO = Convert.ToInt32(SqlDataReader["ID_TIPO_DOCUMENTO"]);
                            cliente.NUMERO_DOCUMENTO = Convert.ToString(SqlDataReader["NUMERO_DOCUMENTO"]);
                            cliente.NOMBRE = Convert.ToString(SqlDataReader["NOMBRE"]);
                            cliente.CORREO = Convert.ToString(SqlDataReader["CORREO"]);
                        }
                           
                    }
                }
            }
            catch (Exception)
            {
            }

            return cliente;
        }


        /// <summary>
        /// Inserta un nuevo registro
        /// </summary>
        /// <param name="cliente"></param>
        public void Insert(CLIENTE cliente)
        {
            SqlConnection Conn = null;
            SqlCommand SqlCommand = null;

            try
            {
                using (Conn = new SqlConnection(GetConnectionString()))
                {
                    Conn.Open();
                    SqlCommand = new SqlCommand("INSERT INTO CLIENTE(ID_TIPO_DOCUMENTO,NUMERO_DOCUMENTO,NOMBRE,CORREO) VALUES(@idTipoDocumento,@numero,@nombre,@correo) ", Conn);
                    SqlCommand.Parameters.Add("@idTipoDocumento", SqlDbType.Int).Value = cliente.ID_TIPO_DOCUMENTO;
                    SqlCommand.Parameters.Add("@numero", SqlDbType.VarChar).Value = cliente.NUMERO_DOCUMENTO;
                    SqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.NOMBRE;
                    SqlCommand.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.CORREO;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
        }

        /// <summary>
        /// Actualiza un registro existente
        /// </summary>
        /// <param name="cliente"></param>
        public void Update(CLIENTE cliente)
        {
            SqlConnection Conn = null;
            SqlCommand SqlCommand = null;

            try
            {
                using (Conn = new SqlConnection(GetConnectionString()))
                {
                    Conn.Open();
                    SqlCommand = new SqlCommand("UPDATE CLIENTE SET ID_TIPO_DOCUMENTO=@idTipoDocumento,NUMERO_DOCUMENTO=@numero,NOMBRE=@nombre,CORREO=@correo WHERE ID=@id ", Conn);
                    SqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = cliente.ID;
                    SqlCommand.Parameters.Add("@idTipoDocumento", SqlDbType.Int).Value = cliente.ID_TIPO_DOCUMENTO;
                    SqlCommand.Parameters.Add("@numero", SqlDbType.VarChar).Value = cliente.NUMERO_DOCUMENTO;
                    SqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.NOMBRE;
                    SqlCommand.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.CORREO;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Elimina un registro por su id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            SqlConnection Conn = null;
            SqlCommand SqlCommand = null;

            try
            {
                using (Conn = new SqlConnection(GetConnectionString()))
                {
                    Conn.Open();
                    SqlCommand = new SqlCommand("DELETE FROM CLIENTE WHERE ID=@id", Conn);
                    SqlCommand.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                    SqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
