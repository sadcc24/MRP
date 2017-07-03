using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAPANEGOCIO
{
    public class TipoUnidad
    {

        MRP_BD cnn = new MRP_BD();
        private int idtipounidad;
        private string nombreunidad;
        private string simbolounidad;
        public int Codunidad { get { return idtipounidad; } set { idtipounidad = value; } }
        public string NombreUnidad { get { return nombreunidad; } set { nombreunidad = value; } }
        public string SimboloUnidad { get { return simbolounidad; } set { simbolounidad = value; } }
        public List<TipoUnidad> Listado_TipoUnidades()
        {
            List<TipoUnidad> lista = new List<TipoUnidad>();
            DataTable tablas = cnn.getSQL("select * from TIPOUNIDAD");
            TipoUnidad tipounidad;
            foreach (DataRow fila in tablas.Rows)
            {
                tipounidad = new TipoUnidad();
                tipounidad.Codunidad = Convert.ToInt32(fila["idtipounidad"].ToString());
                tipounidad.NombreUnidad = fila["descripcion"].ToString();
                tipounidad.SimboloUnidad = fila["simbolo"].ToString();
                lista.Add(tipounidad);
            }
            return lista;
        }

        public TipoUnidad Devolver_TipoUnidad(string codigo)
        {
            DataTable dunidad = new DataTable();
            TipoUnidad tipounidad = new TipoUnidad();
            dunidad = cnn.getSQL("");
            if (dunidad.Rows.Count == 0)
            {
                tipounidad.Codunidad = Convert.ToInt32(dunidad.Rows[0]["idtipounidad"].ToString());
                tipounidad.NombreUnidad = dunidad.Rows[0]["descirpcion"].ToString();
                tipounidad.SimboloUnidad  = dunidad.Rows[0]["simbolo"].ToString();
            }
            else tipounidad = null;
            return tipounidad;
        }

        public void Insertar_TipoUnidad(TipoUnidad tipounidad)
        {
            //String cadena = "Insert into Cliente(NOMBRE, DIRECCION, TELEFONO) values('" + Var_Cliente.Nombre + "','" + Var_Cliente.Direccion + "','" + Var_Cliente.Telefono + "')";
            //cnn.insertSQL(cadena);
            //MessageBox.Show("Usuario Registrado");
        }
        public void Editar_TipoUnidad(TipoUnidad tipounidad)
        {


        }
        public void Eliminar_TipoUnidad(TipoUnidad tipounidad)
        {

        }        
    }
}
