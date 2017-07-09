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

// CONEXION A CAPA DE DATOS
        MRP_BD conexionCarlos = new MRP_BD();
        private DataTable dt = null;

//INICIA PRORRATEO

// BUSCAR EN PRORRATEO
        public DataTable buscarProrrateo(String buscarId)
        {
            dt = new DataTable(); 
            dt = conexionCarlos.getSQL("select D.idordenproduccion, sum(A.gastofabricacion * B.cantidad) as CostoFabricacion, sum(C.totalcantidad * B.cantidad) as MateriaPrima, sum(E.costo * B.cantidad) as ManoObra, (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))) as FactorX, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion  and D.idordenproduccion = '" + buscarId + "' group by D.idordenproduccion, B.cantidad order by D.idordenproduccion DESC");
            return dt;
        }
// CONSULTAR EN PRORRATEO
        public DataTable consultaProrrateo()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL(" select D.idordenproduccion, sum(A.gastofabricacion * B.cantidad) as CostoFabricacion, sum(C.totalcantidad * B.cantidad) as MateriaPrima, sum(E.costo * B.cantidad) as ManoObra, (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))) as FactorX, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion group by D.idordenproduccion, B.cantidad order by D.idordenproduccion DESC");
            return dt;
        }
// ULTIMO ID DE PRODUCCION
        public DataTable consultaMax()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select max(D.idordenproduccion) as idordenproduccion, sum(A.gastofabricacion * B.cantidad) as CostoFabricacion, sum(C.totalcantidad * B.cantidad) as MateriaPrima, sum(E.costo * B.cantidad) as ManoObra, (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))) as FactorX, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion group by D.idordenproduccion, B.cantidad order by D.idordenproduccion DESC");
            return dt;
        }
// PRIMER ID DE PRODUCCION
        public DataTable consultaMin()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select min(D.idordenproduccion) as idordenproduccion, sum(A.gastofabricacion * B.cantidad) as CostoFabricacion, sum(C.totalcantidad * B.cantidad) as MateriaPrima, sum(E.costo * B.cantidad) as ManoObra, (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))) as FactorX, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) + ((sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.totalcantidad * B.cantidad) + sum(E.costo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion group by D.idordenproduccion, B.cantidad order by D.idordenproduccion DESC");
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

// INSERTA EN PRORRATEO
        public void insertarProrrateo(String text1, String text2, String text3)
        {
            conexionCarlos.insertSQL("insert into existencia (idbodega,idproducto,cantidad) values ('" + text1 + "','" + text2 + "','" + text3 + "')");
        }
        // LIMPIA TEXTO
        public String limpiarProrrateo(String text)
        {
            return "";
        }

//FINALIZA PRORRATEO DE PRODUCTO
// TERMINA PRORRATEO


// INICIA GASTOS
// CONSULTA GASTOS
        public DataTable consultaGastos()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto");
            return dt;
        }
// BUSCA GASTOS
        public DataTable buscarGasto(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto and A.idrecetario = '" + buscarId + "'");
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


// INICIA TIPO GASTO (CP_gastoV2)
// CONSULTA TIPO GASTO
        public DataTable consultaTipoGasto()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT* FROM TIPOGASTO order by idgasto desc");
            return dt;
        }
// BUSCA TIPO GASTO
        public DataTable buscarTipoGasto(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from tipogasto where nombre like upper ('%" + buscarId + "%')");
            return dt;
        }
// LIMPIAR TIPO GASTO
        public String limpiarTipoGasto(String text)
        {
            return "";
        }
// ELIMINAR TIPO GASTO
        public void eliminarTipoGasto(String text1)
        {
            conexionCarlos.deleteSQL("delete tipogasto where idgasto = '" + text1 + "'");
        }
// GUARDA TIPO GASTO
        public void insertarTipoGasto(String text1, String text2, String text3)
        {
            String insert1 = "SET IDENTITY_INSERT tipogasto ON insert into tipogasto (idgasto,nombre,descripcion) values ('" + text1 + "','" + text2 + "','" + text3 + "') SET IDENTITY_INSERT tipogasto OFF ";
            conexionCarlos.insertSQL(insert1);
        }
// ACTUALIZA TIPO GASTO
        public void actualizarTipoGasto(String text1, String text2, String text3)
        {
            conexionCarlos.updateSQL("update tipogasto set nombre = '" + text1 + "', descripcion = '" + text2 + "' where idgasto ='" + text3 + "'");
        }
// TERMINA TIPO GASTO (CP_gastoV2)


// INICIA TIPO GASTO (CP_gastoV1)
        public DataTable consultaTipoGasto1()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select idrecetario, nombre, descripcion, fechacreacion from recetario order by idrecetario DESC");
            return dt;
        }
        public DataTable buscarTipoGasto1(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select idrecetario, nombre, descripcion, fechacreacion from recetario where nombre like upper ('%" + buscarId + "%')");
            return dt;
        }
