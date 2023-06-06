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
    public class D_Proveedores
    {
        public DataTable Listado_po(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_po", SqlCon);
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
                MySqlCommand Comando = new MySqlCommand("USP_Listado_uspo", SqlCon);
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
        public string Guardar_po(int nOpcion, E_Proveedores oPo)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_po", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_po", MySqlDbType.Int32).Value = oPo.Codigo_po;
                Comando.Parameters.Add("cNombre_po", MySqlDbType.VarChar).Value = oPo.Nombre_po;
                Comando.Parameters.Add("cNdocumento_po", MySqlDbType.VarChar).Value = oPo.Ndocumento_po;
                Comando.Parameters.Add("cDireccion_po", MySqlDbType.VarChar).Value = oPo.Direccion_po;
                Comando.Parameters.Add("cTelefono_po", MySqlDbType.VarChar).Value = oPo.Telefono_po;
                Comando.Parameters.Add("cContacto_po", MySqlDbType.VarChar).Value = oPo.Contacto_po;
                Comando.Parameters.Add("cCorreo_po", MySqlDbType.VarChar).Value = oPo.Correo_po;
                Comando.Parameters.Add("cBanco_po", MySqlDbType.VarChar).Value = oPo.Banco_po;
                Comando.Parameters.Add("cNcuenta_po", MySqlDbType.VarChar).Value = oPo.Ncuenta_po;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = oPo.Codigo_us;
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
        public string Eliminar_po(int nCodigo_po)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Eliminar_po", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_po", MySqlDbType.Int32).Value = nCodigo_po;
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
