using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class ProductosGenerales_MP
    {
        MRP_BD cnn = new MRP_BD();
        private int idproducto;
        private string nombreproducto;
        private string descripcionproducto;
        public int CodProducto { get { return idproducto; } set { idproducto = value; } }
        public string NombreProducto { get { return nombreproducto; } set { nombreproducto = value; } }
        public string DescripcionProducto { get { return descripcionproducto; } set { descripcionproducto = value; } }


        public List<ProductosGenerales_MP> Listado_ProductosMP()
        {
            List<ProductosGenerales_MP> lista = new List<ProductosGenerales_MP>();
            DataTable tablas = cnn.getSQL("select * from PRODUCTO");
            ProductosGenerales_MP prod;
            foreach (DataRow fila in tablas.Rows)
            {
                prod = new ProductosGenerales_MP();
                prod.CodProducto = Convert.ToInt32(fila["idproducto"].ToString());
                prod.NombreProducto = fila["descripcion"].ToString();
                prod.DescripcionProducto = fila["descripcion"].ToString();
                lista.Add(prod);
            }
            return lista;
        }

        public ProductosGenerales_MP Devolver_ProductoMP(string codigo) {

            DataTable dprod = new DataTable();
            ProductosGenerales_MP producto = new ProductosGenerales_MP();
            dprod = cnn.getSQL("select * from PRODUCTO where idproducto"+ codigo);
            if (dprod.Rows.Count== 0)
            {
                producto.CodProducto =Convert.ToInt32(dprod.Rows[0]["idproducto"].ToString()) ;
                producto.DescripcionProducto=dprod.Rows[0]["descripcion"].ToString();
                producto.NombreProducto= producto.DescripcionProducto = dprod.Rows[0]["descripcion"].ToString();
            }
            else producto = null;

            return producto;
        }


    }
}
