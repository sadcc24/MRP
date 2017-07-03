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
    public partial class OP_AsignacionTareaMRP : Form
    {
        public OP_AsignacionTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select coddetalletarea as 'Codigo Asignacion', codtarea as 'Cod Tarea', codtipo as 'Cod Fase' from detalletarea");
        }
        private void AsignacionTareaMRP_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            cmdfase.DataSource = PRUEBA.getSQL("select codtipo, nombre from fasetarea");
            cmdfase.DisplayMember = "nombre";
            cmdfase.ValueMember = "codtipo";

            cmdtarea.DataSource = PRUEBA.getSQL("select codtarea, nombre from tarea");
            cmdtarea.DisplayMember = "nombre";
            cmdtarea.ValueMember = "codtarea";

            consulta();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLETAREA] (codtarea,codtipo) values ('" + cmdtarea.SelectedValue.ToString() + "','" + cmdfase.SelectedValue.ToString() + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            cmdfase.Text = "";
            cmdtarea.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[DETALLETAREA] where coddetalletarea = '" + txtcodigo.Text + "'");
            MessageBox.Show("Seguro que desea eliminar la asignacion?", "seguro que desea eliminar la asignacion?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update detalletarea set codtarea ='" + cmdtarea.SelectedValue.ToString()+"',codtipo= '" + cmdfase.SelectedValue.ToString() + "' where coddetalletarea='" + txtcodigo.Text + "'");
            consulta();
        }
    }
}
