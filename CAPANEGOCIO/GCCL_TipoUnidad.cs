using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPANEGOCIO
{
    public class GCCL_TipoUnidad
    {

        MRP_BD cnn = new MRP_BD();
        private int idtipounidad;
        private string descripcion;
        private string simbolounidad;
        

        //private GLCL_Tipocategoria cat=new GLCL_Tipocategoria();
        public int Codunidad { get { return idtipounidad; } set { idtipounidad = value; } }
        public string DescripcionTipounidad { get { return descripcion; } set { descripcion = value; } }
        public string SimboloUnidad { get { return simbolounidad; } set { simbolounidad = value; } }
        public int auxCodCategoria { get; set; }
        public string auxNombreCategoria { get; set; }


        public List<GCCL_TipoUnidad> Listado_TipoUnidad()
        {
            List<GCCL_TipoUnidad> lista = new List<GCCL_TipoUnidad>();
            DataTable tablas = cnn.getSQL("select TU.idtipounidad, TU.descripcion 'desc_unidad', TU.simbolo, TC.tipo, TC.descripcion 'desc_categoria' from TIPOUNIDAD TU inner join TIPOCATEGORIA TC ON TU.tipo=TC.tipo");
            GCCL_TipoUnidad tipounidad;
            foreach (DataRow fila in tablas.Rows)
            {
                tipounidad = new GCCL_TipoUnidad();
                tipounidad.Codunidad = Convert.ToInt32(fila["idtipounidad"].ToString());
                tipounidad.DescripcionTipounidad = fila["desc_unidad"].ToString();
                tipounidad.SimboloUnidad = fila["simbolo"].ToString();
                tipounidad.auxCodCategoria =Convert.ToInt32( fila["tipo"].ToString());
                tipounidad.auxNombreCategoria= fila["desc_categoria"].ToString();
                lista.Add(tipounidad);
            }
            return lista;
        }

        public GCCL_TipoUnidad Devolver_TipoUnidad(string codigo)
        {
            DataTable dunidad = new DataTable();
            GCCL_TipoUnidad tipounidad = new GCCL_TipoUnidad();
            dunidad = cnn.getSQL("select * from TIPOUNIDAD WHERE idtipounidad='"+ codigo +"'");
            if (dunidad.Rows.Count == 0)
            {
                tipounidad.Codunidad = Convert.ToInt32(dunidad.Rows[0]["idtipounidad"].ToString());
                tipounidad.DescripcionTipounidad = dunidad.Rows[0]["descripcion"].ToString();
                tipounidad.SimboloUnidad  = dunidad.Rows[0]["simbolo"].ToString();
            }
            else tipounidad = null;
            return tipounidad;
        }

        public void Insertar_TipoUnidad(GCCL_TipoUnidad tipounidad)
        {
          String cadena = "Insert into TIPOUNIDAD(descripcion , simbolo, tipo) values('" + tipounidad.DescripcionTipounidad + "','" + tipounidad.SimboloUnidad + "','" + tipounidad.auxCodCategoria+ "')";
          cnn.insertSQL(cadena);          
        }
        public void Editar_TipoUnidad(GCCL_TipoUnidad tipounidad)
        {
            String cadena = "update TIPOUNIDAD set descripcion='"+tipounidad.DescripcionTipounidad+"', simbolo='"+tipounidad.SimboloUnidad+"', tipo='"+tipounidad.auxCodCategoria+"' where idtipounidad='"+tipounidad.Codunidad+"'";
            cnn.updateSQL(cadena);

        }
        public void Eliminar_TipoUnidad(GCCL_TipoUnidad tipounidad)
        {
            String cadena = "delete TIPOUNIDAD where idtipounidad='" + tipounidad.Codunidad + "'";
        }
         
    }
}
