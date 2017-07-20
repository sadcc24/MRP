//Programador: Olivia Perez
//Analista: Olivia Perez
//Comentarios: Form para asignacion de los recursos antes ingresado



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
    public partial class OP_AsignacionTareaMRP : Form
    {
        public OP_AsignacionTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();

        SqlConnection saldo = new SqlConnection("Data Source= erpseminario.database.windows.net; Initial Catalog=ERPSeminario; User Id=adminseminario; Password=S@dseminario;");

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select iddetalletarea as 'Codigo Asignacion', idtarea as 'Cod Tarea', idfase as 'Cod Fase', empleado as 'Cod Empleado', correlativofase as 'Horas Requeridas',costoporfase as 'Costo por Tarea' from detalletarea");
        }
        private void AsignacionTareaMRP_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            cmdfase.DataSource = PRUEBA.getSQL("select idfase, nombre from fasetarea");
            cmdfase.DisplayMember = "nombre";
            cmdfase.ValueMember = "idfase";

            cmdtarea.DataSource = PRUEBA.getSQL("select idtarea, nombre from tarea");
            cmdtarea.DisplayMember = "nombre";
            cmdtarea.ValueMember = "idtarea";

            cmbempleado.DataSource = PRUEBA.getSQL("select idempleado,id_empleado from contrato");
            cmbempleado.DisplayMember = "idempleado";
            cmbempleado.ValueMember = "idempleado";

            consulta();

        }

        public void multiplicar()
        {
            saldo.Open();
            SqlCommand sueldo = new SqlCommand("SELECT salario_ordinario from CONTRATO where idempleado = '"+cmbempleado.SelectedValue.ToString()+"'",saldo);
            SqlDataReader leer;
            leer = sueldo.ExecuteReader();
            while (leer.Read() == true)
            {
                txtcosto.Text = leer["salario_ordinario"].ToString();
                
            }
            saldo.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLETAREA] (correlativofase,costoporfase,idtarea,idfase,empleado) values ('"+txtcorrelativo.Text+"','"+txtresultado.Text+"','" + cmdtarea.SelectedValue.ToString() + "','" + cmdfase.SelectedValue.ToString() + "','"+cmbempleado.SelectedValue.ToString()+"')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            cmdfase.Text = "";
            cmdtarea.Text = "";
            txtcorrelativo.Text = "";
            txtcosto.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";
            txtcorrelativo.Text = "";
            txtcosto.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
            multiplicar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la informacion?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PRUEBA.deleteSQL("delete [dbo].[DETALLETAREA] where iddetalletarea = '" + txtcodigo.Text + "'");
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
           
            
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update detalletarea set correlativofase='"+txtcorrelativo.Text+"',costoporfase='"+txtcosto.Text+"' idtarea='" + cmdtarea.SelectedValue.ToString()+"',idfase= '" + cmdfase.SelectedValue.ToString() + "' where iddetalletarea='" + txtcodigo.Text + "'");
            consulta();
        }
        public void calcular()
        {
            int primernumero;
            int segundonumero;
            int resultado;

            
            
                primernumero = int.Parse(txtcosto.Text);

                segundonumero = int.Parse(txtcorrelativo.Text);

            resultado = (primernumero * segundonumero)/9600;

                txtresultado.Text = resultado.ToString();



            }
        private void button8_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
