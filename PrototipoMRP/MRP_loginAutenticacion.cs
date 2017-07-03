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

namespace PrototipoMRP
{
    public partial class MRP_loginAutenticacion : Form
    {
        public MRP_loginAutenticacion()
        {
            InitializeComponent();
        }
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
                MPRCL_Usuario user = new MPRCL_Usuario();
                user.CodigoEmpleado = 1;
                user.NombreEmpleado = txtusuario.Text;

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
    }
}
