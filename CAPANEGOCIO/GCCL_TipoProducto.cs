using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    class TipoProducto
    {
        MRP_BD cnn = new MRP_BD();
        private Boolean activo;
        private int codigotipoproducto;
        private string descripciontipoproducto;

        public bool ActivoTipoProducto { get { return activo; } set { activo = value; } }
        public int CodTipoProducto { get { return codigotipoproducto; } set { codigotipoproducto = value; } }
        public string DescTipoProducto { get { return descripciontipoproducto; } set { descripciontipoproducto = value; } }

        public List<TipoProducto> Listado_TipoUnidades()
        {
            List<TipoProducto> lista = new List<TipoProducto>();
            DataTable tablas = cnn.getSQL("select * from Cliente");
            TipoProducto tipoproducto;
            foreach (DataRow fila in tablas.Rows)
            {
                tipoproducto = new TipoProducto();
                tipoproducto.CodTipoProducto = Convert.ToInt32(fila[""].ToString());
                tipoproducto.ActivoTipoProducto = Convert.ToBoolean(fila[""].ToString());
                tipoproducto.DescTipoProducto = fila[""].ToString();                
                lista.Add(tipoproducto);
            }
            return lista;
        }
        public TipoProducto Devolver_TipoProducto(string codigo)
        {
            DataTable dunidad = new DataTable();
            TipoProducto tipoproducto = new TipoProducto();
            dunidad = cnn.getSQL("");
            if (dunidad.Rows.Count == 0)
            {

                tipoproducto.CodTipoProducto = Convert.ToInt32(dunidad.Rows[0][""].ToString());
                tipoproducto.ActivoTipoProducto = Convert.ToBoolean( dunidad.Rows[0][""].ToString());
                tipoproducto.DescTipoProducto = dunidad.Rows[0][""].ToString();                
            }
            else tipoproducto = null;
            return tipoproducto;
        }
    }
}
