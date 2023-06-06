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
    public class D_Productos
    {
        public DataTable Listado_pr(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_pr", SqlCon);
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
        public DataTable Listado_popr()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_prpo", SqlCon);
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
        public string Guardar_pr(int nOpcion, E_Productos oPr)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_pr", MySqlDbType.Int32).Value = oPr.Codigo_pr;
                Comando.Parameters.Add("cNombre_pr", MySqlDbType.VarChar).Value = oPr.Nombre_pr;
                Comando.Parameters.Add("cDescripcion_pr", MySqlDbType.VarChar).Value = oPr.Descripcion_pr;
                Comando.Parameters.Add("nCodigo_po", MySqlDbType.VarChar).Value = oPr.Codigo_po;
                Comando.Parameters.Add("nCodigo_me", MySqlDbType.VarChar).Value = oPr.Codigo_me;
                Comando.Parameters.Add("cAbreviatura_me", MySqlDbType.VarChar).Value = oPr.Abreviatura_me;
                Comando.Parameters.Add("cDescripcion_me", MySqlDbType.VarChar).Value = oPr.Descripcion_me;
                Comando.Parameters.Add("nPrecioUnitario_pr", MySqlDbType.VarChar).Value = oPr.PrecioUnitario_pr;
                Comando.Parameters.Add("nStock", MySqlDbType.Int32).Value = oPr.Stock;
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
        public string Eliminar_pr(int nCodigo_pr)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearconexcion();
                MySqlCommand Comando = new MySqlCommand("USP_Eliminar_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_pr", MySqlDbType.Int32).Value = nCodigo_pr;
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
