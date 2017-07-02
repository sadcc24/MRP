using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    class ProductosGenerales_MP
    {
        MRP_BD cnn = new MRP_BD();
        private int idproducto;
        private string nombreproducto;
        private string descripcionproducto;
        public int CodProducto { get { return idproducto; } set { idproducto = value; } }
        public string NombreProducto { get { return nombreproducto; } set { descripcionproducto = value; } }
        public string DescripcionProducto { get { return descripcionproducto; } set { descripcionproducto = value; } }


        public List<ProductosGenerales_MP> Listado_ProductosMP()
        {
            List<ProductosGenerales_MP> lista = new List<ProductosGenerales_MP>();
            DataTable tablas = cnn.getSQL("select * from Cliente");
            ProductosGenerales_MP prod;
            foreach (DataRow fila in tablas.Rows)
            {
                prod = new ProductosGenerales_MP();
                prod.CodProducto = Convert.ToInt32(fila["CODIGO"].ToString());
                prod.NombreProducto = fila["NOMBRE"].ToString();
                prod.DescripcionProducto = fila["DIRECCION"].ToString();
                lista.Add(prod);
            }
            return lista;
        }

        public ProductosGenerales_MP Devolver_ProductoMP(string codigo) {

            DataTable dprod = new DataTable();
            ProductosGenerales_MP producto = new ProductosGenerales_MP();
            dprod = cnn.getSQL("");
            if (dprod.Rows.Count== 0)
            {
                producto.CodProducto =Convert.ToInt32(dprod.Rows[0][""].ToString()) ;
                producto.DescripcionProducto=dprod.Rows[0][""].ToString();
                producto.NombreProducto= producto.DescripcionProducto = dprod.Rows[0][""].ToString();
            }
            else producto = null;

            return producto;
        }


    }
}
