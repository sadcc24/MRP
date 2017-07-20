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
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (txtusuario.Text == string.Empty) {
        //       MessageBox.Show("Debe ingresar un usuario");
        //       return;
        //    }else if (txtcontraseña.Text == string.Empty)
        //    {

        //        MessageBox.Show("Debe ingresar contraseña");
        //        return;
        //    }
        //  else                
        //      {
        //        //MPRCL_Usuario user = new MPRCL_Usuario();
        //        //user.CodigoEmpleado = 1;
        //        //user.NombreEmpleado = txtusuario.Text;

        //        //MRP_frmEmpresa emp = new MRP_frmEmpresa(user);
        //        //this.Hide();
        //        //emp.Show();
        //    }            
        //}



// CREADO POR CARLOS PINEDA
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }
            else if (txtcontraseña.Text == string.Empty)
            {

                MessageBox.Show("Debe ingresar contraseña");
                return;
            }
            else
            {

                //LOGIN CARLOS
                CAPANEGOCIO.CapaCarlos logi = new CAPANEGOCIO.CapaCarlos();
                String autenticacion = logi.login(txtusuario.Text, txtcontraseña.Text);
                if (autenticacion.Equals("no"))
                {
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

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contacte con recursos humanos", "MRP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
