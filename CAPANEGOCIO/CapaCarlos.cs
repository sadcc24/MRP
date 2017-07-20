//-- PROGRAMADO Y TRABAJADO POR CARLOS MANUEL PINEDA ESCOBAR
//-- TODOS LOS WINDOWS FORMS CON INICIAL CP TAMBIEN FUERON TRABAJADOS POR CARLOS PINEDA

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
  /*      MPRCL_Empresa empresa ;
        MPRCL_Usuario usuario ;
        DateTime tiempo = new DateTime();

        public CapaCarlos()
        {


        }

        public CapaC_arlos ()
        {
            
            System.Console.WriteLine("INGRESA AL CONSTRUCTOR");
            Parameters(usuario, empresa);
        }



        public void Parameters (MPRCL_Usuario user, MPRCL_Empresa emp)
        {
            System.Console.WriteLine("INGRESA AL PARAMETRO");
    
            empresa = emp;
            usuario = user;
            System.Console.WriteLine("INGRESA AL CONSTRUCTOR"+emp.NombreEmpresa);
        }
        */


        //INICIA PRORRATEO
        // BUSCAR EN PRORRATEO
        public DataTable buscarProrrateo(String buscarId)
        {
            dt = new DataTable(); 
            dt = conexionCarlos.getSQL("select D.idordenproduccion, C.nombre, sum(A.gastofabricacion) as CostoFabricacion, sum(C.costototalrecetario * B.cantidad) as MateriaPrima, sum(E.totalmo * B.cantidad) as ManoObra, (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))) as FactorX, ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) + ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) + ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion and D.idordenproduccion = '" + buscarId + "' group by D.idordenproduccion, B.cantidad, C.nombre order by D.idordenproduccion DESC");
            return dt;
        }
// CONSULTAR EN PRORRATEO
        public DataTable consultaProrrateo()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select D.idordenproduccion, C.nombre, sum(A.gastofabricacion) as CostoFabricacion, sum(C.costototalrecetario * B.cantidad) as MateriaPrima, sum(E.totalmo * B.cantidad) as ManoObra, (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) as CostoPrimo, (sum(A.gastofabricacion) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))) as FactorX, ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)))) as GastoIndsFabricaccionProrrateado, ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) + ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))))) as CostototalProduccion, B.cantidad, (((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) + ((sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad)) * (sum(A.gastofabricacion * B.cantidad) / (sum(C.costototalrecetario * B.cantidad) + sum(E.totalmo * B.cantidad))))) / B.cantidad) as CostoUnitario from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = E.idordenproduccion group by D.idordenproduccion, B.cantidad, C.nombre order by D.idordenproduccion DESC"); 
            return dt;
        }
        /*
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
        */
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
// BUSCA ID GASTOS
        public DataTable buscarGasto(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto and A.idrecetario = '" + buscarId + "'");
            return dt;
        }
