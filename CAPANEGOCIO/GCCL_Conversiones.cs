using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
public class GCCL_Conversiones
    {
        MRP_BD cnn = new MRP_BD();
        private int codconversion;
        //private double factorconversion;
        public int CodConversion { get { return codconversion; } set { codconversion = value; } }
        public double Factorconversion { get; set; }
        public int CodTipoorigen { get; set; }
        public string NombreOrigen { get; set; }
        public int CodTipodestino { get; set; }
        public string NombreDestino { get; set; }
        public List<GCCL_Conversiones> Listado_Conversiones()
        {
            List<GCCL_Conversiones> lista = new List<GCCL_Conversiones>();
            DataTable tablas = cnn.getSQL("select conv.*, "+
            "tu.idtipounidad 'idtipounidadorigen', tu.descripcion 'descripcionorigen', "+
            "tu2.idtipounidad 'idtipounidaddestino', tu2.descripcion 'descripciondestino' "+ 
             "from CONVERSION conv " +
             "inner join TIPOUNIDAD tu on conv.unidadorigen = tu.idtipounidad inner "+
             "join TIPOUNIDAD tu2 on conv.unidaddestino = tu2.idtipounidad");
            GCCL_Conversiones conv;
            foreach (DataRow fila in tablas.Rows)
            {
                conv = new GCCL_Conversiones();
                conv.CodConversion= Convert.ToInt32(fila["idconversion"].ToString());
                conv.Factorconversion = Convert.ToDouble(fila["factorconversion"].ToString());                
                conv.CodTipoorigen = Convert.ToInt32(fila["idtipounidadorigen"].ToString());
                conv.NombreOrigen= fila["descripcionorigen"].ToString();
                conv.CodTipodestino = Convert.ToInt32(fila["idtipounidaddestino"].ToString());
                conv.NombreDestino = fila["descripciondestino"].ToString();                
                lista.Add(conv);
            }
            return lista;
        }

        public GCCL_Conversiones Devolver_Conversion(string codigo)
        {
            DataTable datoconv = new DataTable();
            GCCL_Conversiones conv = new GCCL_Conversiones();
            datoconv = cnn.getSQL("select conv.*, " +
            "tu.idtipounidad 'idtipounidadorigen', tu.descripcion 'descripcionorigen', " +
            "tu2.idtipounidad 'idtipounidaddestino', tu2.descripcion 'descripciondestino' " +
             "from CONVERSION conv " +
             "inner join TIPOUNIDAD tu on conv.unidadorigen = tu.idtipounidad inner " +
             "join TIPOUNIDAD tu2 on conv.unidaddestino = tu2.idtipounidad where conv.idconversion='"+codigo+"'");

            if (datoconv.Rows.Count == 1)
            {
                conv = new GCCL_Conversiones();
                conv.CodConversion = Convert.ToInt32(datoconv.Rows[0]["idconversion"].ToString());
                conv.Factorconversion = Convert.ToDouble(datoconv.Rows[0]["factorconversion"].ToString());
                conv.CodTipoorigen= Convert.ToInt32(datoconv.Rows[0]["idtipounidadorigen"].ToString());
                conv.NombreOrigen = (datoconv.Rows[0]["descripcionorigen"].ToString());
                conv.CodTipodestino = Convert.ToInt32(datoconv.Rows[0]["idtipounidaddestino"].ToString());
                conv.NombreDestino = (datoconv.Rows[0]["descripciondestino"].ToString());
            }
            else conv = null;
            return conv;
        }


        public double Devolver_ConversionOrigen_Y_Destino(string codigoorigen, string codigodestino)
        {
            DataTable datoconv = new DataTable();
            GCCL_Conversiones conv = new GCCL_Conversiones();
            datoconv = cnn.getSQL("select factorconversion from CONVERSION where unidadorigen ='"+codigoorigen+"' and unidaddestino='"+ codigodestino+ "'");
            double factor = 0;
            if (datoconv.Rows.Count == 1)
            {
                factor = Convert.ToDouble(datoconv.Rows[0]["factorconversion"].ToString());
            }
            else factor = 0;
            return factor;
        }


        public void Insertar_Conversion(GCCL_Conversiones conv)
        {
            String cadena = "Insert into CONVERSION(factorconversion , unidadorigen,unidaddestino) values('" + conv.Factorconversion + "','" + conv.CodTipoorigen + "','" + conv.CodTipodestino + "')";
            cnn.insertSQL(cadena);
        }
        public void Editar_Conversion(GCCL_Conversiones conv)
        {   
            string cadena = "UPDATE CONVERSION SET factorconversion='" + conv.Factorconversion + "', unidadorigen='" + conv.CodTipoorigen +"', unidaddestino='"+ conv.CodTipodestino + "' where idconversion='"+ conv.CodConversion +"'";
            cnn.updateSQL(cadena);
        }
        public void Eliminar_Conversion(GCCL_Conversiones conv)
        {
            String cadena = "delete CONVERSION where idconversion='"+ conv.codconversion +"'";
        }

    }



}
