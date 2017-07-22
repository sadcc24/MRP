//Programador: Olivia Perez
//Analista: Olivia Perez
//Comentarios: Form para calculo de mano de obra

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
    public partial class OP_DetalleMO : Form
    {
        public OP_DetalleMO()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();

        //SqlConnection conexion = new SqlConnection("Data Source= erpseminario.database.windows.net; Initial Catalog=ERPSeminario; User Id=adminseminario; Password=S@dseminario;");
        SqlConnection conexion = new MRP_BD().conexion;



        public void limpiar()
        {
            txtcodigo.Text = "";
            txttotalmo.Text = "";
            txttotalhoras.Text = "";
            txtempleado.Text = "";
            txtTarea.Text = "";
            txthoras.Text = "";
            cmbasignacionmo.Text = "";
            cmbasignacion.Text = "";
            cmbproduccion.Text = "";
            

        }

        public void consulta()
        {
            dgvdetalles.DataSource = PRUEBA.getSQL("select iddetalletarea as 'Cod Detalle', idfase as 'Cod Fase', idtarea as 'Cod Tarea', empleado as 'Cod Empleado',correlativofase as 'Horas Requeridas',costoporfase as 'Costo Tarea' from detalletarea");
        }


        public void codigo()
        {
            conexion.Open();
          
            SqlCommand sueldo = new SqlCommand("SELECT IDENT_CURRENT ('DETALLEMOUNO') AS Current_Identity", conexion);
            SqlDataReader leer;
            leer = sueldo.ExecuteReader();
            while (leer.Read() == true)
            {
                txtcodigo.Text = leer["Current_Identity"].ToString();

            }
            conexion.Close();
        }

        public void sumar()
        {
            int primernumero;
            int segundonumero;
            int resultado;
            primernumero = int.Parse(txtcodigo.Text);

            segundonumero = 1;

            resultado = (primernumero + segundonumero);

            txtcodigodos.Text = resultado.ToString();
        }
        private void OP_DetalleMO_Load(object sender, EventArgs e)
        {
            codigo();
            sumar();
            consulta();
            txtcodigo.Enabled = false;
            cmbproduccion.DataSource = PRUEBA.getSQL("select idordenproduccion from ORDENPRODUCCION");
            cmbproduccion.DisplayMember = "idordenproduccion";
            cmbproduccion.ValueMember = "idordenproduccion";

            cmbproducto.DataSource = PRUEBA.getSQL("select idrecetario,nombre from RECETARIO");
            cmbproducto.DisplayMember = "nombre";
            cmbproducto.ValueMember = "idrecetario";

            cmbasignacion.DataSource = PRUEBA.getSQL("select idasignaciontareas from ASIGNACIONTAREAS");
            cmbasignacion.DisplayMember = "idasignaciontareas";
            cmbasignacion.ValueMember = "idasignaciontareas";


            cmbasignacionmo.DataSource = PRUEBA.getSQL("select idmanoobra from MANOOBRA");
            cmbasignacionmo.DisplayMember = "idmanoobra";
            cmbasignacionmo.ValueMember = "idmanoobra";
        }
        private void dgvdetalles_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            string tarea = this.dgvdetalles.CurrentRow.Cells[1].Value.ToString();
            txtTarea.Text = tarea;

            string empleado = this.dgvdetalles.CurrentRow.Cells[2].Value.ToString();
            txtempleado.Text = empleado;
        }
            
           
        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigodos.Enabled = true;
            limpiar();
        }

        public void sumatoria()
        {
            int suma = 0;
            int sumas = 0;

            foreach (DataGridViewRow row in dgvdetalles.Rows)
            {
                if((string)row.Cells[0].Value == "T")
                {
                    suma += Convert.ToInt32(row.Cells[5].Value);
                    sumas += Convert.ToInt32(row.Cells[6].Value);

                }
                txttotalhoras.Text = Convert.ToString(suma);
                txttotalmo.Text = Convert.ToString(sumas);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            sumatoria();
            
        }

        private void dgvdetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLEMOUNO] (horasrequeridas,totalmo,costo,fecha,idmanoobra,idordenproduccion,idrecetario,idasignaciontareas)values ('" + txttotalhoras.Text + "','" + txttotalmo.Text + "','" + txtTarea.Text + "','" + dtfecha.Value.ToString("yyyy-MM-dd") + "','" + cmbasignacionmo.SelectedValue.ToString() + "','"+cmbproduccion.SelectedValue.ToString()+"','"+cmbproducto.SelectedValue.ToString()+"', '"+cmbasignacion.SelectedValue.ToString()+"')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar la informacion?", "Confirmacion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PRUEBA.deleteSQL("delete [dbo].[DETALLEMOUNO] where iddetallemouno = '" + txtcodigo.Text + "'");
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txttotalcosto.Text = "";
            txttotalhoras.Text = "";
            txttotalmo.Text = "";
            cmbasignacion.Text = "";
            cmbproduccion.Text = "";
            cmbproducto.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
        public void insertarMOdos()
        {
                    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            PRUEBA.updateSQL("update DETALLEMOUNO set fecha ='" + dtfecha.Value.ToString("yyyy-MM-dd") + "',idordenproduccion= '" + cmbproduccion.Text + "',idrecetario='" + cmbproducto.SelectedValue.ToString() + "',idasignaciontareas='" + cmbasignacion.Text + "' where iddetallemouno='" + txtcodigo.Text + "'");
            consulta();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            insertarMOdos();
        }

        private void dgvdetalles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

            
        }
        private void agregar()
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLEMODOS] (horas,producto,empleado,tarea,iddetallemouno)values ('" + txthoras.Text + "','" + cmbproducto.SelectedValue.ToString() + "', '" + txtempleado.Text + "','" + txtTarea.Text + "','" + txtcodigodos.Text+ "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OP_DetalleMO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvdetalles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tarea = this.dgvdetalles.CurrentRow.Cells[6].Value.ToString();
            txtTarea.Text = tarea;

            string empleado = this.dgvdetalles.CurrentRow.Cells[4].Value.ToString();
            txtempleado.Text = empleado;

            string horas = this.dgvdetalles.CurrentRow.Cells[5].Value.ToString();
            txthoras.Text = horas;

            txtTarea.Visible = true;
            txtempleado.Visible = true;
            txthoras.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            agregar();
        }
    }
}