// BUSCA nombre GASTOS
        public DataTable buscarGastoN(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idrecetario, A.nombre as receta, B.nombre as gasto, C.gastofabricacion as gastoconsumido  from recetario A, tipogasto B, recetariogasto C where A.idrecetario = C.idrecetario and C.idgasto = B.idgasto and A.nombre  like upper ('%" + buscarId + "%')");
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
            String insert1 = "SET IDENTITY_INSERT tipogasto ON insert into tipogasto (idgasto,nombre,descripcion) values ('" + text1 + "','" + text2 + "','" + text3 + "') SET IDENTITY_INSERT tipogasto OFF";
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
            dt = conexionCarlos.getSQL("select * from recetario order by idrecetario DESC");
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
// GUARDAR PRORRATEOPRODUCTO
        public void insertarProPro( String text2, String text3, String text4, String text5, String text6, String text7, String text8, String text9, String text10, String text11, String text12, String text13, String text14, String text15, String text16, String text17, String text18)
        {
            String insert1 = "insert into producto (descripcion,stockminimo,stockmaximo,activo,idproveedor,idtipoproducto,idmarca,fechacreacion,idmetodo,idlinea,tamano,peso,precio,costo,idempresa,unidadpeso,unidadtamano) values ('" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "','" + text11 + "','" + text12 + "','" + text13 + "','" + text14 + "','" + text15 + "','" + text16 + "','" + text17 + "','" + text18 + "') ";
           conexionCarlos.insertSQL(insert1);

            //System.Console.WriteLine(usuario.NombreEmpleado + "6dhhedh554e45e45e4o" + empresa.NombreEmpresa + tiempo);
            //   Parameters(usuario, empresa);
           // insertarBitacora(usuario.NombreEmpleado, "inserta producto", empresa.NombreEmpresa, tiempo);
            
            // insertarBitacora("carlos 2", "inserta producto", "3", tiempo);

        }
// ELIMINAR PRORRATEOPRODUCTO
        public void eliminarProPro(String text1)
        {
            conexionCarlos.deleteSQL("delete producto where idproducto = ('" + text1 + "')");
        }

// LIMPIA PRORRATEO PRODUCTO
        public String limpiarProPro(String text)
        {
            return "";
        }

// ACTUALIZA PRORRATEOPRODUCTO
        public void actualizarProPro(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8, String text9, String text10, String text11, String text12, String text13, String text14, String text15, String text16, String text17, String text18)
        {
            conexionCarlos.updateSQL("update producto set descripcion = '" + text1 + "', stockminimo = '" + text2 + "', stockmaximo = '" + text3 + "', activo = '" + text4 + "', idproveedor = '" + text5 + "', idtipoproducto = '" + text6 + "', idmarca = '" + text7 + "', fechacreacion = '" + text8 + "', idmetodo = '" + text9 + "', idlinea = '" + text10 + "', tamano = '" + text11 + "', peso = '" + text12 + "', precio = '" + text13 + "', costo = '" + text14 + "', idempresa = '" + text15 + "', unidadpeso = '" + text16 + "', unidadtamano = '" + text17 + "' where idproducto ='" + text18 + "'");
        }
// TERMINA PRORRATEO PRODUCTO


// INICIA POLIZA
// BUSCA POR DESCRIPCION
        public DataTable buscarPoliza(String buscarId, String buscarId2)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select (sum(A.gastofabricacion) + sum(E.totalmo * B.cantidad)) as costomanufactura from recetariogasto A, detordenprod B, recetario C, ordenproduccion D, detallemouno E where D.idordenproduccion = B.idordenproduccion and B.idrecetario = C.idrecetario and C.idrecetario = A.idrecetario and D.idordenproduccion = B.idordenproduccion and D.idordenproduccion = E.idordenproduccion and D.fechacreacion between('" + buscarId + "') and ('" + buscarId2 + "')  ");
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
            conexionCarlos.updateSQL("update poliza set nombre = '" + text1 + "', descripcion = '" + text2 + "', fecha = '" + text3 + "', idempresa = '" + text4 + "', stat = '" + text5 + "' where idpoliza ='" + text6 + "'");
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


// INICIA ORDENPROD (confirmacion de pedido)
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


// INICIA GASTOLUZ
        public String operaUno(String watts, String uso)
        {
            Decimal num1, num2, operar;
            num1 = Convert.ToDecimal(watts);
            num2 = Convert.ToDecimal(uso);
            operar = (num1 / 1000) * num2;
            String calculouno="";
            calculouno = Convert.ToString(operar);
            return calculouno;
        }
// TERMINA GASTOLUZ



// INICIA EXISTENCIA
 public DataTable consultaExistencia()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idbodega, C.nombre_bodega, A.idproducto, B.descripcion, A.cantidad from existencia A, producto B, bodega C where A.idproducto = B.idproducto and A.idbodega = C.idbodega");
            return dt;
        }
// BUSCA TIPO GASTO
        public DataTable buscarExistenciaP(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idbodega, C.nombre_bodega, A.idproducto, B.descripcion, A.cantidad from existencia A, producto B, bodega C where A.idproducto = B.idproducto and A.idbodega = C.idbodega and B.descripcion like ('%" + buscarId + "%')");
            return dt;
        }
        public DataTable buscarExistenciaB(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.idbodega, C.nombre_bodega, A.idproducto, B.descripcion, A.cantidad from existencia A, producto B, bodega C where A.idproducto = B.idproducto and A.idbodega = C.idbodega and B.nombre_bodega like ('%" + buscarId + "%')");
            return dt;
        }
// INSERTAR EXISTENCIA
        public void insertarExistencia(String text1, String text2, String text3)
        {
            String insert1 = "insert into existencia (idbodega,idproducto,cantidad) values ('" + text1 + "','" + text2 + "','" + text3 + "')";
            conexionCarlos.insertSQL(insert1);
        }
