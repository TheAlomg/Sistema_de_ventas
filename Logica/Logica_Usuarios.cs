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
    public class Logica_Usuarios
    {
        public static DataTable Listado_usuarios(string cTexto)
        {
            D_Usuarios datos = new D_Usuarios();
            return datos.Listado_us(cTexto);
        }
        public static string Guardar_usuarios(int nOpcion, E_Usuarios oUs)
        {
            D_Usuarios datos = new D_Usuarios();
            return datos.Guardar_us(nOpcion, oUs);
        }
        public static string Activo_Usuarios(int nCodigo_us)
        {
            D_Usuarios datos = new D_Usuarios();
            return datos.Activo_us(nCodigo_us);
        }
        public static DataTable listado_rolusuario()
        {
            D_Usuarios datos = new D_Usuarios();
            return datos.Listado_ru();
        }
    }
}
