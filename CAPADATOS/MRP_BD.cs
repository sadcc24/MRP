using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

public class MRP_BD
{

    private String Servidor = null;
    private String B_Datos = null;
    private String Usuario = null;
    private String Passs = null;
    private SqlCommand comando;
    public SqlConnection conexion = null;

    public MRP_BD()
    {
        Servidor = ConfigurationManager.AppSettings["txtservidor"];
        B_Datos = ConfigurationManager.AppSettings["txtbd"];
        Usuario = ConfigurationManager.AppSettings["txtusuario"];
        Passs = ConfigurationManager.AppSettings["txtpass"];

        //Servidor = @".\SQL"; //"aqui deben ingresar el servidor de su maquina que estan haciendo pruebas";
        //B_Datos = "BDSAD17";//"ingresan la base de datos donde estan trabajando";
        //Usuario = "canel";// "usuario para autenticacion para conectarse ala base de datos";
        //Passs = "canel"; // "passwor para la autenticacion del usuario que se esten conectando";


        //Servidor = "erpseminario.database.windows.net";
        //B_Datos = "ERPSeminario";
        //Usuario = "adminseminario";
        //Passs = "S@dseminario";

     String cadena = "Data Source= " + Servidor + "; Initial Catalog=" + B_Datos + "; User Id=" + Usuario + "; Password=" + Passs + ";";
        //String cadena = @"Data Source=.\SQL; Initial Catalog=BD_PRUEBA; User Id=canel; Password=canel;";
        conexion = new SqlConnection(cadena);
    }

    public MRP_BD(String user, string pass, string bd, string server) {
        Servidor = @""+server;
        B_Datos = bd;
        Usuario = user;
        Passs = pass;
        String cadena = "Data Source= " + Servidor + "; Initial Catalog=" + B_Datos + "; User Id=" + Usuario + "; Password=" + Passs + ";";        
        conexion = new SqlConnection(cadena);

    }

    public void insertSQL(String QInsert)
    {
        try
        {

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            comando = new SqlCommand(QInsert, conexion);

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.InsertCommand = comando.Connection.CreateCommand();
            adap.InsertCommand.CommandText = QInsert;
            adap.InsertCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            conexion.Close();
        }
        /*        if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
        */
    }



    public void deleteSQL(String QInsert, SqlTransaction tran = null)
    {
        try
        {

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            comando = new SqlCommand(QInsert, conexion);

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.DeleteCommand = comando.Connection.CreateCommand();
            adap.DeleteCommand.CommandText = QInsert;
            adap.DeleteCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            conexion.Close();
        }


    }
    public void updateSQL(String QInsert, SqlTransaction tran = null)
    {
        try
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            comando = new SqlCommand(QInsert, conexion);


            SqlDataAdapter adap = new SqlDataAdapter();

            adap.UpdateCommand = comando.Connection.CreateCommand();
            adap.UpdateCommand.CommandText = QInsert;
            adap.UpdateCommand.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            conexion.Close();
        }


    }
    public DataTable getSQL(String QConsulta)
    {
        DataTable dt = null;
        try
        {
            dt = new DataTable();
        if (conexion.State != System.Data.ConnectionState.Open)
        {
            conexion.Open();
        }
        comando = new SqlCommand(QConsulta, conexion);
        SqlDataAdapter adap = new SqlDataAdapter();
        adap.SelectCommand = comando;
        adap.Fill(dt);
        if (conexion.State != System.Data.ConnectionState.Closed)
        {
            conexion.Close();
        }
        return dt;
        }
        catch (Exception ex)
        {
            return dt;
        }
    }

}
