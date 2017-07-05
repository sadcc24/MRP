using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CAPANEGOCIO
{
    public class CapaCarlos
    {

        MRP_BD conexionCarlos = new MRP_BD();
        private DataTable dt = null;

//INICIA PRORRATEO

        public DataTable buscarProrrateo(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL(" SELECT D.idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E,  (SELECT SUM(totalMP) totalMP, idrecetario FROM (select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND D.idordenproduccion = '" + buscarId + "' AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }

        public DataTable consultaProrrateo()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL(" SELECT D.idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }

        public DataTable consultaMax()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT MAX(D.idordenproduccion) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
        public DataTable consultaMin()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT MIN(D.idordenproduccion) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }



// TERMINA PRORRATEO

// INICIA GASTOS



    }
}
