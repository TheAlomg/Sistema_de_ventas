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
    public class Logica_Proveedores
    {
        public static DataTable Listado_proveedores(string cTexto)
        {
            D_Proveedores datos = new D_Proveedores();
            return datos.Listado_po(cTexto);
        }
        public static string Guardar_proveedores(int nOpcion, E_Proveedores oPo)
        {
            D_Proveedores datos = new D_Proveedores();
            return datos.Guardar_po(nOpcion, oPo);
        }
        public static string Eliminar_Proveedores(int nCodigo_po)
        {
            D_Proveedores datos = new D_Proveedores();
            return datos.Eliminar_po(nCodigo_po);
        }
        public static DataTable listado_Usuarios()
        {
            D_Proveedores datos = new D_Proveedores();
            return datos.Listado_us();
        }
    }
}
