using MySql.Data.MySqlClient;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Clientes
    {
        public DataTable Listado_cl(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Listado_us()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_uscl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Guardar_cl(int nOpcion, E_Clientes oCl)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_cl", MySqlDbType.Int32).Value = oCl.Codigo_cl;
                Comando.Parameters.Add("cNombre_cl", MySqlDbType.VarChar).Value = oCl.Nombre_cl;
                Comando.Parameters.Add("cDocumento_cl", MySqlDbType.VarChar).Value = oCl.Documento_cl;
                Comando.Parameters.Add("cDireccion_cl", MySqlDbType.VarChar).Value = oCl.Direccion_cl;
                Comando.Parameters.Add("cTelefono_cl", MySqlDbType.VarChar).Value = oCl.Telefono_cl;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = oCl.Codigo_us;
                MySqlParameter parCodigo = new MySqlParameter();
                parCodigo.ParameterName = "nCodigo_ou";
                parCodigo.MySqlDbType = MySqlDbType.Int32;
                parCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(parCodigo);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parCodigo.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Activo_cl(int nCodigo_cl)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_activo_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_cl", MySqlDbType.Int32).Value = nCodigo_cl;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se realizo el proceso";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
