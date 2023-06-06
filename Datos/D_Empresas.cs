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
    public class D_Empresas
    {
        public DataTable Listado_em(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_em", SqlCon);
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
        public string Guardar_em(int nOpcion, E_Empresa oEm)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_em", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_em", MySqlDbType.Int32).Value = oEm.Codigo_em;
                Comando.Parameters.Add("cNombre_em", MySqlDbType.VarChar).Value = oEm.Nombre_em;
                Comando.Parameters.Add("cNdocumento_em", MySqlDbType.VarChar).Value = oEm.Ndocumento_em;
                Comando.Parameters.Add("cDireccion_em", MySqlDbType.VarChar).Value = oEm.Direccion_em;
                Comando.Parameters.Add("cTelefono_em", MySqlDbType.VarChar).Value = oEm.Telefono_em;
                Comando.Parameters.Add("cCorreo_em", MySqlDbType.VarChar).Value = oEm.Correo_em;
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
        public string Activo_em(int nCodigo_em)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_activo_em", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_em", MySqlDbType.Int32).Value = nCodigo_em;
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