// ACTUALIZA EXISTENCIA
        public void actualizarExistencia(String text1, String text2, String text3)
        {
            conexionCarlos.updateSQL("update existencia set cantidad = '" + text1 + "' where idbodega ='" + text2 + "' and idproducto = '" + text3 + "'");
        }


// PROVEEDOR
         public DataTable consultaProveedor()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from proveedor order by idproveedor desc");
            return dt;
        }

        public DataTable buscarProveedor(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from proveedor where nombre_proveedor like upper ('%" + buscarId + "%')");
            return dt;
        }
// TIPOPRODUCTO
        public DataTable consultaTipoPro()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from TIPOPRODUCTO order by idtipoproducto desc");
            return dt;
        }

        public DataTable buscarTipoPro(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from TIPOPRODUCTO where descripcion like upper ('%" + buscarId + "%')");
            return dt;
        }


// MARCA
        public DataTable consultaMarca()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from marca order by idmarca desc");
            return dt;
        }

        public DataTable buscarMarca(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from marca where descripcion like upper ('%" + buscarId + "%')");
            return dt;
        }


// METODO
        public DataTable consultaMetodo()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from METODOCOSTEO order by idmetodo desc");
            return dt;
        }

        public DataTable buscarMetodo(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from METODOCOSTEO where nommetodo like upper ('%" + buscarId + "%')");
            return dt;
        }


// LINEA
        public DataTable consultaLinea()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from LINEA order by idlinea desc");
            return dt;
        }

        public DataTable buscarLinea(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from LINEA where descripcion like upper ('%" + buscarId + "%')");
            return dt;
        }

// EMPRESA  
        public DataTable consultaEmpresa()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from empresa order by idempresa desc");
            return dt;
        }

        public DataTable buscarEmpresa(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from empresa where nombre_empresa like upper ('%" + buscarId + "%')");
            return dt;
        }







//////// REVISION DE PRORRATEO

        public DataTable revisaRecetario()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from recetario order by idrecetario desc");
            return dt;
        }

        public DataTable revisaManoobra()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from detallemouno order by iddetallemouno desc");
            return dt;
        }

        public DataTable revisaDetordenprod()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from detordenprod order by iddetordenprod desc");
            return dt;
        }

        public DataTable revisaOrdenproduccion()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select A.* from ordenproduccion A, estadoordenpla B where B.idestado = 1 order by idordenproduccion desc");
            return dt;
        }
        public DataTable revisaGastosFabrica()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from recetariogasto order by idrecetario desc");
            return dt;
        }

///// TERMINA REVISION PARA PRORRATEO








// COMIENZA PARTE POR SI NO LO TRABAJAN
// consulta detalle de recetario
 public DataTable consultaDetalleReceta()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from DETALLERECETARIO order by idrecetario desc");
            return dt;
        }
// BUSCA ID GASTOS
        public DataTable buscarDetalleReceta(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from DETALLERECETARIO where idrecetario = '" + buscarId + "' order by idrecetario desc");
            return dt;
        }
// SUMA 
        public DataTable consultaSumaReceta(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select sum(A.costoequivalente) as suma, A.idrecetario from DETALLERECETARIO A, Recetario B where A.idrecetario = B.idrecetario and A.idrecetario = '" + buscarId + "' group by A.idrecetario");
            return dt;
        }
// LIMPIA RECETA
        public String limpiarReceta(String text)
        {
            return "";
        }
// INSERTAR RECETA
        public void insertarReceta(String text1, String text2, String text3, String text4, String text5, String text6, String text7)
        {
            String insert1 = "SET IDENTITY_INSERT recetario ON insert into recetario (idrecetario,fechacreacion,nombre,descripcion,totalcantidad,idempresa,costototalrecetario) values ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "') SET IDENTITY_INSERT recetario OFF";
            conexionCarlos.insertSQL(insert1);
        }
// ELIMINA REGISTRO
        public void eliminarReceta(String text1)
        {
            conexionCarlos.deleteSQL("delete Recetario where idrecetario ='" + text1 + "'");
        }
// ACTUALIZA REGISTRO
        public void actualizarReceta(String text1, String text2, String text3, String text4, String text5, String text6)
        {
            conexionCarlos.updateSQL ("update recetario set nombre = '" + text1 + "', descripcion = '" + text2 + "', totalcantidad = '" + text3 + "', idempresa = '" + text4 + "', costototalrecetario = '" + text5 + "' where idrecetario = '" + text6 + "' ");
        }