// TERMINA TIPO GASTO (CP_gastoV2)

// COMIENZA PRORRATEO DE BODEGA
// CONSULTA DE PRORRATEO DE BODEGA
        public DataTable consultaProrrateoBodega()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from bodega order by idbodega desc");
            return dt;
        }
// BUSQUEDA DE BODEGA POR NOMBRE
        public DataTable buscarProrrateoBodega(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from bodega where nombre_bodega like upper ('%" + buscarId + "%')");
            return dt;
        }
// TERMINA PRORRATEO DE BODEGA


// INICIA PRORRATEO DE PRODUCTO
        public DataTable consultaProrrateoProducto()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from producto order by idproducto desc");
            return dt;
        }
// BUSCA POR DESCRIPCION
        public DataTable buscarProrrateoProducto1(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from producto where descripcion like upper ('%" + buscarId + "%')");
            return dt;
        }
//BUSCA POR ID
        public DataTable buscarProrrateoProducto2(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from producto where idproducto = (" + buscarId + ")");
            return dt;
        }
// TERMINA PRORRATEO PRODUCTO



// INICIA POLIZA

// BUSCA POR DESCRIPCION
        public DataTable buscarPoliza(String buscarId, String buscarId2)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select (sum(A.gastofabricacion* B.cantidad) + sum(E.costo)) as costomanufactura from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion and D.fechacreacion between('" + buscarId + "') and ('" + buscarId2 + "')  ");
            return dt;
        }
// INSERTA POLIZA
        public void insertarPoliza(String text1, String text2, String text3, String text4)
        {
            String insert1 = "insert into detallepoliza (idpoliza,idcuenta,clasificacion,valor) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "') ";
            conexionCarlos.insertSQL(insert1);
        }
// LIMPIA POLIZA
        public String limpiarPoliza(String text)
        {
            return "";
        }
// TERMINA POLIZA


// INICIA POLIZAPOLIZA
// CONSULTA POLIZAPOLIZA
        public DataTable consultaPolizaPoliza()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("SELECT* FROM poliza order by idpoliza desc");
            return dt;
        }
// BUSCA POLIZAPOLIZA
        public DataTable buscarPolizaPoliza(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from poliza where nombre like upper ('%" + buscarId + "%')");
            return dt;
        }
// LIMPIA POLIZAPOLIZA
        public String limpiarPolizaPoliza(String text)
        {
            return "";
        }
// ELIMINAR POLIZAPOLIZA
        public void eliminarPolizapoliza(String text1)
        {
            conexionCarlos.deleteSQL("delete poliza where idpoliza = '" + text1 + "'");
        }
// GUARDAR POLIZAPOLIZA
        public void insertarPolizapoliza(String text1, String text2, String text3, String text4, String text5, String text6)
        {
            String insert1 = "SET IDENTITY_INSERT poliza ON insert into poliza (idpoliza,nombre,descripcion,fecha,idempresa,stat) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "') SET IDENTITY_INSERT poliza OFF ";
            conexionCarlos.insertSQL(insert1);
        }
// ACTUALIZAPOLIZAPOLIZA
        public void actualizarPolizapoliza(String text1, String text2, String text3, String text4, String text5, String text6)
        {
            conexionCarlos.updateSQL("update tipogasto set nombre = '" + text1 + "', descripcion = '" + text2 + "', fecha = '" + text3 + "', idempresa = '" + text4 + "', stat = '" + text5 + "' where idgasto ='" + text6 + "'");
        }
// TERMINA POLIZAPOLIZA


