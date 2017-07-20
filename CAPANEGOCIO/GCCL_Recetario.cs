using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    class GLCL_Recetario
    {
        MRP_BD cnn = new MRP_BD();
        private int idrecetario;
        private DateTime fechacreacion;
        private string nombre;
        private string descripcion;
        private double totalcantidad;
        private Double costototalrecetario;
        private int auxcodempresa;
        
        public int IdRecetario
        {
            get
            {
                return idrecetario;
            }

            set
            {
                idrecetario = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechacreacion;
            }

            set
            {
                fechacreacion = value;
            }
        }

        public string NombreRecetario
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string DescripcionRecetario
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public double TotalCantidadProducto
        {
            get
            {
                return totalcantidad;
            }

            set
            {
                totalcantidad = value;
            }
        }

        public double TotalCostoRecetario
        {
            get
            {
                return costototalrecetario;
            }

            set
            {
                costototalrecetario = value;
            }

        }

        public int AuxCodEmpresa
        {
            get
            {
                return auxcodempresa;
            }

            set
            {
                auxcodempresa = value;
            }
        }

        public List<GLCL_Recetario> Listado_Recetarios(int codigoEmpresa)
        {
            List<GLCL_Recetario> lista = new List<GLCL_Recetario>();
            DataTable tablas = cnn.getSQL("select R.* from RECETARIO r inner join EMPRESA emp on r.idempresa=emp.idempresa where emp.id_empresa='"+codigoEmpresa +"'");
            GLCL_Recetario recetario;
            foreach (DataRow fila in tablas.Rows)
            {
                recetario = new GLCL_Recetario();
                recetario.IdRecetario = Convert.ToInt32(fila["idrecetario"].ToString());
                recetario.FechaCreacion =Convert.ToDateTime( fila["fechacreacion"].ToString() );
                recetario.NombreRecetario = fila["nombre"].ToString();
                recetario.DescripcionRecetario= fila["descripcion"].ToString();
                recetario.TotalCantidadProducto= Convert.ToDouble( fila["totalcantidad"].ToString());
                recetario.AuxCodEmpresa = Convert.ToInt32(fila["idempresa"].ToString());
                recetario.TotalCostoRecetario= Convert.ToDouble(fila["costototalrecetario"].ToString());
                lista.Add(recetario);
            }
            return lista;
        }

        public GLCL_Recetario Devolver_Recetario(int codigoRecetario,int codigoempresa)
        {
            DataTable dunidad = new DataTable();
            GLCL_Recetario recetario = new GLCL_Recetario();
            dunidad = cnn.getSQL("select * from RECETARIO WHERE idrecetario='" + codigoRecetario + "' and idempresa='"+ codigoempresa+"'");
            if (dunidad.Rows.Count == 0)
            {
                recetario = new GLCL_Recetario();
                recetario.IdRecetario = Convert.ToInt32(dunidad.Rows[0]["idrecetario"].ToString());
                recetario.FechaCreacion = Convert.ToDateTime(dunidad.Rows[0]["fechacreacion"].ToString());
                recetario.NombreRecetario = dunidad.Rows[0]["nombre"].ToString();
                recetario.DescripcionRecetario = dunidad.Rows[0]["descripcion"].ToString();
                recetario.TotalCantidadProducto = Convert.ToDouble(dunidad.Rows[0]["totalcantidad"].ToString());
                recetario.AuxCodEmpresa= Convert.ToInt32(dunidad.Rows[0]["idempresa"].ToString());
                recetario.TotalCostoRecetario = Convert.ToDouble(dunidad.Rows[0]["costototalrecetario"].ToString());                
            }
            else recetario = null;
            return recetario;
        }

        public void Insertar_Recetario(GLCL_Recetario recet)
        {
            String cadena = "Insert into RECETARIO(fechacreacion, nombre, descripcion, totalcantidad, idempresa, costototalrecetario) "+
                "values ('" + recet.FechaCreacion + "','" + recet.NombreRecetario + "','" + recet.DescripcionRecetario + "','"+recet.TotalCantidadProducto +"','"+recet.AuxCodEmpresa+"','"+recet.TotalCostoRecetario+"')";
            cnn.insertSQL(cadena);
        }
        public void Editar_Recetario(GLCL_Recetario recet)
        {
            String cadena = "update RECETARIO set nombre='"+recet.NombreRecetario+"', descripcion='"+recet.DescripcionRecetario+"', totalcantidad='"+recet.TotalCantidadProducto+"',costototalrecetario='"+recet.TotalCostoRecetario+"'";
            cnn.updateSQL(cadena);
        }
        public void Eliminar_Recetario(GLCL_Recetario recet)
        {
            String cadena = "delete RECETARIO where idrecetario='"+recet.IdRecetario +"' and idempresa='"+recet.AuxCodEmpresa+"' ";
            cnn.deleteSQL(cadena);
        }









    }//fin de clase
    } //fin de namespace
