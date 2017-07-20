using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class GCCL_ProductosGenerales_MP
    {
        MRP_BD cnn = new MRP_BD();
        private int idproducto;
        //private string nombreproducto;
        private string descripcionproducto;
        public int CodProducto { get { return idproducto; } set { idproducto = value; } }
        //public string NombreProducto { get { return nombreproducto; } set { nombreproducto = value; } }
        public string DescripcionProducto { get { return descripcionproducto; } set { descripcionproducto = value; } }
        public int CodUnidadMedida { get; set; }
        public string SimboloUnidadmedida { get; set; }
        public double Costoproducto { get; set; }
        

        //SIRVE PARA BUSCAR TODOS LOS PRODUCTOS
        public List<GCCL_ProductosGenerales_MP> Listado_ProductosMP(string codEmpresa)
        {
            List<GCCL_ProductosGenerales_MP> lista = new List<GCCL_ProductosGenerales_MP>();
            DataTable tablas = cnn.getSQL("select prod.idproducto, prod.idtipoproducto, prod.descripcion, prod.costo, " +
            "tu.idtipounidad, tu.simbolo from PRODUCTO prod " +
            "inner join TIPOUNIDAD tu on prod.unidadpeso = tu.idtipounidad ");
            GCCL_ProductosGenerales_MP prod;
            foreach (DataRow fila in tablas.Rows)
            {
                prod = new GCCL_ProductosGenerales_MP();
                prod.CodProducto = Convert.ToInt32(fila["idproducto"].ToString());                
                prod.DescripcionProducto = fila["descripcion"].ToString();
                prod.CodUnidadMedida=Convert.ToInt32( fila["idtipounidad"].ToString() );
                prod.SimboloUnidadmedida =fila["simbolo"].ToString();
                prod.Costoproducto =Convert.ToDouble( fila["costo"].ToString() );        

                lista.Add(prod);
            }
            return lista;
        }
        //SIRVE PARA BUSCAR TODOS LOS PRODUCTOS POR PARAMETROS
        public List<GCCL_ProductosGenerales_MP> Listado_ProductosMP(string codEmpresa, string parambusqueda,string tipobusqueda)
        {
            List<GCCL_ProductosGenerales_MP> lista = new List<GCCL_ProductosGenerales_MP>();
            DataTable tablas =new DataTable();
            if (tipobusqueda == "Nombre") {
                tablas = cnn.getSQL("select prod.idproducto,  prod.idtipoproducto, prod.descripcion, prod.costo, " +
            "tu.idtipounidad, tu.simbolo from PRODUCTO prod " +
            "inner join TIPOUNIDAD tu on prod.unidadpeso = tu.idtipounidad where idempresa='" + codEmpresa + "' and descripcion like '%" + parambusqueda.ToString() + "%'");
            }
            else if(tipobusqueda == "Codigo"){
                tablas = cnn.getSQL("select   prod.idproducto, prod.idtipoproducto, prod.descripcion, prod.costo, " +
            "tu.idtipounidad, tu.simbolo " +
            "inner join TIPOUNIDAD tu on prod.unidadpeso = tu.idtipounidad from PRODUCTO where idempresa='" + codEmpresa + "' and idproducto='" + parambusqueda.ToString() + "'");
            }
            GCCL_ProductosGenerales_MP prod;
            foreach (DataRow fila in tablas.Rows)
            {
                prod = new GCCL_ProductosGenerales_MP();
                prod.CodProducto = Convert.ToInt32(fila["idproducto"].ToString());
                prod.DescripcionProducto = fila["descripcion"].ToString();
                prod.CodUnidadMedida = Convert.ToInt32(fila["idtipounidad"].ToString());
                prod.SimboloUnidadmedida = fila["simbolo"].ToString();
                prod.Costoproducto = Convert.ToDouble(fila["costo"].ToString());

                lista.Add(prod);
            }
            return lista;
        }
        
        //DEVUELVE UN UNICO PRODUCTO
        public GCCL_ProductosGenerales_MP Devolver_ProductoMP(string codigo,MPRCL_Empresa empresa) {

            DataTable dprod = new DataTable();
            GCCL_ProductosGenerales_MP producto = new GCCL_ProductosGenerales_MP();
            dprod = cnn.getSQL("select prod.idproducto ,prod.idtipoproducto, prod.descripcion, prod.costo, " +
            "tu.idtipounidad, tu.simbolo from PRODUCTO prod " +
            "inner join TIPOUNIDAD tu on prod.unidadpeso = tu.idtipounidad where idproducto=" + codigo+" and idempresa='"+empresa.CodigoEmpresa+"'");
            if (dprod.Rows.Count== 1)
            {                
                producto.CodProducto = Convert.ToInt32(dprod.Rows[0]["idproducto"].ToString());
                producto.DescripcionProducto = dprod.Rows[0]["descripcion"].ToString();
                producto.CodUnidadMedida = Convert.ToInt32(dprod.Rows[0]["idtipounidad"].ToString());
                producto.SimboloUnidadmedida = dprod.Rows[0]["simbolo"].ToString();
                producto.Costoproducto = Convert.ToDouble(dprod.Rows[0]["costo"].ToString());
            }
            else producto = null;

            return producto;
        }

    }
}
