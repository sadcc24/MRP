using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class GLCL_RecetarioDetalle
    {
        MRP_BD cnn = new MRP_BD();

        public int IdDetRecetario { get; set; }
        public int IdEncRecetario { get; set; }
        public  int codProducto { get; set; }
        public String nombreProducto { get; set; }
        public double CantidadProducto { get; set; }
        public double CostoProducto { get; set; }
        public double Nombre { get; set;        }
        public double Descripcion { get; set; }



        public List<GLCL_RecetarioDetalle> Listado_Recetario_Detalle(int codigoRecetarioEnc,int codigoEmpresa)
        {
            List<GLCL_RecetarioDetalle> lista = new List<GLCL_RecetarioDetalle>();
            DataTable tablas = cnn.getSQL("select R.* from RECETARIO r inner join EMPRESA emp on r.idempresa=emp.idempresa where emp.id_empresa='" + codigoEmpresa + "'");
            GLCL_RecetarioDetalle detrecetario;
            foreach (DataRow fila in tablas.Rows)
            {
                detrecetario = new GLCL_RecetarioDetalle();
                detrecetario.IdDetRecetario = Convert.ToInt32(fila["idrecetario"].ToString());
                //detrecetario.FechaCreacion = Convert.ToDateTime(fila["fechacreacion"].ToString());
                //detrecetario.NombreRecetario = fila["nombre"].ToString();
                //detrecetario.DescripcionRecetario = fila["descripcion"].ToString();
                //detrecetario.TotalCantidadProducto = Convert.ToDouble(fila["totalcantidad"].ToString());
                //detrecetario.AuxCodEmpresa = Convert.ToInt32(fila["idempresa"].ToString());
                //detrecetario.TotalCostoRecetario = Convert.ToDouble(fila["costototalrecetario"].ToString());
                lista.Add(detrecetario);
            }
            return lista;
        }













    }
}
