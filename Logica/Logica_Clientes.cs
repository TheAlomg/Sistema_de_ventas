using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Clientes
    {
        public static DataTable Listado_clientes(string cTexto)
        {
            D_Clientes datos = new D_Clientes();
            return datos.Listado_cl(cTexto);
        }
        public static string Guardar_clientes(int nOpcion, E_Clientes oCl)
        {
            D_Clientes datos = new D_Clientes();
            return datos.Guardar_cl(nOpcion, oCl);
        }
        public static string Activo_clientes(int nCodigo_cl)
        {
            D_Clientes datos = new D_Clientes();
            return datos.Activo_cl(nCodigo_cl);
        }
        public static DataTable listado_usuarios()
        {
            D_Clientes datos = new D_Clientes();
            return datos.Listado_us();
        }
    }
}
