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
    public partial class OP_AsignacionTareados : Form
    {
        public OP_AsignacionTareados()
        {
            InitializeComponent();
        }

        MRP_BD PRUEBA = new MRP_BD();

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select idasignaciontareas as 'Codigo',horasunidad as 'Horas',iddetalletarea as 'Codigo Tarea' from asignaciontareas");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[ASIGNACIONTAREAS] (horasunidad,iddetalletarea) values ('" + txthoras.Text+ "','" + cmbtarea.SelectedValue.ToString() + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbtarea.Text = "";
            txthoras.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[asignaciontareas] where idasignaciontareas = '" + txtcodigo.Text + "'");
            MessageBox.Show("Seguro que desea eliminar la asignacion?", "seguro que desea eliminar la asignacion?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update asignaciontareas set horasunidad='" + txthoras.Text + "',iddetalletarea='" + cmbtarea.SelectedValue.ToString() + "' where idasignaciontareas='" + txtcodigo.Text + "'");
            MessageBox.Show("Modificacion Exitosa", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
            cmbtarea.Text = "";
            txthoras.Text = "";
            txtcodigo.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            cmbtarea.Text = "";
            txthoras.Text = "";
        }

        private void OP_AsignacionTareados_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            consulta();
            cmbtarea.DataSource = PRUEBA.getSQL("select iddetalletarea from detalletarea");
            cmbtarea.DisplayMember = "iddetalletarea";
            cmbtarea.ValueMember = "iddetalletarea";
        }
    }
}
