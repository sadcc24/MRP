using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class GCCL_UnidadMedida
    {
        MRP_BD cnn = new MRP_BD();
        private int idtipounidad;
        private string nombreunidad;
        private string descripcionmedida;
        public int Codunidad { get { return idtipounidad; } set { idtipounidad = value; } }
        public string NombreUnidad { get { return nombreunidad; } set { nombreunidad = value; } }
        public string Descripcion { get { return descripcionmedida; } set { descripcionmedida = value; } }
        public List<GCCL_UnidadMedida> Listado_UnidadMedidas()
        {
            List<GCCL_UnidadMedida> lista = new List<GCCL_UnidadMedida>();
            DataTable tablas = cnn.getSQL("select * from UNIDADMEDIDA");
            GCCL_UnidadMedida tipounidad;
            foreach (DataRow fila in tablas.Rows)
            {
                tipounidad = new GCCL_UnidadMedida();
                tipounidad.Codunidad = Convert.ToInt32(fila["idunidadmedida"].ToString());
                tipounidad.NombreUnidad = fila["nombre"].ToString();
                tipounidad.Descripcion = fila["descripcion"].ToString();
                lista.Add(tipounidad);
            }
            return lista;
        }

        public GCCL_UnidadMedida Devolver_TipoUnidad(string codigo)
        {
            DataTable dunidad = new DataTable();
            GCCL_UnidadMedida tipounidad = new GCCL_UnidadMedida();
            dunidad = cnn.getSQL("select *from UNIDADMEDIDA WHERE idunidadmedida="+ codigo);
            if (dunidad.Rows.Count == 0)
            {
                tipounidad.Codunidad = Convert.ToInt32(dunidad.Rows[0]["idunidadmedida"].ToString());
                tipounidad.NombreUnidad = dunidad.Rows[0]["nombre"].ToString();
                tipounidad.Descripcion = dunidad.Rows[0]["descripcion"].ToString();
            }
            else tipounidad = null;
            return tipounidad;
        }

        public void Insertar_TipoUnidad(GCCL_UnidadMedida tipounidad)
        {
            String cadena = "Insert into UNIDADMEDIDA(nombre, descripcion, idtipounidad) values('" + tipounidad.NombreUnidad + "','" + tipounidad.Descripcion + "',1)";
            cnn.insertSQL(cadena);            
        }
        public void Editar_TipoUnidad(GCCL_UnidadMedida tipounidad)
        {
            String cadena = "update UNIDADMEDIDA set nombre='"+tipounidad.NombreUnidad+"', descripcion='"+tipounidad.Descripcion+"' where idunidadmedida ="+tipounidad.Codunidad;
            cnn.updateSQL(cadena);
        }
        public void Eliminar_TipoUnidad(GCCL_UnidadMedida tipounidad)
        {
            string cadena = "delete UNIDADMEDIDA where idunidadmedida=" + tipounidad.Codunidad ;
            cnn.deleteSQL(cadena);

        }


    }
}
