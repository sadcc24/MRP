using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class MPRCL_Empresa
    {
        MRP_BD cnn = new MRP_BD();
        private int codigoempresa;
        private string nombreempresa;
        public int CodigoEmpresa
        {
            get
            {
                return codigoempresa;
            }

            set
            {
                codigoempresa = value;
            }
        }

        public String NombreEmpresa
        {
            get
            {
                return nombreempresa;
            }

            set
            {
                nombreempresa = value;
            }
        }

        public List<MPRCL_Empresa> ListadoEmpresas()
        {
            List<MPRCL_Empresa> lista = new List<MPRCL_Empresa>();
            DataTable tablas = cnn.getSQL("select * from Empresa");
            MPRCL_Empresa empresa;
            foreach (DataRow fila in tablas.Rows)
            {
                empresa = new MPRCL_Empresa();
                empresa.CodigoEmpresa = Convert.ToInt32(fila["idempresa"].ToString());
                empresa.NombreEmpresa = fila["nombre_empresa"].ToString();             
                lista.Add(empresa);
            }
            return lista;
        }

        public MPRCL_Empresa Devolver_Empresa(int codigo)
        {
            DataTable dunidad = new DataTable();
            MPRCL_Empresa emp;
            dunidad = cnn.getSQL("select *from Empresa where idempresa="+ codigo);
            if (dunidad.Rows.Count == 0)
            {
                emp =  new MPRCL_Empresa();
                emp.CodigoEmpresa = Convert.ToInt32(dunidad.Rows[0][""].ToString());
                emp.NombreEmpresa =dunidad.Rows[0][""].ToString();
                
            }
            else emp = null;
            return emp;
        }





    }
}