// consulta detalle de recetario
        public DataTable consultaDetalleReceta1()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from DETALLERECETARIO order by idrecetario desc");
            return dt;
        }
// BUSCA ID GASTOS
        public DataTable buscarDetalleReceta1(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from DETALLERECETARIO where idrecetario = '" + buscarId + "' order by idrecetario desc");
            return dt;
        }
// LIMPIA RECETA
        public String limpiarDetalleReceta(String text)
        {
            return "";
        }
// INSERTAR DETALLE RECETA
        public void insertarDetalleReceta(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8)
        {
            String insert1 = "SET IDENTITY_INSERT DETALLERECETARIO ON insert into DETALLERECETARIO (iddetallerecetario, cantidad, idproducto, idrecetario, unidadusar, cantequivalente, costoequivalente, costoproducto) values  ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "','" + text8 + "')  SET IDENTITY_INSERT DETALLERECETARIO  OFF";
            conexionCarlos.insertSQL(insert1);
        }
// ELIMINA REGISTRO
        public void eliminarDetalleReceta(String text1)
        {
            conexionCarlos.deleteSQL("delete DETALLERECETARIO where iddetallerecetario ='" + text1 + "'");
        }
// ACTUALIZA REGISTRO
        public void actualizarDetalleReceta(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8)
        {
            conexionCarlos.updateSQL ("update DETALLERECETARIO set cantidad = '" + text1 + "', idproducto = '" + text2 + "', idrecetario = '" + text3 + "', unidadusar = '" + text4 + "', cantequivalente = '" + text5 + "', costoequivalente = '" + text6 + "', costoproducto = '" + text7 + "' where iddetallerecetario = '" + text8 + "' ");
        }





        

// CONSULTA ORDEN DE PRODUCCION
        public DataTable consultaOrden()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from ordenproduccion order by idordenproduccion desc");
            return dt;
        }
// BUSCA ID ORDEN DE PRODUCCION
        public DataTable buscarOrden(String buscarId)
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from ordenproduccion where idordenproduccion = '" + buscarId + "' order by idordenproduccion desc");
            return dt;
        }
// LIMPIA ORDEN DE PRODUCCION
        public String limpiarOrden(String text)
        {
            return "";
        }
// INSERTAR ORDEN DE PRODUCCION
        public void insertarOrden(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8, String text9)
        {
            String insert1 = "SET IDENTITY_INSERT ordenproduccion ON insert into ordenproduccion (idordenproduccion, fechacreacion, fechasolicitud, fechaenvio, descripcion, totalcantidad, referencia, idestado, idempresa) values  ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "') SET IDENTITY_INSERT ordenproduccion OFF";
            conexionCarlos.insertSQL(insert1);
        }
// ELIMINA REGISTRO DE ORDEN DE PRODUCCION
        public void eliminarOrden(String text1)
        {
            conexionCarlos.deleteSQL("delete ordenproduccion where idordenproduccion ='" + text1 + "'");
        }
// ACTUALIZA REGISTRO DE ORDEN DE PRODUCCION
        public void actualizarOrden(String text1, String text2, String text3, String text4, String text5, String text6, String text7, String text8, String text9)
        {
            conexionCarlos.updateSQL ("update ordenproduccion set fechacreacion = '" + text1 + "', fechasolicitud = '" + text2 + "', fechaenvio = '" + text3 + "', descripcion = '" + text4 + "', totalcantidad = '" + text5 + "', referencia = '" + text6 + "', idestado = '" + text7 + "', idempresa = '" + text8 + "' where idordenproduccion = '" + text9 + "' ");
        }








// ESTADO ORDEN DE PRODUCCION
        public DataTable consultaEstadoOrden()
        {
            dt = new DataTable();
            dt = conexionCarlos.getSQL("select * from ESTADOORDENPLA");
            return dt;
        }







// BITACORA

             public void insertarBitacora(String text1, String text2, String text3, DateTime text4)
        {
            String insert1 = "insert into BitacoraCarlos (usuario, transaccion, empresa, fecha) values  ('" + text1 + "','" + text2 + "','" + text3 + "','" + text4 + "' ) ";
            conexionCarlos.insertSQL(insert1);
        }







    }
}