// INICIA POLIZACONTABLE
// CONSULTA POLIZACONTABLE
        public DataTable consultaPolizaContable()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select idcuenta, idcuentamadre, nombre from cuentacontable order by idcuenta desc");
            return dt;
        }
// BUSCA POLIZACONTABLE
        public DataTable buscarPolizaContable(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select idcuenta, idcuentamadre, nombre from cuentacontable where nombre like upper ('%" + buscarId + "%')");
            return dt;
        }
// LIMPIA POLIZACONTABLE
        public String limpiarPolizaContable(String text)
        {
            return "";
        }
// ELIMINAR POLIZACONTABLE
        public void eliminarPolizaContable(String text1)
        {
            conexionCarlos.deleteSQL("delete cuentacontable where idcuenta = '" + text1 + "'");
        }
// GUARDAR POLIZACONTABLE
        public void insertarPolizaContable(String text1, String text2, String text3, String text4, String text5)
        {
            String insert1 = "SET IDENTITY_INSERT cuentacontable ON insert into cuentacontable (idcuenta, idcuentamadre, nombre,idempresa,stat) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "') SET IDENTITY_INSERT cuentacontable OFF ";
            conexionCarlos.insertSQL(insert1);
        }
// ACTUALIZA POLIZACONTABLE
        public void actualizarPolizaContable(String text1, String text2, String text3, String text4, String text5)
        {
            conexionCarlos.updateSQL("update cuentacontable set idcuentamadre = '" + text1 + "', nombre = '" + text2 + "', idempresa= '" + text3 + "', stat = '" + text4 + "'  where idcuenta ='" + text5 + "'");
        }
// TERMINA POLIZACONTABLE








// INICIA ORDENPROD


// CONSULTA ORDENPROD
        public DataTable consultaOrdenProd()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select B.iddetordenprod as detalle, B.idordenproduccion, B.idrecetario, C.nombre, B.cantidad from ordenproduccion A, detordenprod B, recetario C where A.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario order by B.idordenproduccion desc");
            return dt;
        }
// BUSCA ORDENPROD
        public DataTable buscarOrdenProd(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select B.iddetordenprod as detalle, B.idordenproduccion, B.idrecetario, C.nombre, B.cantidad from ordenproduccion A, detordenprod B, recetario C where A.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and B.idordenproduccion = '" + buscarId + "' order by B.idordenproduccion desc)");
            return dt;
        }
// LIMPIAR ORDENPROD
        public String limpiarOrdenProd(String text)
        {
            return "";
        }
// ELIMINAR ORDENPROD
        public void eliminarOrdenProd(String text1)
        {
            conexionCarlos.deleteSQL("delete detordenprod where B.iddetordenprod = '" + text1 + "'");
        }
// GUARDA TIPO GASTO
        public void insertarOrdenProd(String text1, String text2, String text3, String text4)
        {
            String insert1 = "SET IDENTITY_INSERT detordenprod ON insert into detordenprod (iddetordenprod,cantidad,idordenproduccion,idrecetario) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "') SET IDENTITY_INSERT detordenprod OFF ";
            conexionCarlos.insertSQL(insert1);
        }
// ACTUALIZA ORDENPROD
        public void actualizarOrdenProd(String text1, String text2, String text3, String text4)
        {
            conexionCarlos.updateSQL("update detordenprod set cantidad = '" + text1 + "', idordenproduccion = '" + text2 + "', idrecetario = '" + text3 + "' where iddetordenprod ='" + text4 + "'");
        }

// TERMINA ORDENPROD





//INICIA LOGIN
        public String login(String user, String password)
        {
            String autenetic = "no";
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select password, idrol from usuario_1 where usuario = '" + user + "' ");

           
            if(dt.Rows.Count==1)
            {
                autenetic = dt.Rows[0][0].ToString();
                //System.Console.WriteLine("asdfasdfsdf" + dt.Rows.Count + password+autenetic);
                if (autenetic.Equals(password))
                {
                    autenetic = dt.Rows[0][1].ToString();
                 //   autenetic = "exitoso";
                }
                else
                {
                    autenetic = "no";
                }
            }
            
                
            
            return autenetic;
        }
//TERMINA LOGIN

    }
}
