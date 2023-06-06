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
    public class Logica_Empresas
    {
        public static DataTable Listado_empresas(string cTexto)
        {
            D_Empresas datos = new D_Empresas();
            return datos.Listado_em(cTexto);
        }
        public static string Guardar_empresas(int nOpcion, E_Empresa oEm)
        {
            D_Empresas datos = new D_Empresas();
            return datos.Guardar_em(nOpcion, oEm);
        }
        public static string Activo_cl(int nCodigo_em)
        {
            D_Clientes datos = new D_Clientes();
            return datos.Activo_cl(nCodigo_em);
        }
    }
}
