using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPANEGOCIO
{
    class TipoUnidadMedida
    {

        MRP_BD cnn = new MRP_BD();
        private int idtipounidad;
        private string nombreunidad;
        private string simbolounidad;
        public int Codunidad { get { return idtipounidad; } set { idtipounidad = value; } }
        public string NombreUnidad { get { return nombreunidad; } set { nombreunidad = value; } }
        public string SimboloUnidad { get { return simbolounidad; } set { simbolounidad = value; } }
        public List<TipoUnidadMedida> Listado_TipoUnidades()
        {
            List<TipoUnidadMedida> lista = new List<TipoUnidadMedida>();
            DataTable tablas = cnn.getSQL("select * from Cliente");
            TipoUnidadMedida tipounidad;
            foreach (DataRow fila in tablas.Rows)
            {
                tipounidad = new TipoUnidadMedida();
                tipounidad.Codunidad = Convert.ToInt32(fila["CODIGO"].ToString());
                tipounidad.NombreUnidad = fila["NOMBRE"].ToString();
                tipounidad.SimboloUnidad = fila["DIRECCION"].ToString();
                lista.Add(tipounidad);
            }
            return lista;
        }

        public TipoUnidadMedida Devolver_TipoUnidad(string codigo)
        {
            DataTable dunidad = new DataTable();
            TipoUnidadMedida tipounidad = new TipoUnidadMedida();
            dunidad = cnn.getSQL("");
            if (dunidad.Rows.Count == 0)
            {
                tipounidad.Codunidad = Convert.ToInt32(dunidad.Rows[0][""].ToString());
                tipounidad.NombreUnidad = dunidad.Rows[0][""].ToString();
                tipounidad.SimboloUnidad  = dunidad.Rows[0][""].ToString();
            }
            else tipounidad = null;
            return tipounidad;
        }

        public void Insertar_TipoUnidad(TipoUnidadMedida tipounidad)
        {
            //String cadena = "Insert into Cliente(NOMBRE, DIRECCION, TELEFONO) values('" + Var_Cliente.Nombre + "','" + Var_Cliente.Direccion + "','" + Var_Cliente.Telefono + "')";
            //cnn.insertSQL(cadena);
            //MessageBox.Show("Usuario Registrado");
        }
        public void Editar_TipoUnidad(TipoUnidadMedida tipounidad)
        {


        }
        public void Eliminar_TipoUnidad(TipoUnidadMedida tipounidad)
        {

        }        
    }
}
