using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class GLCL_Tipocategoria
    {
        MRP_BD cnn = new MRP_BD();
        private int tipo;
        private string descripcion;        
        public int Codtipo { get { return tipo; } set { tipo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        
        public List<GLCL_Tipocategoria> Listado_TipoCategoria()
        {
            List<GLCL_Tipocategoria> lista = new List<GLCL_Tipocategoria>();
            DataTable tablas = cnn.getSQL("select * from TIPOCATEGORIA");
            GLCL_Tipocategoria tipocat;
            foreach (DataRow fila in tablas.Rows)
            {
                tipocat = new GLCL_Tipocategoria();
                tipocat.Codtipo = Convert.ToInt32(fila["tipo"].ToString());
                tipocat.Descripcion = fila["descripcion"].ToString();                
                lista.Add(tipocat);
            }
            return lista;
        }

        public GLCL_Tipocategoria Devolver_Tipocategoria(string codigo)
        {
            DataTable dunidad = new DataTable();
            GLCL_Tipocategoria tipocat = new GLCL_Tipocategoria();
            dunidad = cnn.getSQL("select *from TIPOCATEGORIA WHERE idtipounidad='" + codigo + "'");
            if (dunidad.Rows.Count == 0)
            {
                tipocat.Codtipo = Convert.ToInt32(dunidad.Rows[0]["idtipounidad"].ToString());
                tipocat.Descripcion = dunidad.Rows[0]["descripcion"].ToString();
             }
            else tipocat = null;
            return tipocat;
        }

        public void Insertar_TipoCategoria(GLCL_Tipocategoria tipocat)
        {
            String cadena = "Insert into TIPOCATEGORIA(descripcion) values('" + tipocat.Descripcion + "')";
            cnn.insertSQL(cadena);            
        }
        public void Editar_TipoCategoria(GLCL_Tipocategoria tipocat)
        {
            String cadena = "update  TIPOCATEGORIA set descripcion='" + tipocat.Descripcion + "' where tipo='" + tipocat.Codtipo + "'";
            cnn.updateSQL(cadena);

        }
        public void Eliminar_TipoCategoria(GLCL_Tipocategoria tipocat)
        {
            String cadena = "delete TIPOCATEGORIA where tipo='"+tipocat.Codtipo+"' ";
            cnn.deleteSQL(cadena);
        }


    }
}
