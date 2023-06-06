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
    public class Logica_Productos
    {
        public static DataTable Listado_productos(string cTexto)
        {
            D_Productos datos = new D_Productos();
            return datos.Listado_pr(cTexto);
        }
        public static string Guardar_productos(int nOpcion, E_Productos oPr)
        {
            D_Productos datos = new D_Productos();
            return datos.Guardar_pr(nOpcion, oPr);
        }
        public static string Eliminar_Productos(int nCodigo_pr)
        {
            D_Productos datos = new D_Productos();
            return datos.Eliminar_pr(nCodigo_pr);
        }
        public static DataTable listado_Proveedores()
        {
            D_Productos datos = new D_Productos();
            return datos.Listado_popr();
        }
    }
}
