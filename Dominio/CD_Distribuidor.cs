using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;


namespace Dominio
{
    public class CD_Distribuidor
    {
        public CAD_Distribuidor objectoCAD = new CAD_Distribuidor();
        public DataTable Mostrardistribuidor()//creacion de tabla
        {
            DataTable tabla = new DataTable();//instanciando la tabla
            tabla = objectoCAD.Mostrar();
            return tabla;
        }
    }
}
