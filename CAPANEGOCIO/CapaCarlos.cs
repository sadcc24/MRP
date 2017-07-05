﻿using System;
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

// CONEXION A CAPA DE DATOS
        MRP_BD conexionCarlos = new MRP_BD();
        private DataTable dt = null;

//INICIA PRORRATEO

// BUSCAR EN PRORRATEO
        public DataTable buscarProrrateo(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL(" SELECT D.idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E,  (SELECT SUM(totalMP) totalMP, idrecetario FROM (select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND D.idordenproduccion = '" + buscarId + "' AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// CONSULTAR EN PRORRATEO
        public DataTable consultaProrrateo()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL(" SELECT D.idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// ULTIMO ID DE PRODUCCION
        public DataTable consultaMax()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT MAX(D.idordenproduccion) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// PRIMER ID DE PRODUCCION
        public DataTable consultaMin()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT MIN(D.idordenproduccion) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// SIGUIENTE ID DE PRODUCCION * PROBANDO
        public DataTable consultaSiguiente()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT (D.idordenproduccion+1) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// ANTERIOR ID DE PRODUCCION * PROBANDO
        public DataTable consultaAnterior()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT (D.idordenproduccion-1) as idordenproduccion, D.fechacreacion, SUM(A.gastofabricacion * C.cantidad) as gastototalGF, (TABLA2.totalMP * C.cantidad) as gastototalMP, (E.costo * C.cantidad) as gastototalMO, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) as costoprimo, (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))) as factorX, (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as gastosprorrateados, ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)))) as costodeproducciontotal, C.cantidad as cantidadproducida, ((((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) + (((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad)) * (SUM(A.gastofabricacion * C.cantidad) / ((E.costo * C.cantidad) + (TABLA2.totalMP * C.cantidad))))) / C.cantidad) as Costounitario FROM RECETARIOGASTO A, RECETARIO B, DETORDENPROD C, ORDENPRODUCCION D, DETALLEMOUNO E, (SELECT SUM(totalMP) totalMP, idrecetario FROM(select  A.precio, C.cantidad, B.idrecetario, (A.precio * C.cantidad) as totalMP FROM PRODUCTO A, RECETARIO B, DETALLERECETARIO C WHERE B.idrecetario = C.idrecetario AND A.idproducto = C.idproducto) TABLA GROUP BY idrecetario) TABLA2 WHERE A.idrecetario = B.idrecetario AND B.idrecetario = C.idrecetario AND C.idordenproduccion = D.idordenproduccion AND D.idordenproduccion = E.idordenproduccion AND B.idrecetario = TABLA2.idrecetario group by D.idordenproduccion, D.fechacreacion, TABLA2.totalMP, E.costo, C.cantidad");
            return dt;
        }
// TERMINA PRORRATEO


// INICIA GASTOS
// CONSULTA GASTOS
        public DataTable consultaGastos()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto");
            return dt;
        }
// LIMPIA TEXTO
        public String limpiarGasto(String text)
        {
            return "";
        }
// INSERTA REGISTRO
        public void insertarGasto(String text1, String text2, String text3)
        {
            conexionCarlos.insertSQL("insert into [dbo].[RECETARIOGASTO] (idrecetario,idgasto,gastofabricacion) values ('" + text1+ "','" + text2+ "','" + text3 + "')");
        }
// ELIMINA REGISTRO
        public void eliminarGasto(String text1, String text2)
        {
            conexionCarlos.deleteSQL("delete recetariogasto where idrecetario ='" + text1 + "' and idgasto = '" + text2 + "'");
        }
// ACTUALIZA REGISTRO
        public void actualizarGasto(String text1, String text2, String text3)
        {
            conexionCarlos.updateSQL ("update recetariogasto set gastofabricacion = '" + text1 + "' where idrecetario = '" + text2 + "' and idgasto = '" + text3 +"'");
        }
// TERMINA GASTOS




    }
}
