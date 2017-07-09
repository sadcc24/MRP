//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: autenticacion de los usuarios cuando ingresan al sistema
using CAPANEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrototipoMRP
{
    public partial class MRP_loginAutenticacion : Form
    {
        public MRP_loginAutenticacion()
        {
            InitializeComponent();
        }
/*

        SqlConnection con = new SqlConnection(@"Data Source=erpseminario.database.windows.net; Initial Catalog=ERPSeminario; User Id=adminseminario; Password=S@dseminario");
        

        public void log (String usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select usuario, idrol from usuario_1 where usuario = @usuario and password = @pas",con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count ==1) {
                    this.Hide();
                    if(dt.Rows[0][1].ToString()=="1")
                    {
                        new Admin(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                    }
                else {
                    MessageBox.Show("usuario o contraseña incorrecta");
                }





            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        */



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == string.Empty) {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }else if (txtcontraseña.Text == string.Empty)
            {

                MessageBox.Show("Debe ingresar contraseña");
                return;
            }
            else                
                {

//LOGIN CARLOS
                CAPANEGOCIO.CapaCarlos logi = new CAPANEGOCIO.CapaCarlos();
                String autenticacion = logi.login(txtusuario.Text, txtcontraseña.Text);
                if (autenticacion.Equals("no")) {
                    MessageBox.Show("usuario incorrecto");
                    return;
                }
 



                MPRCL_Usuario user = new MPRCL_Usuario();
                user.CodigoEmpleado = 1;
                user.NombreEmpleado = txtusuario.Text;
                user.rollEmpleado = autenticacion;

                MRP_frmEmpresa emp = new MRP_frmEmpresa(user);
                this.Hide();
                emp.Show();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MRP_loginAutenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}
